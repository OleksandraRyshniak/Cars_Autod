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

namespace Cars
{
    public partial class mehaanik : Form
    {
        private CarsContext _db;
        public mehaanik()
        {
            InitializeComponent();
            _db = new CarsContext();
            Loemeh();
            using (var db = new CarsContext())
            {
                db.Database.EnsureCreated();
            }
        }
        private void Loemeh()
        {
            meh_data.DataSource = _db.Mechanics.Select(o => new
            {
                o.Id,
                o.FullName,
                o.Phone
            }).ToList();
            if (meh_data.Columns["Id"] != null)
                meh_data.Columns["Id"].Visible = false;
        }
        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            if (meh_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kustutatav mehaanik.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (int)meh_data.SelectedRows[0].Cells["Id"].Value;
            var meh = _db.Mechanics.Find(id);

            meh.FullName = nimi_txt.Text;
            meh.Phone = phone_txt.Text;
            _db.SaveChanges();
            Loemeh();
            puhasta();
        }
        private void lisa_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nimi_txt.Text) || string.IsNullOrWhiteSpace(phone_txt.Text))
            {
                MessageBox.Show("Täisnimi ja Telefon on kohustuslik!");
                return;
            }
            var phone = _db.Mechanics.Any(o => o.Phone == phone_txt.Text);
            if (phone)
            {
                MessageBox.Show("See telefon on juba olemas.");
                return;
            }
            var uus = new Mechanic
            {
                FullName = nimi_txt.Text,
                Phone = phone_txt.Text,
            };
            _db.Mechanics.Add(uus);
            _db.SaveChanges();
            Loemeh();
            puhasta();
        }
        private void puhasta()
        {
            nimi_txt.Clear();
            phone_txt.Clear();
        }
        private void kust_btn_Click(object sender, EventArgs e)
        {
            if (meh_data.SelectedRows.Count == 0)
            {
                MessageBox.Show("Palun valige kustutatav mehaanik.", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string meh = meh_data.SelectedRows[0].Cells["FullName"].Value?.ToString() ?? "valitud teenuste";
            DialogResult vastus = MessageBox.Show(
                $"Kas olete kindel, et soovite kustutada: {meh} ?",
                "Kustutamise kinnitus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (vastus == DialogResult.Yes)
            {
                try
                {
                    int id = (int)meh_data.SelectedRows[0].Cells["Id"].Value;
                    var meh1 = _db.Mechanics.Find(id);

                    if (meh1 != null)
                    {
                        _db.Mechanics.Remove(meh1);
                        _db.SaveChanges();
                        Loemeh();
                        puhasta();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kustutamisel tekkis viga: {ex.Message}", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void koik_btn_Click(object sender, EventArgs e)
        {
            Loemeh();
            puhasta();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = _db.Mechanics.AsQueryable();

            if (!string.IsNullOrWhiteSpace(otsi_txt.Text))
            {
                query = query.Where(o => o.FullName.Contains(otsi_txt.Text));
            }

            meh_data.DataSource = query
                .Select(o => new
                {
                    o.Id,
                    o.FullName,
                    o.Phone
                })
                .ToList();

            meh_data.Columns["Id"].Visible = false;
        }
        private void meh_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = meh_data.Rows[e.RowIndex];

                nimi_txt.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                phone_txt.Text = row.Cells["Phone"].Value?.ToString() ?? "";

            }
        }

        private void ApplyResourcesToControl(Control ctrl, ComponentResourceManager res)
        {
            res.ApplyResources(ctrl, ctrl.Name);
            foreach (Control child in ctrl.Controls)
            {
                ApplyResourcesToControl(child, res);
            }
        }

        private void mehaanik_Load(object sender, EventArgs e)
        {

        }
    }
}
