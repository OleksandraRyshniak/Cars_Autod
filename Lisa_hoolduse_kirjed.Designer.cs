namespace Cars
{
    partial class Lisa_hoolduse_kirjed
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
            textBox3 = new TextBox();
            auto_lbl = new Label();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            mileeg_lbl = new Label();
            label3 = new Label();
            teenus_lbl = new Label();
            hooldus_kir_lbl = new Label();
            lisa_btn = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 24;
            // 
            // auto_lbl
            // 
            auto_lbl.AutoSize = true;
            auto_lbl.Location = new Point(57, 168);
            auto_lbl.Name = "auto_lbl";
            auto_lbl.Size = new Size(33, 15);
            auto_lbl.TabIndex = 23;
            auto_lbl.Text = "Auto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(112, 262);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 22;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(111, 165);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(111, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 20;
            // 
            // mileeg_lbl
            // 
            mileeg_lbl.AutoSize = true;
            mileeg_lbl.Location = new Point(57, 265);
            mileeg_lbl.Name = "mileeg_lbl";
            mileeg_lbl.Size = new Size(49, 15);
            mileeg_lbl.TabIndex = 19;
            mileeg_lbl.Text = "Mileage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 230);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 18;
            label3.Text = "Teenuse kuupäev";
            // 
            // teenus_lbl
            // 
            teenus_lbl.AutoSize = true;
            teenus_lbl.Location = new Point(57, 194);
            teenus_lbl.Name = "teenus_lbl";
            teenus_lbl.Size = new Size(44, 15);
            teenus_lbl.TabIndex = 17;
            teenus_lbl.Text = "Teenus";
            // 
            // hooldus_kir_lbl
            // 
            hooldus_kir_lbl.AutoSize = true;
            hooldus_kir_lbl.Location = new Point(126, 62);
            hooldus_kir_lbl.Name = "hooldus_kir_lbl";
            hooldus_kir_lbl.Size = new Size(90, 15);
            hooldus_kir_lbl.TabIndex = 25;
            hooldus_kir_lbl.Text = "Hoolduse kirjed";
            // 
            // lisa_btn
            // 
            lisa_btn.Location = new Point(109, 335);
            lisa_btn.Name = "lisa_btn";
            lisa_btn.Size = new Size(107, 44);
            lisa_btn.TabIndex = 26;
            lisa_btn.Text = "Lisa";
            lisa_btn.UseVisualStyleBackColor = true;
            // 
            // Lisa_hoolduse_kirjed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 450);
            Controls.Add(lisa_btn);
            Controls.Add(hooldus_kir_lbl);
            Controls.Add(textBox3);
            Controls.Add(auto_lbl);
            Controls.Add(textBox2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(mileeg_lbl);
            Controls.Add(label3);
            Controls.Add(teenus_lbl);
            Name = "Lisa_hoolduse_kirjed";
            Text = "Lisa_hoolduse_kirjed";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label auto_lbl;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private Label mileeg_lbl;
        private Label label3;
        private Label teenus_lbl;
        private Label hooldus_kir_lbl;
        private Button lisa_btn;
    }
}