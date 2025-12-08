using Cars.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
            LoeCars();
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
        }
        private void LoeCars()
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

                var uus1 = new Car
                {
                    Brand = automark_text_box.Text,
                    Model = automudel_txt_box.Text,
                    RegistrationNumber = auto_reg_num_text_box.Text,
                    OwnerId = (int)omanik_com_box.SelectedValue
                };

                _db.Cars.Add(uus1);
                _db.SaveChanges();
                LoeCars();
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
                if (!DateTime.TryParse(kuup_txt_box.Text, out DateTime kuup) || !int.TryParse(aeg_txt_box.Text, out int aeg))
                {
                    MessageBox.Show("Kuupäev või läbisõit on valesformaadis!");
                    return;
                }
                var uus2 = new CarService
                {
                    CarId = (int)auto_com_box.SelectedValue,
                    ServiceId = (int)teenus_com_box.SelectedValue,
                    DateOfService = kuup,
                    Mileage = aeg
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
        }
        private void vaate_btn_Click(object sender, EventArgs e)
        {
            if (tab_control.SelectedTab == omanik_page)
            {
                LoeOmanik();
            }
            else if (tab_control.SelectedTab == auto_page)
            {
                LoeCars();
            }
            else if (tab_control.SelectedTab == hool_teen_page)
            {
                LoeCarServices();
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
                kuup_txt_box.Clear();
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
                            LoeCars();
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
                LoeCars();
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
    }
}
