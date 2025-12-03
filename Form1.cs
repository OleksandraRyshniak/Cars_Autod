using Cars.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using System.Xml.Linq;

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
            //LoeServices();
            //LoeCarServices();
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
            omanik_com_box.DataSource = _db.Owners.ToList();
            omanik_com_box.DisplayMember = "FullName";
            omanik_com_box.ValueMember = "Id";
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
                if (string.IsNullOrWhiteSpace(automark_text_box.Text))
                {
                    MessageBox.Show("Brand on kohustuslik!");
                    return;
                }
                var uus1 = new Car
                {
                    Brand = automark_text_box.Text,
                    Model = automudel_txt_box.Text,
                    RegistrationNumber = auto_reg_num_text_box.Text,
                    OwnerId = (int)omanik_com_box.SelectedValue,
                };
                _db.Cars.Add(uus1);
                _db.SaveChanges();
                LoeCars();
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
                            o.Id,
                            o.FullName,
                            o.Phone
                        })
                        .ToList();

                    omanik_data.DataSource = tulemused;
                }
            }
        }
        private void vaate_btn_Click(object sender, EventArgs e)
        {
            if (tab_control.SelectedTab == omanik_page)
            {
                LoeOmanik();
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
            }
        }
        private void lisa_hool_btn_Click(object sender, EventArgs e)
        {
            Lisa_hoolduse_kirjed hooldus_form = new Lisa_hoolduse_kirjed();
            hooldus_form.Show();
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
                string omanik = omanik_data.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "valitud toode";
                DialogResult vastus = MessageBox.Show(
                    $"Kas olete kindel, et soovite kustutada toote: {omanik}?",
                    "Kustutamise kinnitus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    try
                    {
                        int id = (int)omanik_data.SelectedRows[0].Cells["Id"].Value;
                        var toode = _db.Owners.Find(id);

                        if (toode != null)
                        {
                            _db.Owners.Remove(toode);
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
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
