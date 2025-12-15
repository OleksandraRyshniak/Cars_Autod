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
            meh_lbl = new Label();
            nimi_lbl = new Label();
            nimi_txt = new TextBox();
            phone_lbl = new Label();
            phone_txt = new TextBox();
            otsi_lbl = new Label();
            otsi_txt = new TextBox();
            meh_data = new DataGridView();
            keel_com = new ComboBox();
            lisa_btn = new Button();
            koik_btn = new Button();
            uuenda_btn = new Button();
            kust_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)meh_data).BeginInit();
            SuspendLayout();
            // 
            // meh_lbl
            // 
            meh_lbl.AutoSize = true;
            meh_lbl.Location = new Point(175, 9);
            meh_lbl.Name = "meh_lbl";
            meh_lbl.Size = new Size(90, 20);
            meh_lbl.TabIndex = 0;
            meh_lbl.Text = "Mehaanikud";
            // 
            // nimi_lbl
            // 
            nimi_lbl.AutoSize = true;
            nimi_lbl.Location = new Point(28, 61);
            nimi_lbl.Name = "nimi_lbl";
            nimi_lbl.Size = new Size(63, 20);
            nimi_lbl.TabIndex = 2;
            nimi_lbl.Text = "Täisnimi";
            // 
            // nimi_txt
            // 
            nimi_txt.Location = new Point(97, 61);
            nimi_txt.Name = "nimi_txt";
            nimi_txt.Size = new Size(171, 27);
            nimi_txt.TabIndex = 3;
            // 
            // phone_lbl
            // 
            phone_lbl.AutoSize = true;
            phone_lbl.Location = new Point(28, 108);
            phone_lbl.Name = "phone_lbl";
            phone_lbl.Size = new Size(58, 20);
            phone_lbl.TabIndex = 4;
            phone_lbl.Text = "Telefon";
            // 
            // phone_txt
            // 
            phone_txt.Location = new Point(97, 108);
            phone_txt.Name = "phone_txt";
            phone_txt.Size = new Size(171, 27);
            phone_txt.TabIndex = 5;
            // 
            // otsi_lbl
            // 
            otsi_lbl.AutoSize = true;
            otsi_lbl.Location = new Point(28, 161);
            otsi_lbl.Name = "otsi_lbl";
            otsi_lbl.Size = new Size(188, 20);
            otsi_lbl.TabIndex = 6;
            otsi_lbl.Text = "Otsida telefoninumbri järgi";
            // 
            // otsi_txt
            // 
            otsi_txt.Location = new Point(28, 194);
            otsi_txt.Name = "otsi_txt";
            otsi_txt.Size = new Size(188, 27);
            otsi_txt.TabIndex = 7;
            otsi_txt.TextChanged += textBox1_TextChanged;
            // 
            // meh_data
            // 
            meh_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            meh_data.Location = new Point(4, 236);
            meh_data.Name = "meh_data";
            meh_data.RowHeadersWidth = 51;
            meh_data.Size = new Size(433, 269);
            meh_data.TabIndex = 8;
            meh_data.CellClick += meh_data_CellClick;
            // 
            // keel_com
            // 
            keel_com.FormattingEnabled = true;
            keel_com.Location = new Point(301, 1);
            keel_com.Name = "keel_com";
            keel_com.Size = new Size(136, 28);
            keel_com.TabIndex = 9;
            // 
            // lisa_btn
            // 
            lisa_btn.Location = new Point(301, 54);
            lisa_btn.Name = "lisa_btn";
            lisa_btn.Size = new Size(115, 34);
            lisa_btn.TabIndex = 10;
            lisa_btn.Text = "Lisa";
            lisa_btn.UseVisualStyleBackColor = true;
            lisa_btn.Click += lisa_btn_Click;
            // 
            // koik_btn
            // 
            koik_btn.Location = new Point(243, 187);
            koik_btn.Name = "koik_btn";
            koik_btn.Size = new Size(115, 34);
            koik_btn.TabIndex = 11;
            koik_btn.Text = "Vaata kõik";
            koik_btn.UseVisualStyleBackColor = true;
            koik_btn.Click += koik_btn_Click;
            // 
            // uuenda_btn
            // 
            uuenda_btn.Location = new Point(301, 134);
            uuenda_btn.Name = "uuenda_btn";
            uuenda_btn.Size = new Size(115, 34);
            uuenda_btn.TabIndex = 12;
            uuenda_btn.Text = "Uuenda";
            uuenda_btn.UseVisualStyleBackColor = true;
            uuenda_btn.Click += uuenda_btn_Click;
            // 
            // kust_btn
            // 
            kust_btn.Location = new Point(301, 94);
            kust_btn.Name = "kust_btn";
            kust_btn.Size = new Size(115, 34);
            kust_btn.TabIndex = 13;
            kust_btn.Text = "Kustuta";
            kust_btn.UseVisualStyleBackColor = true;
            kust_btn.Click += kust_btn_Click;
            // 
            // mehaanik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 508);
            Controls.Add(kust_btn);
            Controls.Add(uuenda_btn);
            Controls.Add(koik_btn);
            Controls.Add(lisa_btn);
            Controls.Add(keel_com);
            Controls.Add(meh_data);
            Controls.Add(otsi_txt);
            Controls.Add(otsi_lbl);
            Controls.Add(phone_txt);
            Controls.Add(phone_lbl);
            Controls.Add(nimi_txt);
            Controls.Add(nimi_lbl);
            Controls.Add(meh_lbl);
            Name = "mehaanik";
            Text = "mehaanik";
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
        private ComboBox keel_com;
        private Button lisa_btn;
        private Button koik_btn;
        private Button uuenda_btn;
        private Button kust_btn;
    }
}