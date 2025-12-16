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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            lisa_btn = new Button();
            kust__btn = new Button();
            uuenda_btn = new Button();
            keel_com_box = new ComboBox();
            mehaanik_btn = new Button();
            vaata_btn = new Button();
            hool_teen_page = new TabPage();
            mehk_com = new ComboBox();
            mehaan_lbl = new Label();
            status_lbl = new Label();
            status_com = new ComboBox();
            label2 = new Label();
            time_txt_box = new DateTimePicker();
            kuup_txt_box = new DateTimePicker();
            otsi_reg_txt_box = new TextBox();
            aeg_txt_box = new TextBox();
            otsi_reg_lbl = new Label();
            auto_lbl = new Label();
            auto_com_box = new ComboBox();
            teenus_com_box = new ComboBox();
            mileeg_lbl = new Label();
            label3 = new Label();
            teenus_lbl = new Label();
            hooldus_kir_lbl = new Label();
            hooldus_data = new DataGridView();
            auto_page = new TabPage();
            label4 = new Label();
            otsi_regnum_txt_box = new TextBox();
            auto_reg_num_text_box = new TextBox();
            automudel_txt_box = new TextBox();
            automark_text_box = new TextBox();
            otsi_regnum_lbl = new Label();
            omanik_lbl = new Label();
            auto_reg_num_lbl = new Label();
            automudel_lbl = new Label();
            omanik_com_box = new ComboBox();
            automark_lbl = new Label();
            autod_data = new DataGridView();
            omanik_page = new TabPage();
            label5 = new Label();
            otsi_tel_txt_box = new TextBox();
            txt_box_phone = new TextBox();
            txt_box_full_name = new TextBox();
            otsi_tel_lbl = new Label();
            phone_lbl = new Label();
            label1 = new Label();
            omanik_data = new DataGridView();
            lbl_full_name = new Label();
            tab_control = new TabControl();
            hool_teen_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hooldus_data).BeginInit();
            auto_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)autod_data).BeginInit();
            omanik_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)omanik_data).BeginInit();
            tab_control.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += lisa_teenuste_btn_Click;
            // 
            // lisa_btn
            // 
            lisa_btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(lisa_btn, "lisa_btn");
            lisa_btn.Name = "lisa_btn";
            lisa_btn.UseVisualStyleBackColor = false;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // kust__btn
            // 
            kust__btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(kust__btn, "kust__btn");
            kust__btn.Name = "kust__btn";
            kust__btn.UseVisualStyleBackColor = false;
            kust__btn.Click += kust__btn_Click;
            // 
            // uuenda_btn
            // 
            uuenda_btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(uuenda_btn, "uuenda_btn");
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.UseVisualStyleBackColor = false;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // keel_com_box
            // 
            keel_com_box.FormattingEnabled = true;
            resources.ApplyResources(keel_com_box, "keel_com_box");
            keel_com_box.Name = "keel_com_box";
            keel_com_box.SelectedIndexChanged += keel_com_box_SelectedIndexChanged;
            // 
            // mehaanik_btn
            // 
            mehaanik_btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(mehaanik_btn, "mehaanik_btn");
            mehaanik_btn.Name = "mehaanik_btn";
            mehaanik_btn.UseVisualStyleBackColor = false;
            mehaanik_btn.Click += mehaanik_btn_Click;
            // 
            // vaata_btn
            // 
            vaata_btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(vaata_btn, "vaata_btn");
            vaata_btn.Name = "vaata_btn";
            vaata_btn.UseVisualStyleBackColor = false;
            vaata_btn.Click += vaata_btn_Click;
            // 
            // hool_teen_page
            // 
            hool_teen_page.Controls.Add(mehk_com);
            hool_teen_page.Controls.Add(mehaan_lbl);
            hool_teen_page.Controls.Add(status_lbl);
            hool_teen_page.Controls.Add(status_com);
            hool_teen_page.Controls.Add(label2);
            hool_teen_page.Controls.Add(time_txt_box);
            hool_teen_page.Controls.Add(kuup_txt_box);
            hool_teen_page.Controls.Add(otsi_reg_txt_box);
            hool_teen_page.Controls.Add(aeg_txt_box);
            hool_teen_page.Controls.Add(otsi_reg_lbl);
            hool_teen_page.Controls.Add(auto_lbl);
            hool_teen_page.Controls.Add(auto_com_box);
            hool_teen_page.Controls.Add(teenus_com_box);
            hool_teen_page.Controls.Add(mileeg_lbl);
            hool_teen_page.Controls.Add(label3);
            hool_teen_page.Controls.Add(teenus_lbl);
            hool_teen_page.Controls.Add(hooldus_kir_lbl);
            hool_teen_page.Controls.Add(hooldus_data);
            resources.ApplyResources(hool_teen_page, "hool_teen_page");
            hool_teen_page.Name = "hool_teen_page";
            hool_teen_page.UseVisualStyleBackColor = true;
            // 
            // mehk_com
            // 
            mehk_com.FormattingEnabled = true;
            resources.ApplyResources(mehk_com, "mehk_com");
            mehk_com.Name = "mehk_com";
            // 
            // mehaan_lbl
            // 
            resources.ApplyResources(mehaan_lbl, "mehaan_lbl");
            mehaan_lbl.Name = "mehaan_lbl";
            mehaan_lbl.Click += mehaan_lbl_Click;
            // 
            // status_lbl
            // 
            resources.ApplyResources(status_lbl, "status_lbl");
            status_lbl.Name = "status_lbl";
            // 
            // status_com
            // 
            status_com.FormattingEnabled = true;
            resources.ApplyResources(status_com, "status_com");
            status_com.Name = "status_com";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // time_txt_box
            // 
            resources.ApplyResources(time_txt_box, "time_txt_box");
            time_txt_box.Format = DateTimePickerFormat.Custom;
            time_txt_box.Name = "time_txt_box";
            time_txt_box.ShowUpDown = true;
            time_txt_box.Value = new DateTime(2025, 12, 11, 12, 0, 0, 0);
            // 
            // kuup_txt_box
            // 
            resources.ApplyResources(kuup_txt_box, "kuup_txt_box");
            kuup_txt_box.Format = DateTimePickerFormat.Custom;
            kuup_txt_box.MinDate = new DateTime(2025, 12, 16, 13, 15, 0, 0);
            kuup_txt_box.Name = "kuup_txt_box";
            kuup_txt_box.Value = new DateTime(2025, 12, 16, 13, 15, 0, 0);
            // 
            // otsi_reg_txt_box
            // 
            resources.ApplyResources(otsi_reg_txt_box, "otsi_reg_txt_box");
            otsi_reg_txt_box.Name = "otsi_reg_txt_box";
            otsi_reg_txt_box.TextChanged += otsi_reg_txt_box_TextChanged;
            // 
            // aeg_txt_box
            // 
            resources.ApplyResources(aeg_txt_box, "aeg_txt_box");
            aeg_txt_box.Name = "aeg_txt_box";
            // 
            // otsi_reg_lbl
            // 
            resources.ApplyResources(otsi_reg_lbl, "otsi_reg_lbl");
            otsi_reg_lbl.Name = "otsi_reg_lbl";
            // 
            // auto_lbl
            // 
            resources.ApplyResources(auto_lbl, "auto_lbl");
            auto_lbl.Name = "auto_lbl";
            // 
            // auto_com_box
            // 
            auto_com_box.FormattingEnabled = true;
            resources.ApplyResources(auto_com_box, "auto_com_box");
            auto_com_box.Name = "auto_com_box";
            // 
            // teenus_com_box
            // 
            teenus_com_box.FormattingEnabled = true;
            resources.ApplyResources(teenus_com_box, "teenus_com_box");
            teenus_com_box.Name = "teenus_com_box";
            // 
            // mileeg_lbl
            // 
            resources.ApplyResources(mileeg_lbl, "mileeg_lbl");
            mileeg_lbl.Name = "mileeg_lbl";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // teenus_lbl
            // 
            resources.ApplyResources(teenus_lbl, "teenus_lbl");
            teenus_lbl.Name = "teenus_lbl";
            // 
            // hooldus_kir_lbl
            // 
            resources.ApplyResources(hooldus_kir_lbl, "hooldus_kir_lbl");
            hooldus_kir_lbl.Name = "hooldus_kir_lbl";
            // 
            // hooldus_data
            // 
            hooldus_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hooldus_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(hooldus_data, "hooldus_data");
            hooldus_data.Name = "hooldus_data";
            hooldus_data.CellClick += hooldus_data_CellClick;
            // 
            // auto_page
            // 
            auto_page.Controls.Add(label4);
            auto_page.Controls.Add(otsi_regnum_txt_box);
            auto_page.Controls.Add(auto_reg_num_text_box);
            auto_page.Controls.Add(automudel_txt_box);
            auto_page.Controls.Add(automark_text_box);
            auto_page.Controls.Add(otsi_regnum_lbl);
            auto_page.Controls.Add(omanik_lbl);
            auto_page.Controls.Add(auto_reg_num_lbl);
            auto_page.Controls.Add(automudel_lbl);
            auto_page.Controls.Add(omanik_com_box);
            auto_page.Controls.Add(automark_lbl);
            auto_page.Controls.Add(autod_data);
            resources.ApplyResources(auto_page, "auto_page");
            auto_page.Name = "auto_page";
            auto_page.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // otsi_regnum_txt_box
            // 
            resources.ApplyResources(otsi_regnum_txt_box, "otsi_regnum_txt_box");
            otsi_regnum_txt_box.Name = "otsi_regnum_txt_box";
            otsi_regnum_txt_box.TextChanged += otsi_regnum_txt_box_TextChanged;
            // 
            // auto_reg_num_text_box
            // 
            resources.ApplyResources(auto_reg_num_text_box, "auto_reg_num_text_box");
            auto_reg_num_text_box.Name = "auto_reg_num_text_box";
            // 
            // automudel_txt_box
            // 
            resources.ApplyResources(automudel_txt_box, "automudel_txt_box");
            automudel_txt_box.Name = "automudel_txt_box";
            // 
            // automark_text_box
            // 
            resources.ApplyResources(automark_text_box, "automark_text_box");
            automark_text_box.Name = "automark_text_box";
            // 
            // otsi_regnum_lbl
            // 
            resources.ApplyResources(otsi_regnum_lbl, "otsi_regnum_lbl");
            otsi_regnum_lbl.Name = "otsi_regnum_lbl";
            // 
            // omanik_lbl
            // 
            resources.ApplyResources(omanik_lbl, "omanik_lbl");
            omanik_lbl.Name = "omanik_lbl";
            // 
            // auto_reg_num_lbl
            // 
            resources.ApplyResources(auto_reg_num_lbl, "auto_reg_num_lbl");
            auto_reg_num_lbl.Name = "auto_reg_num_lbl";
            // 
            // automudel_lbl
            // 
            resources.ApplyResources(automudel_lbl, "automudel_lbl");
            automudel_lbl.Name = "automudel_lbl";
            // 
            // omanik_com_box
            // 
            omanik_com_box.FormattingEnabled = true;
            resources.ApplyResources(omanik_com_box, "omanik_com_box");
            omanik_com_box.Name = "omanik_com_box";
            // 
            // automark_lbl
            // 
            resources.ApplyResources(automark_lbl, "automark_lbl");
            automark_lbl.Name = "automark_lbl";
            // 
            // autod_data
            // 
            autod_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(autod_data, "autod_data");
            autod_data.Name = "autod_data";
            autod_data.CellClick += autod_data_CellClick;
            // 
            // omanik_page
            // 
            omanik_page.Controls.Add(label5);
            omanik_page.Controls.Add(otsi_tel_txt_box);
            omanik_page.Controls.Add(txt_box_phone);
            omanik_page.Controls.Add(txt_box_full_name);
            omanik_page.Controls.Add(otsi_tel_lbl);
            omanik_page.Controls.Add(phone_lbl);
            omanik_page.Controls.Add(label1);
            omanik_page.Controls.Add(omanik_data);
            omanik_page.Controls.Add(lbl_full_name);
            resources.ApplyResources(omanik_page, "omanik_page");
            omanik_page.Name = "omanik_page";
            omanik_page.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.White;
            label5.Name = "label5";
            // 
            // otsi_tel_txt_box
            // 
            resources.ApplyResources(otsi_tel_txt_box, "otsi_tel_txt_box");
            otsi_tel_txt_box.Name = "otsi_tel_txt_box";
            otsi_tel_txt_box.TextChanged += otsi_tel_txt_box_TextChanged;
            // 
            // txt_box_phone
            // 
            resources.ApplyResources(txt_box_phone, "txt_box_phone");
            txt_box_phone.Name = "txt_box_phone";
            // 
            // txt_box_full_name
            // 
            resources.ApplyResources(txt_box_full_name, "txt_box_full_name");
            txt_box_full_name.Name = "txt_box_full_name";
            // 
            // otsi_tel_lbl
            // 
            resources.ApplyResources(otsi_tel_lbl, "otsi_tel_lbl");
            otsi_tel_lbl.BackColor = Color.White;
            otsi_tel_lbl.Name = "otsi_tel_lbl";
            // 
            // phone_lbl
            // 
            resources.ApplyResources(phone_lbl, "phone_lbl");
            phone_lbl.BackColor = Color.White;
            phone_lbl.Name = "phone_lbl";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // omanik_data
            // 
            omanik_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            omanik_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(omanik_data, "omanik_data");
            omanik_data.Name = "omanik_data";
            omanik_data.CellClick += omanik_data_CellClick;
            // 
            // lbl_full_name
            // 
            resources.ApplyResources(lbl_full_name, "lbl_full_name");
            lbl_full_name.BackColor = Color.White;
            lbl_full_name.Name = "lbl_full_name";
            // 
            // tab_control
            // 
            tab_control.Controls.Add(omanik_page);
            tab_control.Controls.Add(auto_page);
            tab_control.Controls.Add(hool_teen_page);
            resources.ApplyResources(tab_control, "tab_control");
            tab_control.Name = "tab_control";
            tab_control.SelectedIndex = 0;
            tab_control.Click += tab_control_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(vaata_btn);
            Controls.Add(mehaanik_btn);
            Controls.Add(keel_com_box);
            Controls.Add(uuenda_btn);
            Controls.Add(tab_control);
            Controls.Add(kust__btn);
            Controls.Add(button1);
            Controls.Add(lisa_btn);
            Name = "Form1";
            Load += Form1_Load;
            hool_teen_page.ResumeLayout(false);
            hool_teen_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hooldus_data).EndInit();
            auto_page.ResumeLayout(false);
            auto_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)autod_data).EndInit();
            omanik_page.ResumeLayout(false);
            omanik_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)omanik_data).EndInit();
            tab_control.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button lisa_btn;
        private Button kust__btn;
        private Button uuenda_btn;
        private Button button1;
        private ComboBox keel_com_box;
        private Button mehaanik_btn;
        private Button vaata_btn;
        private TabPage hool_teen_page;
        private ComboBox mehk_com;
        private Label mehaan_lbl;
        private Label status_lbl;
        private ComboBox status_com;
        private Label label2;
        private DateTimePicker time_txt_box;
        private DateTimePicker kuup_txt_box;
        private TextBox otsi_reg_txt_box;
        private TextBox aeg_txt_box;
        private Label otsi_reg_lbl;
        private Label auto_lbl;
        private ComboBox auto_com_box;
        private ComboBox teenus_com_box;
        private Label mileeg_lbl;
        private Label label3;
        private Label teenus_lbl;
        private Label hooldus_kir_lbl;
        private DataGridView hooldus_data;
        private TabPage auto_page;
        private TextBox otsi_regnum_txt_box;
        private TextBox auto_reg_num_text_box;
        private TextBox automudel_txt_box;
        private TextBox automark_text_box;
        private Label otsi_regnum_lbl;
        private Label omanik_lbl;
        private Label auto_reg_num_lbl;
        private Label automudel_lbl;
        private ComboBox omanik_com_box;
        private Label automark_lbl;
        private DataGridView autod_data;
        private TabPage omanik_page;
        private TextBox otsi_tel_txt_box;
        private TextBox txt_box_phone;
        private TextBox txt_box_full_name;
        private Label otsi_tel_lbl;
        private Label phone_lbl;
        private Label label1;
        private DataGridView omanik_data;
        private Label lbl_full_name;
        private TabControl tab_control;
        private Label label4;
        private Label label5;
    }
}
