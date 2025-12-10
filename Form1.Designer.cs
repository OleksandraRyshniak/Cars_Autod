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
            otsi_tel_txt_box = new TextBox();
            otsi_tel_lbl = new Label();
            txt_box_phone = new TextBox();
            phone_lbl = new Label();
            label1 = new Label();
            omanik_data = new DataGridView();
            txt_box_full_name = new TextBox();
            lbl_full_name = new Label();
            auto_page = new TabPage();
            otsi_regnum_txt_box = new TextBox();
            otsi_regnum_lbl = new Label();
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
            kuup_txt_box = new DateTimePicker();
            button1 = new Button();
            auto_lbl = new Label();
            aeg_txt_box = new TextBox();
            auto_com_box = new ComboBox();
            teenus_com_box = new ComboBox();
            mileeg_lbl = new Label();
            label3 = new Label();
            teenus_lbl = new Label();
            hooldus_kir_lbl = new Label();
            hooldus_data = new DataGridView();
            lisa_btn = new Button();
            kust__btn = new Button();
            uuenda_btn = new Button();
            vaate_btn = new Button();
            keel_com_box = new ComboBox();
            otsi_reg_lbl = new Label();
            otsi_reg_txt_box = new TextBox();
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
            tab_control.Location = new Point(12, 12);
            tab_control.Name = "tab_control";
            tab_control.SelectedIndex = 0;
            tab_control.Size = new Size(661, 440);
            tab_control.TabIndex = 0;
            tab_control.Click += tab_control_Click;
            // 
            // omanik_page
            // 
            omanik_page.Controls.Add(otsi_tel_txt_box);
            omanik_page.Controls.Add(otsi_tel_lbl);
            omanik_page.Controls.Add(txt_box_phone);
            omanik_page.Controls.Add(phone_lbl);
            omanik_page.Controls.Add(label1);
            omanik_page.Controls.Add(omanik_data);
            omanik_page.Controls.Add(txt_box_full_name);
            omanik_page.Controls.Add(lbl_full_name);
            omanik_page.Location = new Point(4, 24);
            omanik_page.Name = "omanik_page";
            omanik_page.Padding = new Padding(3);
            omanik_page.Size = new Size(653, 412);
            omanik_page.TabIndex = 0;
            omanik_page.Text = "Omanikud";
            omanik_page.UseVisualStyleBackColor = true;
            // 
            // otsi_tel_txt_box
            // 
            otsi_tel_txt_box.Location = new Point(474, 216);
            otsi_tel_txt_box.Name = "otsi_tel_txt_box";
            otsi_tel_txt_box.Size = new Size(140, 23);
            otsi_tel_txt_box.TabIndex = 9;
            otsi_tel_txt_box.TextChanged += otsi_tel_txt_box_TextChanged;
            // 
            // otsi_tel_lbl
            // 
            otsi_tel_lbl.AutoSize = true;
            otsi_tel_lbl.BackColor = Color.White;
            otsi_tel_lbl.Location = new Point(474, 181);
            otsi_tel_lbl.Name = "otsi_tel_lbl";
            otsi_tel_lbl.Size = new Size(149, 15);
            otsi_tel_lbl.TabIndex = 8;
            otsi_tel_lbl.Text = "Otsida telefoninumbri järgi\r\n";
            otsi_tel_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_box_phone
            // 
            txt_box_phone.Location = new Point(474, 127);
            txt_box_phone.Name = "txt_box_phone";
            txt_box_phone.Size = new Size(140, 23);
            txt_box_phone.TabIndex = 6;
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.BackColor = Color.White;
            phone_lbl.Location = new Point(474, 96);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(91, 15);
            phone_lbl.TabIndex = 7;
            phone_lbl.Text = "Telefoninumber";
            phone_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(496, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // omanik_data
            // 
            omanik_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            omanik_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            omanik_data.Location = new Point(12, 17);
            omanik_data.Name = "omanik_data";
            omanik_data.RowHeadersWidth = 51;
            omanik_data.Size = new Size(438, 376);
            omanik_data.TabIndex = 0;
            omanik_data.CellClick += omanik_data_CellClick;
            // 
            // txt_box_full_name
            // 
            txt_box_full_name.Location = new Point(474, 56);
            txt_box_full_name.Name = "txt_box_full_name";
            txt_box_full_name.Size = new Size(140, 23);
            txt_box_full_name.TabIndex = 4;
            // 
            // lbl_full_name
            // 
            lbl_full_name.AutoSize = true;
            lbl_full_name.BackColor = Color.White;
            lbl_full_name.Location = new Point(474, 27);
            lbl_full_name.Name = "lbl_full_name";
            lbl_full_name.Size = new Size(124, 15);
            lbl_full_name.TabIndex = 3;
            lbl_full_name.Text = "Ees- ja perekonnanimi";
            lbl_full_name.TextAlign = ContentAlignment.TopCenter;
            // 
            // auto_page
            // 
            auto_page.Controls.Add(otsi_regnum_txt_box);
            auto_page.Controls.Add(otsi_regnum_lbl);
            auto_page.Controls.Add(auto_reg_num_text_box);
            auto_page.Controls.Add(automudel_txt_box);
            auto_page.Controls.Add(automark_text_box);
            auto_page.Controls.Add(omanik_lbl);
            auto_page.Controls.Add(auto_reg_num_lbl);
            auto_page.Controls.Add(automudel_lbl);
            auto_page.Controls.Add(omanik_com_box);
            auto_page.Controls.Add(automark_lbl);
            auto_page.Controls.Add(autod_data);
            auto_page.Location = new Point(4, 24);
            auto_page.Name = "auto_page";
            auto_page.Padding = new Padding(3);
            auto_page.Size = new Size(653, 412);
            auto_page.TabIndex = 1;
            auto_page.Text = "Autod";
            auto_page.UseVisualStyleBackColor = true;
            // 
            // otsi_regnum_txt_box
            // 
            otsi_regnum_txt_box.Location = new Point(446, 228);
            otsi_regnum_txt_box.Name = "otsi_regnum_txt_box";
            otsi_regnum_txt_box.Size = new Size(162, 23);
            otsi_regnum_txt_box.TabIndex = 11;
            otsi_regnum_txt_box.TextChanged += otsi_regnum_txt_box_TextChanged;
            // 
            // otsi_regnum_lbl
            // 
            otsi_regnum_lbl.AutoSize = true;
            otsi_regnum_lbl.Location = new Point(446, 206);
            otsi_regnum_lbl.Name = "otsi_regnum_lbl";
            otsi_regnum_lbl.Size = new Size(126, 15);
            otsi_regnum_lbl.TabIndex = 10;
            otsi_regnum_lbl.Text = "Otsida regnumbri järgi";
            // 
            // auto_reg_num_text_box
            // 
            auto_reg_num_text_box.Location = new Point(519, 115);
            auto_reg_num_text_box.Name = "auto_reg_num_text_box";
            auto_reg_num_text_box.Size = new Size(117, 23);
            auto_reg_num_text_box.TabIndex = 9;
            // 
            // automudel_txt_box
            // 
            automudel_txt_box.Location = new Point(519, 77);
            automudel_txt_box.Name = "automudel_txt_box";
            automudel_txt_box.Size = new Size(117, 23);
            automudel_txt_box.TabIndex = 8;
            // 
            // automark_text_box
            // 
            automark_text_box.Location = new Point(519, 38);
            automark_text_box.Name = "automark_text_box";
            automark_text_box.Size = new Size(117, 23);
            automark_text_box.TabIndex = 7;
            // 
            // omanik_lbl
            // 
            omanik_lbl.AutoSize = true;
            omanik_lbl.Location = new Point(446, 153);
            omanik_lbl.Name = "omanik_lbl";
            omanik_lbl.Size = new Size(49, 15);
            omanik_lbl.TabIndex = 6;
            omanik_lbl.Text = "Omanik";
            // 
            // auto_reg_num_lbl
            // 
            auto_reg_num_lbl.AutoSize = true;
            auto_reg_num_lbl.Location = new Point(446, 118);
            auto_reg_num_lbl.Name = "auto_reg_num_lbl";
            auto_reg_num_lbl.Size = new Size(69, 15);
            auto_reg_num_lbl.TabIndex = 5;
            auto_reg_num_lbl.Text = "Regnumber";
            // 
            // automudel_lbl
            // 
            automudel_lbl.AutoSize = true;
            automudel_lbl.Location = new Point(446, 80);
            automudel_lbl.Name = "automudel_lbl";
            automudel_lbl.Size = new Size(67, 15);
            automudel_lbl.TabIndex = 4;
            automudel_lbl.Text = "Automudel";
            // 
            // omanik_com_box
            // 
            omanik_com_box.FormattingEnabled = true;
            omanik_com_box.Location = new Point(519, 150);
            omanik_com_box.Name = "omanik_com_box";
            omanik_com_box.Size = new Size(117, 23);
            omanik_com_box.TabIndex = 2;
            // 
            // automark_lbl
            // 
            automark_lbl.AutoSize = true;
            automark_lbl.Location = new Point(446, 41);
            automark_lbl.Name = "automark_lbl";
            automark_lbl.Size = new Size(60, 15);
            automark_lbl.TabIndex = 1;
            automark_lbl.Text = "Automark";
            // 
            // autod_data
            // 
            autod_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            autod_data.Location = new Point(6, 27);
            autod_data.Name = "autod_data";
            autod_data.RowHeadersWidth = 51;
            autod_data.Size = new Size(434, 360);
            autod_data.TabIndex = 0;
            autod_data.CellClick += autod_data_CellClick;
            // 
            // hool_teen_page
            // 
            hool_teen_page.Controls.Add(otsi_reg_txt_box);
            hool_teen_page.Controls.Add(otsi_reg_lbl);
            hool_teen_page.Controls.Add(kuup_txt_box);
            hool_teen_page.Controls.Add(button1);
            hool_teen_page.Controls.Add(auto_lbl);
            hool_teen_page.Controls.Add(aeg_txt_box);
            hool_teen_page.Controls.Add(auto_com_box);
            hool_teen_page.Controls.Add(teenus_com_box);
            hool_teen_page.Controls.Add(mileeg_lbl);
            hool_teen_page.Controls.Add(label3);
            hool_teen_page.Controls.Add(teenus_lbl);
            hool_teen_page.Controls.Add(hooldus_kir_lbl);
            hool_teen_page.Controls.Add(hooldus_data);
            hool_teen_page.Location = new Point(4, 24);
            hool_teen_page.Name = "hool_teen_page";
            hool_teen_page.Padding = new Padding(3);
            hool_teen_page.Size = new Size(653, 412);
            hool_teen_page.TabIndex = 2;
            hool_teen_page.Text = "Hooldus ja Teenused";
            hool_teen_page.UseVisualStyleBackColor = true;
            // 
            // kuup_txt_box
            // 
            kuup_txt_box.Location = new Point(257, 117);
            kuup_txt_box.Margin = new Padding(3, 2, 3, 2);
            kuup_txt_box.Name = "kuup_txt_box";
            kuup_txt_box.Size = new Size(140, 23);
            kuup_txt_box.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(478, 6);
            button1.Name = "button1";
            button1.Size = new Size(171, 64);
            button1.TabIndex = 17;
            button1.Text = "Teenuste register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += lisa_teenuste_btn_Click;
            // 
            // auto_lbl
            // 
            auto_lbl.AutoSize = true;
            auto_lbl.Location = new Point(18, 38);
            auto_lbl.Name = "auto_lbl";
            auto_lbl.Size = new Size(33, 15);
            auto_lbl.TabIndex = 15;
            auto_lbl.Text = "Auto";
            // 
            // aeg_txt_box
            // 
            aeg_txt_box.Location = new Point(257, 148);
            aeg_txt_box.Name = "aeg_txt_box";
            aeg_txt_box.Size = new Size(140, 23);
            aeg_txt_box.TabIndex = 14;
            // 
            // auto_com_box
            // 
            auto_com_box.FormattingEnabled = true;
            auto_com_box.Location = new Point(257, 38);
            auto_com_box.Name = "auto_com_box";
            auto_com_box.Size = new Size(140, 23);
            auto_com_box.TabIndex = 13;
            // 
            // teenus_com_box
            // 
            teenus_com_box.FormattingEnabled = true;
            teenus_com_box.Location = new Point(257, 74);
            teenus_com_box.Name = "teenus_com_box";
            teenus_com_box.Size = new Size(140, 23);
            teenus_com_box.TabIndex = 12;
            // 
            // mileeg_lbl
            // 
            mileeg_lbl.AutoSize = true;
            mileeg_lbl.Location = new Point(18, 150);
            mileeg_lbl.Name = "mileeg_lbl";
            mileeg_lbl.Size = new Size(49, 15);
            mileeg_lbl.TabIndex = 11;
            mileeg_lbl.Text = "Mileage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 117);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 10;
            label3.Text = "Teenuse kuupäev";
            // 
            // teenus_lbl
            // 
            teenus_lbl.AutoSize = true;
            teenus_lbl.Location = new Point(18, 80);
            teenus_lbl.Name = "teenus_lbl";
            teenus_lbl.Size = new Size(44, 15);
            teenus_lbl.TabIndex = 9;
            teenus_lbl.Text = "Teenus";
            // 
            // hooldus_kir_lbl
            // 
            hooldus_kir_lbl.AutoSize = true;
            hooldus_kir_lbl.Location = new Point(246, 0);
            hooldus_kir_lbl.Name = "hooldus_kir_lbl";
            hooldus_kir_lbl.Size = new Size(90, 15);
            hooldus_kir_lbl.TabIndex = 8;
            hooldus_kir_lbl.Text = "Hoolduse kirjed";
            // 
            // hooldus_data
            // 
            hooldus_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hooldus_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hooldus_data.Location = new Point(5, 180);
            hooldus_data.Name = "hooldus_data";
            hooldus_data.RowHeadersWidth = 51;
            hooldus_data.Size = new Size(508, 226);
            hooldus_data.TabIndex = 2;
            hooldus_data.CellClick += hooldus_data_CellClick;
            // 
            // lisa_btn
            // 
            lisa_btn.Location = new Point(679, 151);
            lisa_btn.Name = "lisa_btn";
            lisa_btn.Size = new Size(107, 44);
            lisa_btn.TabIndex = 2;
            lisa_btn.Text = "Lisa";
            lisa_btn.UseVisualStyleBackColor = true;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // kust__btn
            // 
            kust__btn.Location = new Point(678, 202);
            kust__btn.Name = "kust__btn";
            kust__btn.Size = new Size(107, 44);
            kust__btn.TabIndex = 1;
            kust__btn.Text = "Kustuta";
            kust__btn.UseVisualStyleBackColor = true;
            kust__btn.Click += kust__btn_Click;
            // 
            // uuenda_btn
            // 
            uuenda_btn.Location = new Point(679, 252);
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.Size = new Size(107, 44);
            uuenda_btn.TabIndex = 3;
            uuenda_btn.Text = "Uuenda";
            uuenda_btn.UseVisualStyleBackColor = true;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // vaate_btn
            // 
            vaate_btn.Location = new Point(678, 101);
            vaate_btn.Name = "vaate_btn";
            vaate_btn.Size = new Size(107, 44);
            vaate_btn.TabIndex = 9;
            vaate_btn.Text = "Vaata kõik";
            vaate_btn.UseVisualStyleBackColor = true;
            vaate_btn.Click += vaate_btn_Click;
            // 
            // keel_com_box
            // 
            keel_com_box.FormattingEnabled = true;
            keel_com_box.Location = new Point(679, 3);
            keel_com_box.Margin = new Padding(3, 2, 3, 2);
            keel_com_box.Name = "keel_com_box";
            keel_com_box.Size = new Size(117, 23);
            keel_com_box.TabIndex = 10;
            // 
            // otsi_reg_lbl
            // 
            otsi_reg_lbl.AutoSize = true;
            otsi_reg_lbl.Location = new Point(478, 94);
            otsi_reg_lbl.Name = "otsi_reg_lbl";
            otsi_reg_lbl.Size = new Size(126, 15);
            otsi_reg_lbl.TabIndex = 19;
            otsi_reg_lbl.Text = "Otsida regnumbri järgi";
            // 
            // otsi_reg_txt_box
            // 
            otsi_reg_txt_box.Location = new Point(478, 115);
            otsi_reg_txt_box.Name = "otsi_reg_txt_box";
            otsi_reg_txt_box.Size = new Size(140, 23);
            otsi_reg_txt_box.TabIndex = 20;
            otsi_reg_txt_box.TextChanged += otsi_reg_txt_box_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 468);
            Controls.Add(keel_com_box);
            Controls.Add(vaate_btn);
            Controls.Add(uuenda_btn);
            Controls.Add(tab_control);
            Controls.Add(kust__btn);
            Controls.Add(lisa_btn);
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
        private TextBox aeg_txt_box;
        private ComboBox auto_com_box;
        private ComboBox teenus_com_box;
        private Label mileeg_lbl;
        private Label label3;
        private Label teenus_lbl;
        private Label auto_lbl;
        private Button uuenda_btn;
        private Button vaate_btn;
        private Button button1;
        private ComboBox keel_com_box;
        private DateTimePicker kuup_txt_box;
        private TextBox otsi_tel_txt_box;
        private Label otsi_tel_lbl;
        private Label otsi_regnum_lbl;
        private TextBox otsi_regnum_txt_box;
        private Label otsi_reg_lbl;
        private TextBox otsi_reg_txt_box;
    }
}
