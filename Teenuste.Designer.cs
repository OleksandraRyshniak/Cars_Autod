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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teenuste));
            nimi_txt_box = new TextBox();
            nimi_lbl = new Label();
            hind_txt_box = new TextBox();
            hind_lbl = new Label();
            hooldus_kir_lbl = new Label();
            lisa_btn = new Button();
            teenuste_data = new DataGridView();
            kustuta_btn = new Button();
            uuenda_btn = new Button();
            keel_com = new ComboBox();
            otsi_teen__lbl = new Label();
            otsi_teen_txt_box = new TextBox();
            pageSetupDialog1 = new PageSetupDialog();
            koik_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)teenuste_data).BeginInit();
            SuspendLayout();
            // 
            // nimi_txt_box
            // 
            resources.ApplyResources(nimi_txt_box, "nimi_txt_box");
            nimi_txt_box.Name = "nimi_txt_box";
            // 
            // nimi_lbl
            // 
            resources.ApplyResources(nimi_lbl, "nimi_lbl");
            nimi_lbl.Name = "nimi_lbl";
            // 
            // hind_txt_box
            // 
            resources.ApplyResources(hind_txt_box, "hind_txt_box");
            hind_txt_box.Name = "hind_txt_box";
            // 
            // hind_lbl
            // 
            resources.ApplyResources(hind_lbl, "hind_lbl");
            hind_lbl.Name = "hind_lbl";
            // 
            // hooldus_kir_lbl
            // 
            resources.ApplyResources(hooldus_kir_lbl, "hooldus_kir_lbl");
            hooldus_kir_lbl.Name = "hooldus_kir_lbl";
            // 
            // lisa_btn
            // 
            resources.ApplyResources(lisa_btn, "lisa_btn");
            lisa_btn.Name = "lisa_btn";
            lisa_btn.UseVisualStyleBackColor = true;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // teenuste_data
            // 
            teenuste_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            teenuste_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(teenuste_data, "teenuste_data");
            teenuste_data.Name = "teenuste_data";
            teenuste_data.CellClick += teenuste_data_CellClick;
            // 
            // kustuta_btn
            // 
            resources.ApplyResources(kustuta_btn, "kustuta_btn");
            kustuta_btn.Name = "kustuta_btn";
            kustuta_btn.UseVisualStyleBackColor = true;
            kustuta_btn.Click += kustuta_btn_Click;
            // 
            // uuenda_btn
            // 
            resources.ApplyResources(uuenda_btn, "uuenda_btn");
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.UseVisualStyleBackColor = true;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // keel_com
            // 
            keel_com.FormattingEnabled = true;
            resources.ApplyResources(keel_com, "keel_com");
            keel_com.Name = "keel_com";
            keel_com.SelectedIndexChanged += keel_com_SelectedIndexChanged;
            // 
            // otsi_teen__lbl
            // 
            resources.ApplyResources(otsi_teen__lbl, "otsi_teen__lbl");
            otsi_teen__lbl.Name = "otsi_teen__lbl";
            // 
            // otsi_teen_txt_box
            // 
            resources.ApplyResources(otsi_teen_txt_box, "otsi_teen_txt_box");
            otsi_teen_txt_box.Name = "otsi_teen_txt_box";
            otsi_teen_txt_box.TextChanged += otsi_teen_txt_box_TextChanged;
            // 
            // koik_btn
            // 
            resources.ApplyResources(koik_btn, "koik_btn");
            koik_btn.Name = "koik_btn";
            koik_btn.UseVisualStyleBackColor = true;
            koik_btn.Click += koik_btn_Click;
            // 
            // Teenuste
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(koik_btn);
            Controls.Add(otsi_teen_txt_box);
            Controls.Add(otsi_teen__lbl);
            Controls.Add(keel_com);
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
            Load += Teenuste_Load;
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
        private ComboBox keel_com;
        private Label otsi_teen__lbl;
        private TextBox otsi_teen_txt_box;
        private PageSetupDialog pageSetupDialog1;
        private Button koik_btn;
    }
}