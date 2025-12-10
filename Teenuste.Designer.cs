namespace Cars
{
    partial class Teenuste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nimi_txt_box = new TextBox();
            nimi_lbl = new Label();
            hind_txt_box = new TextBox();
            hind_lbl = new Label();
            hooldus_kir_lbl = new Label();
            lisa_btn = new Button();
            teenuste_data = new DataGridView();
            kustuta_btn = new Button();
            uuenda_btn = new Button();
            keel_com_box = new ComboBox();
            otsi_teen__lbl = new Label();
            otsi_teen_txt_box = new TextBox();
            pageSetupDialog1 = new PageSetupDialog();
            koik_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)teenuste_data).BeginInit();
            SuspendLayout();
            // 
            // nimi_txt_box
            // 
            nimi_txt_box.Location = new Point(53, 41);
            nimi_txt_box.Name = "nimi_txt_box";
            nimi_txt_box.Size = new Size(150, 23);
            nimi_txt_box.TabIndex = 24;
            nimi_txt_box.TextChanged += nimi_txt_box_TextChanged;
            // 
            // nimi_lbl
            // 
            nimi_lbl.AutoSize = true;
            nimi_lbl.Location = new Point(12, 44);
            nimi_lbl.Name = "nimi_lbl";
            nimi_lbl.Size = new Size(33, 15);
            nimi_lbl.TabIndex = 23;
            nimi_lbl.Text = "Nimi";
            // 
            // hind_txt_box
            // 
            hind_txt_box.Location = new Point(53, 81);
            hind_txt_box.Name = "hind_txt_box";
            hind_txt_box.Size = new Size(150, 23);
            hind_txt_box.TabIndex = 22;
            hind_txt_box.TextChanged += hind_txt_box_TextChanged;
            // 
            // hind_lbl
            // 
            hind_lbl.AutoSize = true;
            hind_lbl.Location = new Point(12, 84);
            hind_lbl.Name = "hind_lbl";
            hind_lbl.Size = new Size(33, 15);
            hind_lbl.TabIndex = 17;
            hind_lbl.Text = "Hind";
            // 
            // hooldus_kir_lbl
            // 
            hooldus_kir_lbl.AutoSize = true;
            hooldus_kir_lbl.Location = new Point(136, 7);
            hooldus_kir_lbl.Name = "hooldus_kir_lbl";
            hooldus_kir_lbl.Size = new Size(54, 15);
            hooldus_kir_lbl.TabIndex = 25;
            hooldus_kir_lbl.Text = "Teenuste";
            // 
            // lisa_btn
            // 
            lisa_btn.Location = new Point(223, 39);
            lisa_btn.Name = "lisa_btn";
            lisa_btn.Size = new Size(67, 24);
            lisa_btn.TabIndex = 26;
            lisa_btn.Text = "Lisa";
            lisa_btn.UseVisualStyleBackColor = true;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // teenuste_data
            // 
            teenuste_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teenuste_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teenuste_data.Location = new Point(4, 164);
            teenuste_data.Margin = new Padding(3, 2, 3, 2);
            teenuste_data.Name = "teenuste_data";
            teenuste_data.RowHeadersWidth = 51;
            teenuste_data.Size = new Size(359, 281);
            teenuste_data.TabIndex = 27;
            // 
            // kustuta_btn
            // 
            kustuta_btn.Location = new Point(296, 39);
            kustuta_btn.Name = "kustuta_btn";
            kustuta_btn.Size = new Size(67, 24);
            kustuta_btn.TabIndex = 28;
            kustuta_btn.Text = "Kustuta";
            kustuta_btn.UseVisualStyleBackColor = true;
            kustuta_btn.Click += kustuta_btn_Click;
            // 
            // uuenda_btn
            // 
            uuenda_btn.Location = new Point(270, 69);
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.Size = new Size(67, 24);
            uuenda_btn.TabIndex = 29;
            uuenda_btn.Text = "Uuenda";
            uuenda_btn.UseVisualStyleBackColor = true;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // keel_com_box
            // 
            keel_com_box.FormattingEnabled = true;
            keel_com_box.Location = new Point(270, 4);
            keel_com_box.Margin = new Padding(3, 2, 3, 2);
            keel_com_box.Name = "keel_com_box";
            keel_com_box.Size = new Size(103, 23);
            keel_com_box.TabIndex = 31;
            // 
            // otsi_teen__lbl
            // 
            otsi_teen__lbl.AutoSize = true;
            otsi_teen__lbl.Location = new Point(12, 123);
            otsi_teen__lbl.Name = "otsi_teen__lbl";
            otsi_teen__lbl.Size = new Size(97, 15);
            otsi_teen__lbl.TabIndex = 33;
            otsi_teen__lbl.Text = "Otsida nime järgi";
            // 
            // otsi_teen_txt_box
            // 
            otsi_teen_txt_box.Location = new Point(124, 120);
            otsi_teen_txt_box.Name = "otsi_teen_txt_box";
            otsi_teen_txt_box.Size = new Size(150, 23);
            otsi_teen_txt_box.TabIndex = 34;
            otsi_teen_txt_box.TextChanged += otsi_teen_txt_box_TextChanged;
            // 
            // koik_btn
            // 
            koik_btn.Location = new Point(280, 120);
            koik_btn.Name = "koik_btn";
            koik_btn.Size = new Size(83, 23);
            koik_btn.TabIndex = 35;
            koik_btn.Text = "Vaata kõik";
            koik_btn.UseVisualStyleBackColor = true;
            koik_btn.Click += koik_btn_Click;
            // 
            // Teenuste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(koik_btn);
            Controls.Add(otsi_teen_txt_box);
            Controls.Add(otsi_teen__lbl);
            Controls.Add(keel_com_box);
            Controls.Add(uuenda_btn);
            Controls.Add(kustuta_btn);
            Controls.Add(teenuste_data);
            Controls.Add(lisa_btn);
            Controls.Add(hooldus_kir_lbl);
            Controls.Add(nimi_txt_box);
            Controls.Add(nimi_lbl);
            Controls.Add(hind_txt_box);
            Controls.Add(hind_lbl);
            Name = "Teenuste";
            Text = "Lisa_hoolduse_kirjed";
            ((System.ComponentModel.ISupportInitialize)teenuste_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nimi_txt_box;
        private Label nimi_lbl;
        private TextBox hind_txt_box;
        private Label hind_lbl;
        private Label hooldus_kir_lbl;
        private Button lisa_btn;
        private DataGridView teenuste_data;
        private Button kustuta_btn;
        private Button uuenda_btn;
        private ComboBox keel_com_box;
        private Label otsi_teen__lbl;
        private TextBox otsi_teen_txt_box;
        private PageSetupDialog pageSetupDialog1;
        private Button koik_btn;
    }
}