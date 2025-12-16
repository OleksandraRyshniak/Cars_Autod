namespace Cars
{
    partial class mehaanik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mehaanik));
            meh_lbl = new Label();
            nimi_lbl = new Label();
            nimi_txt = new TextBox();
            phone_lbl = new Label();
            phone_txt = new TextBox();
            otsi_lbl = new Label();
            otsi_txt = new TextBox();
            meh_data = new DataGridView();
            lisa_btn = new Button();
            koik_btn = new Button();
            uuenda_btn = new Button();
            kust_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)meh_data).BeginInit();
            SuspendLayout();
            // 
            // meh_lbl
            // 
            resources.ApplyResources(meh_lbl, "meh_lbl");
            meh_lbl.Name = "meh_lbl";
            // 
            // nimi_lbl
            // 
            resources.ApplyResources(nimi_lbl, "nimi_lbl");
            nimi_lbl.Name = "nimi_lbl";
            // 
            // nimi_txt
            // 
            resources.ApplyResources(nimi_txt, "nimi_txt");
            nimi_txt.Name = "nimi_txt";
            // 
            // phone_lbl
            // 
            resources.ApplyResources(phone_lbl, "phone_lbl");
            phone_lbl.Name = "phone_lbl";
            // 
            // phone_txt
            // 
            resources.ApplyResources(phone_txt, "phone_txt");
            phone_txt.Name = "phone_txt";
            // 
            // otsi_lbl
            // 
            resources.ApplyResources(otsi_lbl, "otsi_lbl");
            otsi_lbl.Name = "otsi_lbl";
            // 
            // otsi_txt
            // 
            resources.ApplyResources(otsi_txt, "otsi_txt");
            otsi_txt.Name = "otsi_txt";
            otsi_txt.TextChanged += textBox1_TextChanged;
            // 
            // meh_data
            // 
            meh_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            meh_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(meh_data, "meh_data");
            meh_data.Name = "meh_data";
            meh_data.CellClick += meh_data_CellClick;
            // 
            // lisa_btn
            // 
            lisa_btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(lisa_btn, "lisa_btn");
            lisa_btn.Name = "lisa_btn";
            lisa_btn.UseVisualStyleBackColor = false;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // koik_btn
            // 
            koik_btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(koik_btn, "koik_btn");
            koik_btn.Name = "koik_btn";
            koik_btn.UseVisualStyleBackColor = false;
            koik_btn.Click += koik_btn_Click;
            // 
            // uuenda_btn
            // 
            uuenda_btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(uuenda_btn, "uuenda_btn");
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.UseVisualStyleBackColor = false;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // kust_btn
            // 
            kust_btn.BackColor = Color.LightSteelBlue;
            resources.ApplyResources(kust_btn, "kust_btn");
            kust_btn.Name = "kust_btn";
            kust_btn.UseVisualStyleBackColor = false;
            kust_btn.Click += kust_btn_Click;
            // 
            // mehaanik
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kust_btn);
            Controls.Add(uuenda_btn);
            Controls.Add(koik_btn);
            Controls.Add(lisa_btn);
            Controls.Add(meh_data);
            Controls.Add(otsi_txt);
            Controls.Add(otsi_lbl);
            Controls.Add(phone_txt);
            Controls.Add(phone_lbl);
            Controls.Add(nimi_txt);
            Controls.Add(nimi_lbl);
            Controls.Add(meh_lbl);
            Name = "mehaanik";
            Load += mehaanik_Load;
            ((System.ComponentModel.ISupportInitialize)meh_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label meh_lbl;
        private Label nimi_lbl;
        private TextBox nimi_txt;
        private Label phone_lbl;
        private TextBox phone_txt;
        private Label otsi_lbl;
        private TextBox otsi_txt;
        private DataGridView meh_data;
        private Button lisa_btn;
        private Button koik_btn;
        private Button uuenda_btn;
        private Button kust_btn;
    }
}