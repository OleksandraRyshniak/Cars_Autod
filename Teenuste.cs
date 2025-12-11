using Cars.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Cars
{
    public partial class Teenuste : Form
    {
        private CarsContext _db;
        public Teenuste()
        {
            InitializeComponent();
            _db = new CarsContext();
            LoeServices();
            using (var db = new CarsContext())
            {
                db.Database.EnsureCreated();
            }
        }
        private void LoeServices()
        {
            teenuste_data.DataSource = _db.Services.Select(o => new
            {
                o.Id,
                o.Name,
                o.Price
            }).ToList();
            if (teenuste_data.Columns["Id"] != null)
                teenuste_data.Columns["Id"].Visible = false;
        }
        private void lisa_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nimi_txt_box.Text) || string.IsNullOrWhiteSpace(hind_txt_box.Text))
            {
                MessageBox.Show("Nimi ja Hind on kohustuslik!");
                return;
            }
            var teen = _db.Services.Any(o => o.Name == nimi_txt_box.Text);
            if (teen)
            {
                MessageBox.Show("See teenus on juba olemas.");
                return;
            }
            if (!float.TryParse(hind_txt_box.Text, out float price))
            {
                MessageBox.Show("Hind peab olema arv!");
                return;
            }
            var uus = new Service
            {
                Name = nimi_txt_box.Text,
                Price = price,
            };
            _db.Services.Add(uus);
            _db.SaveChanges();
            LoeServices();
            puhasta();
        }
        private void puhasta()
        {
            nimi_txt_box.Clear();
            hind_txt_box.Clear();
        }
        private void kustuta_btn_Click(object sender, EventArgs e)
        {
            if (teenuste_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kustutatav omanik.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string teenuste = teenuste_data.SelectedRows[0].Cells["Name"].Value?.ToString() ?? "valitud teenuste";
            DialogResult vastus = MessageBox.Show(
                $"Kas olete kindel, et soovite kustutada: {teenuste}?",
                "Kustutamise kinnitus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (vastus == DialogResult.Yes)
            {
                try
                {
                    int id = (int)teenuste_data.SelectedRows[0].Cells["Id"].Value;
                    var teenuste1 = _db.Services.Find(id);

                    if (teenuste1 != null)
                    {
                        _db.Services.Remove(teenuste1);
                        _db.SaveChanges();
                        LoeServices();
                        puhasta();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            if (teenuste_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kustutatav teenuste.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (int)teenuste_data.SelectedRows[0].Cells["Id"].Value;
            var teenuste = _db.Services.Find(id);

            teenuste.Name = nimi_txt_box.Text;
            if (!float.TryParse(hind_txt_box.Text, out float price))
            {
                MessageBox.Show("Hind peab olema arv!");
                return;
            }
            teenuste.Price = price;
            _db.SaveChanges();
            LoeServices();
        }
        private void vaate_btn_Click(object sender, EventArgs e)
        {
            LoeServices();
            puhasta();
        }

        private void otsi_teen_txt_box_TextChanged(object sender, EventArgs e)
        {
            var query = _db.Services.AsQueryable();

            if (!string.IsNullOrWhiteSpace(otsi_teen_txt_box.Text))
            {
                query = query.Where(o => o.Name.Contains(otsi_teen_txt_box.Text));
            }

            teenuste_data.DataSource = query
                .Select(o => new
                {
                    o.Id,
                    o.Name,
                    o.Price
                })
                .ToList();

            teenuste_data.Columns["Id"].Visible = false;
        }

        private void koik_btn_Click(object sender, EventArgs e)
        {
            LoeServices();
        }

        private void teenuste_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = teenuste_data.Rows[e.RowIndex];

                nimi_txt_box.Text = row.Cells["Name"].Value?.ToString() ?? "";
                hind_txt_box.Text = row.Cells["Price"].Value?.ToString() ?? "";

            }
        }
    }
}
