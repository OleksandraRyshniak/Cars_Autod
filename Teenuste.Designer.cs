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
            vaate_btn = new Button();
            keel_com_box = new ComboBox();
            otsi_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)teenuste_data).BeginInit();
            SuspendLayout();
            // 
            // nimi_txt_box
            // 
            nimi_txt_box.Location = new Point(109, 59);
            nimi_txt_box.Margin = new Padding(3, 4, 3, 4);
            nimi_txt_box.Name = "nimi_txt_box";
            nimi_txt_box.Size = new Size(171, 27);
            nimi_txt_box.TabIndex = 24;
            nimi_txt_box.TextChanged += nimi_txt_box_TextChanged;
            // 
            // nimi_lbl
            // 
            nimi_lbl.AutoSize = true;
            nimi_lbl.Location = new Point(31, 59);
            nimi_lbl.Name = "nimi_lbl";
            nimi_lbl.Size = new Size(41, 20);
            nimi_lbl.TabIndex = 23;
            nimi_lbl.Text = "Nimi";
            // 
            // hind_txt_box
            // 
            hind_txt_box.Location = new Point(109, 112);
            hind_txt_box.Margin = new Padding(3, 4, 3, 4);
            hind_txt_box.Name = "hind_txt_box";
            hind_txt_box.Size = new Size(171, 27);
            hind_txt_box.TabIndex = 22;
            hind_txt_box.TextChanged += hind_txt_box_TextChanged;
            // 
            // hind_lbl
            // 
            hind_lbl.AutoSize = true;
            hind_lbl.Location = new Point(31, 115);
            hind_lbl.Name = "hind_lbl";
            hind_lbl.Size = new Size(41, 20);
            hind_lbl.TabIndex = 17;
            hind_lbl.Text = "Hind";
            // 
            // hooldus_kir_lbl
            // 
            hooldus_kir_lbl.AutoSize = true;
            hooldus_kir_lbl.Location = new Point(156, 9);
            hooldus_kir_lbl.Name = "hooldus_kir_lbl";
            hooldus_kir_lbl.Size = new Size(67, 20);
            hooldus_kir_lbl.TabIndex = 25;
            hooldus_kir_lbl.Text = "Teenuste";
            // 
            // lisa_btn
            // 
            lisa_btn.Location = new Point(12, 171);
            lisa_btn.Margin = new Padding(3, 4, 3, 4);
            lisa_btn.Name = "lisa_btn";
            lisa_btn.Size = new Size(77, 32);
            lisa_btn.TabIndex = 26;
            lisa_btn.Text = "Lisa";
            lisa_btn.UseVisualStyleBackColor = true;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // teenuste_data
            // 
            teenuste_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teenuste_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teenuste_data.Location = new Point(4, 250);
            teenuste_data.Name = "teenuste_data";
            teenuste_data.RowHeadersWidth = 51;
            teenuste_data.Size = new Size(375, 343);
            teenuste_data.TabIndex = 27;
            // 
            // kustuta_btn
            // 
            kustuta_btn.Location = new Point(109, 171);
            kustuta_btn.Margin = new Padding(3, 4, 3, 4);
            kustuta_btn.Name = "kustuta_btn";
            kustuta_btn.Size = new Size(77, 32);
            kustuta_btn.TabIndex = 28;
            kustuta_btn.Text = "Kustuta";
            kustuta_btn.UseVisualStyleBackColor = true;
            kustuta_btn.Click += kustuta_btn_Click;
            // 
            // uuenda_btn
            // 
            uuenda_btn.Location = new Point(203, 171);
            uuenda_btn.Margin = new Padding(3, 4, 3, 4);
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.Size = new Size(77, 32);
            uuenda_btn.TabIndex = 29;
            uuenda_btn.Text = "Uuenda";
            uuenda_btn.UseVisualStyleBackColor = true;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // vaate_btn
            // 
            vaate_btn.Location = new Point(297, 171);
            vaate_btn.Margin = new Padding(3, 4, 3, 4);
            vaate_btn.Name = "vaate_btn";
            vaate_btn.Size = new Size(77, 32);
            vaate_btn.TabIndex = 30;
            vaate_btn.Text = "Vaate";
            vaate_btn.UseVisualStyleBackColor = true;
            vaate_btn.Click += vaate_btn_Click;
            // 
            // keel_com_box
            // 
            keel_com_box.FormattingEnabled = true;
            keel_com_box.Location = new Point(277, 1);
            keel_com_box.Name = "keel_com_box";
            keel_com_box.Size = new Size(108, 28);
            keel_com_box.TabIndex = 31;
            // 
            // otsi_btn
            // 
            otsi_btn.Location = new Point(156, 211);
            otsi_btn.Margin = new Padding(3, 4, 3, 4);
            otsi_btn.Name = "otsi_btn";
            otsi_btn.Size = new Size(77, 32);
            otsi_btn.TabIndex = 32;
            otsi_btn.Text = "Otsi";
            otsi_btn.UseVisualStyleBackColor = true;
            otsi_btn.Click += otsi_btn_Click;
            // 
            // Teenuste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 600);
            Controls.Add(otsi_btn);
            Controls.Add(keel_com_box);
            Controls.Add(vaate_btn);
            Controls.Add(uuenda_btn);
            Controls.Add(kustuta_btn);
            Controls.Add(teenuste_data);
            Controls.Add(lisa_btn);
            Controls.Add(hooldus_kir_lbl);
            Controls.Add(nimi_txt_box);
            Controls.Add(nimi_lbl);
            Controls.Add(hind_txt_box);
            Controls.Add(hind_lbl);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button vaate_btn;
        private ComboBox keel_com_box;
        private Button otsi_btn;
    }
}