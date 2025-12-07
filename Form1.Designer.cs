namespace Cars
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tab_control = new TabControl();
            omanik_page = new TabPage();
            txt_box_phone = new TextBox();
            phone_lbl = new Label();
            label1 = new Label();
            omanik_data = new DataGridView();
            txt_box_full_name = new TextBox();
            lbl_full_name = new Label();
            auto_page = new TabPage();
            auto_reg_num_text_box = new TextBox();
            automudel_txt_box = new TextBox();
            automark_text_box = new TextBox();
            omanik_lbl = new Label();
            auto_reg_num_lbl = new Label();
            automudel_lbl = new Label();
            omanik_com_box = new ComboBox();
            automark_lbl = new Label();
            autod_data = new DataGridView();
            hool_teen_page = new TabPage();
            button1 = new Button();
            textBox3 = new TextBox();
            auto_lbl = new Label();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            mileeg_lbl = new Label();
            label3 = new Label();
            teenus_lbl = new Label();
            hooldus_kir_lbl = new Label();
            hooldus_data = new DataGridView();
            nimi_otsi_btn = new Button();
            lisa_btn = new Button();
            kust__btn = new Button();
            uuenda_btn = new Button();
            vaate_btn = new Button();
            keel_com_box = new ComboBox();
            tab_control.SuspendLayout();
            omanik_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)omanik_data).BeginInit();
            auto_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)autod_data).BeginInit();
            hool_teen_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hooldus_data).BeginInit();
            SuspendLayout();
            // 
            // tab_control
            // 
            tab_control.Controls.Add(omanik_page);
            tab_control.Controls.Add(auto_page);
            tab_control.Controls.Add(hool_teen_page);
            tab_control.Location = new Point(14, 16);
            tab_control.Margin = new Padding(3, 4, 3, 4);
            tab_control.Name = "tab_control";
            tab_control.SelectedIndex = 0;
            tab_control.Size = new Size(755, 587);
            tab_control.TabIndex = 0;
            // 
            // omanik_page
            // 
            omanik_page.Controls.Add(txt_box_phone);
            omanik_page.Controls.Add(phone_lbl);
            omanik_page.Controls.Add(label1);
            omanik_page.Controls.Add(omanik_data);
            omanik_page.Controls.Add(txt_box_full_name);
            omanik_page.Controls.Add(lbl_full_name);
            omanik_page.Location = new Point(4, 29);
            omanik_page.Margin = new Padding(3, 4, 3, 4);
            omanik_page.Name = "omanik_page";
            omanik_page.Padding = new Padding(3, 4, 3, 4);
            omanik_page.Size = new Size(747, 554);
            omanik_page.TabIndex = 0;
            omanik_page.Text = "Omanikud";
            omanik_page.UseVisualStyleBackColor = true;
            // 
            // txt_box_phone
            // 
            txt_box_phone.Location = new Point(542, 227);
            txt_box_phone.Margin = new Padding(3, 4, 3, 4);
            txt_box_phone.Name = "txt_box_phone";
            txt_box_phone.Size = new Size(159, 27);
            txt_box_phone.TabIndex = 6;
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.BackColor = Color.White;
            phone_lbl.Location = new Point(545, 180);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(113, 20);
            phone_lbl.TabIndex = 7;
            phone_lbl.Text = "Telefoninumber";
            phone_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(567, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // omanik_data
            // 
            omanik_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            omanik_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            omanik_data.Location = new Point(14, 23);
            omanik_data.Margin = new Padding(3, 4, 3, 4);
            omanik_data.Name = "omanik_data";
            omanik_data.RowHeadersWidth = 51;
            omanik_data.Size = new Size(501, 501);
            omanik_data.TabIndex = 0;
            // 
            // txt_box_full_name
            // 
            txt_box_full_name.Location = new Point(545, 83);
            txt_box_full_name.Margin = new Padding(3, 4, 3, 4);
            txt_box_full_name.Name = "txt_box_full_name";
            txt_box_full_name.Size = new Size(159, 27);
            txt_box_full_name.TabIndex = 4;
            // 
            // lbl_full_name
            // 
            lbl_full_name.AutoSize = true;
            lbl_full_name.BackColor = Color.White;
            lbl_full_name.Location = new Point(545, 36);
            lbl_full_name.Name = "lbl_full_name";
            lbl_full_name.Size = new Size(156, 20);
            lbl_full_name.TabIndex = 3;
            lbl_full_name.Text = "Ees- ja perekonnanimi";
            lbl_full_name.TextAlign = ContentAlignment.TopCenter;
            // 
            // auto_page
            // 
            auto_page.Controls.Add(auto_reg_num_text_box);
            auto_page.Controls.Add(automudel_txt_box);
            auto_page.Controls.Add(automark_text_box);
            auto_page.Controls.Add(omanik_lbl);
            auto_page.Controls.Add(auto_reg_num_lbl);
            auto_page.Controls.Add(automudel_lbl);
            auto_page.Controls.Add(omanik_com_box);
            auto_page.Controls.Add(automark_lbl);
            auto_page.Controls.Add(autod_data);
            auto_page.Location = new Point(4, 29);
            auto_page.Margin = new Padding(3, 4, 3, 4);
            auto_page.Name = "auto_page";
            auto_page.Padding = new Padding(3, 4, 3, 4);
            auto_page.Size = new Size(747, 554);
            auto_page.TabIndex = 1;
            auto_page.Text = "Autod";
            auto_page.UseVisualStyleBackColor = true;
            // 
            // auto_reg_num_text_box
            // 
            auto_reg_num_text_box.Location = new Point(593, 247);
            auto_reg_num_text_box.Margin = new Padding(3, 4, 3, 4);
            auto_reg_num_text_box.Name = "auto_reg_num_text_box";
            auto_reg_num_text_box.Size = new Size(133, 27);
            auto_reg_num_text_box.TabIndex = 9;
            // 
            // automudel_txt_box
            // 
            automudel_txt_box.Location = new Point(593, 195);
            automudel_txt_box.Margin = new Padding(3, 4, 3, 4);
            automudel_txt_box.Name = "automudel_txt_box";
            automudel_txt_box.Size = new Size(133, 27);
            automudel_txt_box.TabIndex = 8;
            // 
            // automark_text_box
            // 
            automark_text_box.Location = new Point(593, 141);
            automark_text_box.Margin = new Padding(3, 4, 3, 4);
            automark_text_box.Name = "automark_text_box";
            automark_text_box.Size = new Size(133, 27);
            automark_text_box.TabIndex = 7;
            // 
            // omanik_lbl
            // 
            omanik_lbl.AutoSize = true;
            omanik_lbl.Location = new Point(510, 296);
            omanik_lbl.Name = "omanik_lbl";
            omanik_lbl.Size = new Size(60, 20);
            omanik_lbl.TabIndex = 6;
            omanik_lbl.Text = "Omanik";
            // 
            // auto_reg_num_lbl
            // 
            auto_reg_num_lbl.AutoSize = true;
            auto_reg_num_lbl.Location = new Point(510, 247);
            auto_reg_num_lbl.Name = "auto_reg_num_lbl";
            auto_reg_num_lbl.Size = new Size(86, 20);
            auto_reg_num_lbl.TabIndex = 5;
            auto_reg_num_lbl.Text = "Regnumber";
            // 
            // automudel_lbl
            // 
            automudel_lbl.AutoSize = true;
            automudel_lbl.Location = new Point(510, 195);
            automudel_lbl.Name = "automudel_lbl";
            automudel_lbl.Size = new Size(83, 20);
            automudel_lbl.TabIndex = 4;
            automudel_lbl.Text = "Automudel";
            // 
            // omanik_com_box
            // 
            omanik_com_box.FormattingEnabled = true;
            omanik_com_box.Location = new Point(589, 296);
            omanik_com_box.Margin = new Padding(3, 4, 3, 4);
            omanik_com_box.Name = "omanik_com_box";
            omanik_com_box.Size = new Size(138, 28);
            omanik_com_box.TabIndex = 2;
            // 
            // automark_lbl
            // 
            automark_lbl.AutoSize = true;
            automark_lbl.Location = new Point(510, 145);
            automark_lbl.Name = "automark_lbl";
            automark_lbl.Size = new Size(74, 20);
            automark_lbl.TabIndex = 1;
            automark_lbl.Text = "Automark";
            // 
            // autod_data
            // 
            autod_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            autod_data.Location = new Point(7, 36);
            autod_data.Margin = new Padding(3, 4, 3, 4);
            autod_data.Name = "autod_data";
            autod_data.RowHeadersWidth = 51;
            autod_data.Size = new Size(496, 480);
            autod_data.TabIndex = 0;
            // 
            // hool_teen_page
            // 
            hool_teen_page.Controls.Add(button1);
            hool_teen_page.Controls.Add(textBox3);
            hool_teen_page.Controls.Add(auto_lbl);
            hool_teen_page.Controls.Add(textBox2);
            hool_teen_page.Controls.Add(comboBox3);
            hool_teen_page.Controls.Add(comboBox1);
            hool_teen_page.Controls.Add(mileeg_lbl);
            hool_teen_page.Controls.Add(label3);
            hool_teen_page.Controls.Add(teenus_lbl);
            hool_teen_page.Controls.Add(hooldus_kir_lbl);
            hool_teen_page.Controls.Add(hooldus_data);
            hool_teen_page.Location = new Point(4, 29);
            hool_teen_page.Margin = new Padding(3, 4, 3, 4);
            hool_teen_page.Name = "hool_teen_page";
            hool_teen_page.Padding = new Padding(3, 4, 3, 4);
            hool_teen_page.Size = new Size(747, 554);
            hool_teen_page.TabIndex = 2;
            hool_teen_page.Text = "Hooldus ja Teenused";
            hool_teen_page.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(546, 8);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(195, 85);
            button1.TabIndex = 17;
            button1.Text = "Teenuste register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += lisa_teenuste_btn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(294, 144);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 27);
            textBox3.TabIndex = 16;
            // 
            // auto_lbl
            // 
            auto_lbl.AutoSize = true;
            auto_lbl.Location = new Point(21, 51);
            auto_lbl.Name = "auto_lbl";
            auto_lbl.Size = new Size(41, 20);
            auto_lbl.TabIndex = 15;
            auto_lbl.Text = "Auto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 197);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(294, 51);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(138, 28);
            comboBox3.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(294, 99);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 12;
            // 
            // mileeg_lbl
            // 
            mileeg_lbl.AutoSize = true;
            mileeg_lbl.Location = new Point(21, 200);
            mileeg_lbl.Name = "mileeg_lbl";
            mileeg_lbl.Size = new Size(63, 20);
            mileeg_lbl.TabIndex = 11;
            mileeg_lbl.Text = "Mileage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 163);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 10;
            label3.Text = "Teenuse kuupäev";
            // 
            // teenus_lbl
            // 
            teenus_lbl.AutoSize = true;
            teenus_lbl.Location = new Point(21, 107);
            teenus_lbl.Name = "teenus_lbl";
            teenus_lbl.Size = new Size(54, 20);
            teenus_lbl.TabIndex = 9;
            teenus_lbl.Text = "Teenus";
            // 
            // hooldus_kir_lbl
            // 
            hooldus_kir_lbl.AutoSize = true;
            hooldus_kir_lbl.Location = new Point(281, 0);
            hooldus_kir_lbl.Name = "hooldus_kir_lbl";
            hooldus_kir_lbl.Size = new Size(114, 20);
            hooldus_kir_lbl.TabIndex = 8;
            hooldus_kir_lbl.Text = "Hoolduse kirjed";
            // 
            // hooldus_data
            // 
            hooldus_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hooldus_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hooldus_data.Location = new Point(6, 240);
            hooldus_data.Margin = new Padding(3, 4, 3, 4);
            hooldus_data.Name = "hooldus_data";
            hooldus_data.RowHeadersWidth = 51;
            hooldus_data.Size = new Size(581, 301);
            hooldus_data.TabIndex = 2;
            // 
            // nimi_otsi_btn
            // 
            nimi_otsi_btn.Location = new Point(776, 391);
            nimi_otsi_btn.Margin = new Padding(3, 4, 3, 4);
            nimi_otsi_btn.Name = "nimi_otsi_btn";
            nimi_otsi_btn.Size = new Size(123, 59);
            nimi_otsi_btn.TabIndex = 8;
            nimi_otsi_btn.Text = "Otsi ";
            nimi_otsi_btn.UseVisualStyleBackColor = true;
            nimi_otsi_btn.Click += nimi_otsi_btn_Click;
            // 
            // lisa_btn
            // 
            lisa_btn.Location = new Point(776, 189);
            lisa_btn.Margin = new Padding(3, 4, 3, 4);
            lisa_btn.Name = "lisa_btn";
            lisa_btn.Size = new Size(122, 59);
            lisa_btn.TabIndex = 2;
            lisa_btn.Text = "Lisa";
            lisa_btn.UseVisualStyleBackColor = true;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // kust__btn
            // 
            kust__btn.Location = new Point(775, 256);
            kust__btn.Margin = new Padding(3, 4, 3, 4);
            kust__btn.Name = "kust__btn";
            kust__btn.Size = new Size(122, 59);
            kust__btn.TabIndex = 1;
            kust__btn.Text = "Kustuta";
            kust__btn.UseVisualStyleBackColor = true;
            kust__btn.Click += kust__btn_Click;
            // 
            // uuenda_btn
            // 
            uuenda_btn.Location = new Point(776, 324);
            uuenda_btn.Margin = new Padding(3, 4, 3, 4);
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.Size = new Size(122, 59);
            uuenda_btn.TabIndex = 3;
            uuenda_btn.Text = "Uuenda";
            uuenda_btn.UseVisualStyleBackColor = true;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // vaate_btn
            // 
            vaate_btn.Location = new Point(775, 123);
            vaate_btn.Margin = new Padding(3, 4, 3, 4);
            vaate_btn.Name = "vaate_btn";
            vaate_btn.Size = new Size(122, 59);
            vaate_btn.TabIndex = 9;
            vaate_btn.Text = "Vaate";
            vaate_btn.UseVisualStyleBackColor = true;
            vaate_btn.Click += vaate_btn_Click;
            // 
            // keel_com_box
            // 
            keel_com_box.FormattingEnabled = true;
            keel_com_box.Location = new Point(799, 4);
            keel_com_box.Name = "keel_com_box";
            keel_com_box.Size = new Size(110, 28);
            keel_com_box.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 624);
            Controls.Add(keel_com_box);
            Controls.Add(vaate_btn);
            Controls.Add(nimi_otsi_btn);
            Controls.Add(uuenda_btn);
            Controls.Add(tab_control);
            Controls.Add(kust__btn);
            Controls.Add(lisa_btn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tab_control.ResumeLayout(false);
            omanik_page.ResumeLayout(false);
            omanik_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)omanik_data).EndInit();
            auto_page.ResumeLayout(false);
            auto_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)autod_data).EndInit();
            hool_teen_page.ResumeLayout(false);
            hool_teen_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hooldus_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_control;
        private TabPage omanik_page;
        private TabPage auto_page;
        private TabPage hool_teen_page;
        private Button lisa_btn;
        private Button kust__btn;
        private DataGridView omanik_data;
        private Label label1;
        private Label lbl_full_name;
        private TextBox txt_box_full_name;
        private TextBox txt_box_phone;
        private Label phone_lbl;
        private Label automudel_lbl;
        private ComboBox omanik_com_box;
        private Label automark_lbl;
        private DataGridView autod_data;
        private Label omanik_lbl;
        private Label auto_reg_num_lbl;
        private TextBox auto_reg_num_text_box;
        private TextBox automudel_txt_box;
        private TextBox automark_text_box;
        private DataGridView hooldus_data;
        private Label hooldus_kir_lbl;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private Label mileeg_lbl;
        private Label label3;
        private Label teenus_lbl;
        private TextBox textBox3;
        private Label auto_lbl;
        private Button uuenda_btn;
        private Button nimi_otsi_btn;
        private Button vaate_btn;
        private Button button1;
        private ComboBox keel_com_box;
    }
}
