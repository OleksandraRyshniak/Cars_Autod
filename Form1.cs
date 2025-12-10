using Cars.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Cars
{
    public partial class Form1 : Form
    {
        //Update-Database
        private CarsContext _db;

        public Form1()
        {
            InitializeComponent();
            _db = new CarsContext();
            LoeOmanik();
            LaeOmanik();
            LoeCar();
            LaeCars();
            LoeCarServices();
            LaeTeenused();
            using (var db = new CarsContext())
            {
                db.Database.EnsureCreated();
            }
        }
        private void LoeOmanik()
        {
            omanik_data.DataSource = _db.Owners.Select(o => new
            {
                o.Id,
                o.FullName,
                o.Phone
            }).ToList();
            if (omanik_data.Columns["Id"] != null)
                omanik_data.Columns["Id"].Visible = false;
        }
        private void LaeOmanik()
        {
            omanik_com_box.DataSource = _db.Owners.ToList();
            omanik_com_box.DisplayMember = "FullName";
            omanik_com_box.ValueMember = "Id";
            omanik_com_box.SelectedIndex = -1;
        }
        private void LoeCar()
        {
            autod_data.DataSource = _db.Cars.Include(c => c.Owner).Select(c => new
            {
                c.Id,
                c.Brand,
                c.Model,
                c.RegistrationNumber,
                Owner = c.Owner.FullName,
                c.OwnerId

            }).ToList();
            autod_data.Columns["Id"].Visible = false;
            if (autod_data.Columns["OwnerId"] != null)
            {
                autod_data.Columns["OwnerId"].Visible = false;
            }
        }
        private void LaeCars()
        {
            auto_com_box.DataSource = _db.Cars.ToList();
            auto_com_box.DisplayMember = "RegistrationNumber";
            auto_com_box.ValueMember = "Id";
            auto_com_box.SelectedIndex = -1;
        }
        private void LoeCarServices()
        {
            hooldus_data.DataSource = _db.CarServices
                .Include(cs => cs.Service)
                .Include(cs => cs.Car)
                .Select(cs => new
                {
                    Car = cs.Car.RegistrationNumber,
                    cs.CarId,
                    Service = cs.Service.Name,
                    cs.ServiceId,
                    cs.DateOfService,
                    cs.Mileage
                })
                .ToList();
            if (hooldus_data.Columns["CarId"] != null)
            {
                hooldus_data.Columns["CarId"].Visible = false;
            }
            if (hooldus_data.Columns["ServiceId"] != null)
            {
                hooldus_data.Columns["ServiceId"].Visible = false;
            }

        }
        private void LaeTeenused()
        {
            teenus_com_box.DataSource = _db.Services.ToList();
            teenus_com_box.DisplayMember = "Name";
            teenus_com_box.ValueMember = "Id";
            teenus_com_box.SelectedIndex = -1;
        }
        private void lisa_btn_Click(object sender, EventArgs e)
        {
            if (tab_control.SelectedTab == omanik_page)
            {
                if (string.IsNullOrWhiteSpace(txt_box_full_name.Text))
                {
                    MessageBox.Show("Ees- ja perekonnanimi on kohustuslik!");
                    return;
                }
                var phoneExists = _db.Owners.Any(o => o.Phone == txt_box_phone.Text);
                if (phoneExists)
                {
                    MessageBox.Show("Selline telefoninumber on juba olemas!"); 
                    return;
                }

                var uus = new Owner
                {
                    FullName = txt_box_full_name.Text,
                    Phone = txt_box_phone.Text,
                };
                _db.Owners.Add(uus);
                _db.SaveChanges();
                LoeOmanik();
                puhasta();

            }
            else if (tab_control.SelectedTab == auto_page)
            {
                if (omanik_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige omanik!");
                    return;
                }
                var regnumExists = _db.Cars.Any(o => o.RegistrationNumber == auto_reg_num_text_box.Text);
                if (regnumExists)
                {
                    MessageBox.Show("Selline regnumber on juba olemas!");
                    return;
                }
                var uus1 = new Car
                {
                    Brand = automark_text_box.Text,
                    Model = automudel_txt_box.Text,
                    RegistrationNumber = auto_reg_num_text_box.Text,
                    OwnerId = (int)omanik_com_box.SelectedValue
                };

                _db.Cars.Add(uus1);
                _db.SaveChanges();
                LoeCar();
                puhasta();
            }
            else if (tab_control.SelectedTab == hool_teen_page)
            {
                if (auto_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige auto!");
                    return;
                }
                if (teenus_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige teenus!");
                    return;
                }
                if (!DateTime.TryParse(kuup_txt_box.Text, out DateTime kuup) ||
                    !DateTime.TryParse(time_txt_box.Text, out DateTime time) ||
                    !int.TryParse(aeg_txt_box.Text, out int mileage))
                {
                    MessageBox.Show("Kuupäev või aeg või läbisõit on valesformaadis!");
                    return;
                }

                var dateTimeOfService = new DateTime(
                    kuup.Year,
                    kuup.Month,
                    kuup.Day,
                    time.Hour,
                    time.Minute,
                    0
                );

                var selectedCarId = (int)auto_com_box.SelectedValue;
                var selectedDate = kuup.Date;

                var dateExists = _db.CarServices.Any(cs =>
                    cs.CarId == selectedCarId &&
                    cs.DateOfService >= selectedDate &&
                    cs.DateOfService < selectedDate.AddDays(1));

                if (dateExists)
                {
                    MessageBox.Show("Sellele kuupäevale on juba teenus olemas!");
                    return;
                }

                var uus2 = new CarService
                {
                    CarId = selectedCarId,
                    ServiceId = (int)teenus_com_box.SelectedValue,
                    DateOfService = dateTimeOfService,
                    Mileage = mileage
                };

                _db.CarServices.Add(uus2);
                _db.SaveChanges();
                LoeCarServices();
                puhasta();

            }
        }
        private void nimi_otsi_btn_Click(object sender, EventArgs e)
        {
            if (tab_control.SelectedTab == omanik_page)
            {
                if (string.IsNullOrWhiteSpace(txt_box_full_name.Text) && string.IsNullOrEmpty(txt_box_phone.Text))
                {
                    MessageBox.Show("Sisesta omaniku nimi või telefoninumber!");
                }
                else
                {
                    var query = _db.Owners.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(txt_box_full_name.Text))
                    {
                        query = query.Where(o => o.FullName.Contains(txt_box_full_name.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(txt_box_phone.Text))
                    {
                        query = query.Where(o => o.Phone.Contains(txt_box_phone.Text));
                    }
                    var tulemused = query
                        .Select(o => new
                        {
                            o.FullName,
                            o.Phone
                        })
                        .ToList();

                    omanik_data.DataSource = tulemused;
                }
            }
            else if (tab_control.SelectedTab == auto_page)
            {
                if (string.IsNullOrWhiteSpace(automark_text_box.Text) &&
                    string.IsNullOrEmpty(automudel_txt_box.Text) &&
                    string.IsNullOrEmpty(auto_reg_num_text_box.Text) &&
                    string.IsNullOrWhiteSpace(omanik_com_box.Text))
                {
                    MessageBox.Show("Sisesta mark või mudel või regnumber või omaniku nimi!");
                }
                else
                {
                    var query1 = _db.Cars.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(automark_text_box.Text))
                    {
                        query1 = query1.Where(c => c.Brand.Contains(automark_text_box.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(automudel_txt_box.Text))
                    {
                        query1 = query1.Where(c => c.Model.Contains(automudel_txt_box.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(auto_reg_num_text_box.Text))
                    {
                        query1 = query1.Where(c => c.RegistrationNumber.Contains(auto_reg_num_text_box.Text));
                    }
                    if (!string.IsNullOrWhiteSpace(omanik_com_box.Text))
                    {
                        string ownerName = omanik_com_box.Text.Trim();

                        query1 = query1.Where(c => c.Owner.FullName.Contains(ownerName));
                    }
                    var tulemused = query1
                       .Select(c => new
                       {
                           c.Id,
                           c.Brand,
                           c.Model,
                           c.RegistrationNumber,
                           Owner = c.Owner.FullName,
                           c.OwnerId
                       })
                       .ToList();

                    autod_data.DataSource = tulemused;
                }
            }
            else if (tab_control.SelectedTab == hool_teen_page)
            {
                if (string.IsNullOrWhiteSpace(auto_com_box.Text) &&
                    string.IsNullOrEmpty(teenus_com_box.Text) &&
                    string.IsNullOrEmpty(kuup_txt_box.Text) &&
                    string.IsNullOrWhiteSpace(aeg_txt_box.Text))
                {
                    MessageBox.Show("Sisesta kuupäev või läbisõit või teenuste või autoreg !");
                }
                else
                {
                    var query1 = _db.CarServices.AsQueryable();
                    if (!string.IsNullOrWhiteSpace(auto_com_box.Text))
                    {
                        string auto = auto_com_box.Text.Trim();

                        query1 = query1.Where(cs => cs.Car.RegistrationNumber.Contains(auto));
                    }
                    if (!string.IsNullOrWhiteSpace(teenus_com_box.Text))
                    {
                        string teenuste = teenus_com_box.Text.Trim();

                        query1 = query1.Where(cs => cs.Service.Name.Contains(teenuste));
                    }
                    if (!string.IsNullOrWhiteSpace(kuup_txt_box.Text))
                    {
                        if (DateTime.TryParse(kuup_txt_box.Text, out DateTime searchDate))
                        {
                            query1 = query1.Where(cs => cs.DateOfService == searchDate);
                        }
                        else
                        {
                            MessageBox.Show("Kuupäev on vales formaadis!");
                            return;
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(aeg_txt_box.Text))
                    {
                        if (int.TryParse(aeg_txt_box.Text, out int mileage))
                        {
                            query1 = query1.Where(cs => cs.Mileage == mileage);
                        }
                        else
                        {
                            MessageBox.Show("Läbisõit peab olema arv!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    var tulemused = query1
                       .Select(cs => new
                       {
                           car = cs.Car.RegistrationNumber,
                           cs.CarId,
                           teenus = cs.Service.Name,
                           cs.ServiceId,
                           cs.DateOfService,
                           cs.Mileage,
                       })
                       .ToList();

                    hooldus_data.DataSource = tulemused;
                }
            }
        }
        private void vaate_btn_Click(object sender, EventArgs e)
        {
            if (tab_control.SelectedTab == omanik_page)
            {
                LoeOmanik();
                puhasta();
            }
            else if (tab_control.SelectedTab == auto_page)
            {
                LoeCar();
                puhasta();
            }
            else if (tab_control.SelectedTab == hool_teen_page)
            {
                LoeCarServices();
                puhasta();
            }
        }
        private void puhasta()
        {
            if (tab_control.SelectedTab == omanik_page)
            {
                txt_box_full_name.Clear();
                txt_box_phone.Clear();
            }
            else if (tab_control.SelectedTab == auto_page)
            {
                automark_text_box.Clear();
                automudel_txt_box.Clear();
                auto_reg_num_text_box.Clear();
                omanik_com_box.Text = "";
                omanik_com_box.SelectedIndex = -1;
            }
            else if (tab_control.SelectedTab == hool_teen_page)
            {
                auto_com_box.Text = "";
                auto_com_box.SelectedIndex = -1;
                teenus_com_box.Text = "";
                teenus_com_box.SelectedIndex = -1;
                kuup_txt_box.Value = DateTime.Now;
                aeg_txt_box.Clear();
            }
        }
        private void kust__btn_Click(object sender, EventArgs e)
        {
            if (tab_control.SelectedTab == omanik_page)
            {
                if (omanik_data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige kustutatav omanik.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string omanik = omanik_data.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "valitud omanik";
                DialogResult vastus = MessageBox.Show(
                    $"Kas olete kindel, et soovite kustutada: {omanik}?",
                    "Kustutamise kinnitus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    try
                    {
                        int id = (int)omanik_data.SelectedRows[0].Cells["Id"].Value;
                        var omanik1 = _db.Owners.Find(id);

                        if (omanik1 != null)
                        {
                            _db.Owners.Remove(omanik1);
                            _db.SaveChanges();
                            LoeOmanik();
                            puhasta();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (tab_control.SelectedTab == auto_page)
            {
                if (autod_data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige kustutatav auto.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string car = autod_data.SelectedRows[0].Cells["Brand"].Value?.ToString() ?? "valitud auto";
                DialogResult vastus = MessageBox.Show(
                    $"Kas olete kindel, et soovite kustutada: {car}?",
                    "Kustutamise kinnitus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    try
                    {
                        int id = (int)autod_data.SelectedRows[0].Cells["Id"].Value;
                        var car1 = _db.Cars.Find(id);

                        if (car1 != null)
                        {
                            _db.Cars.Remove(car1);
                            _db.SaveChanges();
                            LoeCar();
                            puhasta();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (tab_control.SelectedTab == hool_teen_page)
            {
                if (hooldus_data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige kustutatav hooldus.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string hool = hooldus_data.SelectedRows[0].Cells["CarId"].Value?.ToString() ?? "valitud auto";
                DialogResult vastus = MessageBox.Show(
                    $"Kas olete kindel, et soovite kustutada: {hool}?",
                    "Kustutamise kinnitus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    try
                    {
                        int oldCarId = (int)hooldus_data.SelectedRows[0].Cells["CarId"].Value;
                        int oldServiceId = (int)hooldus_data.SelectedRows[0].Cells["ServiceId"].Value;
                        DateTime oldDate = (DateTime)hooldus_data.SelectedRows[0].Cells["DateOfService"].Value;
                        var oldEntry = _db.CarServices.Find(oldCarId, oldServiceId, oldDate);
                        if (oldEntry != null)
                        {
                            _db.CarServices.Remove(oldEntry);
                            _db.SaveChanges();
                            LoeCarServices();
                            puhasta();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            if (tab_control.SelectedTab == omanik_page)
            {
                if (omanik_data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige kustutatav omanik.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int id = (int)omanik_data.SelectedRows[0].Cells["Id"].Value;
                var owner = _db.Owners.Find(id);

                owner.FullName = txt_box_full_name.Text;
                owner.Phone = txt_box_phone.Text;
                _db.SaveChanges();
                LoeOmanik();
                puhasta();
            }
            else if (tab_control.SelectedTab == auto_page)
            {
                if (autod_data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige auto!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)autod_data.SelectedRows[0].Cells["Id"].Value;
                var car = _db.Cars.Find(id);
                car.Brand = automark_text_box.Text;
                car.Model = automudel_txt_box.Text;
                car.RegistrationNumber = auto_reg_num_text_box.Text;

                if (omanik_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige omanik!");
                    return;
                }

                car.OwnerId = (int)omanik_com_box.SelectedValue;

                _db.SaveChanges();
                LoeCar();
                puhasta();
            }
            else if (tab_control.SelectedTab == hool_teen_page)
            {
                if (hooldus_data.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Palun valige auto!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int oldCarId = (int)hooldus_data.SelectedRows[0].Cells["CarId"].Value;
                int oldServiceId = (int)hooldus_data.SelectedRows[0].Cells["ServiceId"].Value;
                DateTime oldDate = (DateTime)hooldus_data.SelectedRows[0].Cells["DateOfService"].Value;
                var oldEntry = _db.CarServices.Find(oldCarId, oldServiceId, oldDate);
                if (oldEntry == null)
                {
                    MessageBox.Show("Kirjet ei leitud!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (auto_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige auto!");
                    return;
                }
                if (teenus_com_box.SelectedValue == null)
                {
                    MessageBox.Show("Valige teenus!");
                    return;
                }
                if (!DateTime.TryParse(kuup_txt_box.Text, out DateTime newDate))
                {
                    MessageBox.Show("Kuupäev on vales formaadis!");
                    return;
                }
                if (!int.TryParse(aeg_txt_box.Text, out int newMileage))
                {
                    MessageBox.Show("Läbisõit peab olema arv!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _db.CarServices.Remove(oldEntry);
                _db.SaveChanges();
                var newEntry = new CarService
                {
                    CarId = (int)auto_com_box.SelectedValue,
                    ServiceId = (int)teenus_com_box.SelectedValue,
                    DateOfService = newDate,
                    Mileage = newMileage
                };
                _db.CarServices.Add(newEntry);
                _db.SaveChanges();
                LoeCarServices();
                puhasta();
            }
        }
        private void lisa_teenuste_btn_Click(object sender, EventArgs e)
        {
            Teenuste hooldus_form = new Teenuste();
            hooldus_form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void hooldus_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = hooldus_data.Rows[e.RowIndex];
                if (row.Cells["CarId"].Value != null)
                {
                    auto_com_box.SelectedValue = Convert.ToInt32(row.Cells["CarId"].Value);
                }
                else
                {
                    auto_com_box.SelectedIndex = -1;
                }
                if (row.Cells["ServiceId"].Value != null)
                {
                    teenus_com_box.SelectedValue = Convert.ToInt32(row.Cells["ServiceId"].Value);
                }
                else
                {
                    teenus_com_box.SelectedIndex = -1;
                }
                if (row.Cells["DateOfService"].Value != null)
                {
                    kuup_txt_box.Value = Convert.ToDateTime(row.Cells["DateOfService"].Value);
                }
                else
                {
                    kuup_txt_box.Value = DateTime.Now;
                }
                aeg_txt_box.Text = row.Cells["Mileage"].Value?.ToString() ?? "";
            }
        }
        private void autod_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = autod_data.Rows[e.RowIndex];


                automark_text_box.Text = row.Cells["Brand"].Value?.ToString() ?? "";
                automudel_txt_box.Text = row.Cells["Model"].Value?.ToString() ?? "";
                auto_reg_num_text_box.Text = row.Cells["RegistrationNumber"].Value?.ToString() ?? "";
                if (row.Cells["OwnerId"].Value != null)
                {
                    omanik_com_box.SelectedValue = Convert.ToInt32(row.Cells["OwnerId"].Value);
                }
                else
                {
                    omanik_com_box.SelectedIndex = -1;
                }
                if (int.TryParse(row.Cells["Id"]?.Value?.ToString(), out int id))
                {
                    auto_com_box.SelectedValue = id;
                }
                else
                {
                    auto_com_box.SelectedIndex = -1;
                }
            }

        }
        private void omanik_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = omanik_data.Rows[e.RowIndex];
                txt_box_full_name.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                if (row.Cells["Phone"] != null)
                    txt_box_phone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                else
                    txt_box_phone.Text = "";
            }
        }
        private void otsi_tel_txt_box_TextChanged(object sender, EventArgs e)
        {
            var query = _db.Owners.AsQueryable();
            if (!string.IsNullOrWhiteSpace(otsi_tel_txt_box.Text))
            {
                query = query.Where(o => o.Phone.Contains(otsi_tel_txt_box.Text));
            }
            omanik_data.DataSource = query
                .Select(o => new
                {
                    o.Id,
                    o.FullName,
                    o.Phone
                })
                .ToList();
            omanik_data.Columns["Id"].Visible = false;
        }
        private void tab_control_Click(object sender, EventArgs e)
        {
            LoeOmanik();
            LoeCarServices();
            LoeCar();
            LaeCars();
            LaeOmanik();
            LaeTeenused();
        }
        private void otsi_regnum_txt_box_TextChanged(object sender, EventArgs e)
        {
            var q = _db.Cars.Include(c => c.Owner).AsQueryable();

            if (!string.IsNullOrWhiteSpace(otsi_regnum_txt_box.Text))
                q = q.Where(c => c.RegistrationNumber.Contains(otsi_regnum_txt_box.Text));

            autod_data.DataSource = q
                .Select(c => new
                {
                    c.Id,
                    c.Brand,
                    c.Model,
                    c.RegistrationNumber,
                    Owner = c.Owner.FullName,
                    c.OwnerId
                })
                .ToList();

            autod_data.Columns["Id"].Visible = false;
            autod_data.Columns["OwnerId"].Visible = false;
        }
        private void otsi_reg_txt_box_TextChanged(object sender, EventArgs e)
        {
            var q = _db.CarServices
                .Include(c => c.Car)
                .Include(c => c.Service)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(otsi_reg_txt_box.Text))
                q = q.Where(cs => cs.Car.RegistrationNumber.Contains(otsi_reg_txt_box.Text));
            hooldus_data.DataSource = q
                .Select(c => new
                {
                    Car = c.Car.RegistrationNumber,
                    c.CarId,
                    Service = c.Service.Name,
                    c.ServiceId,
                    c.DateOfService,
                    c.Mileage,
                })
                .ToList();
        }
    }
}
