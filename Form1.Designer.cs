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
            auto_page = new TabPage();
            hool_teen_page = new TabPage();
            omanik_data = new DataGridView();
            kust_omanik_btn = new Button();
            lisa_omanik_btn = new Button();
            label1 = new Label();
            tab_control.SuspendLayout();
            omanik_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)omanik_data).BeginInit();
            SuspendLayout();
            // 
            // tab_control
            // 
            tab_control.Controls.Add(omanik_page);
            tab_control.Controls.Add(auto_page);
            tab_control.Controls.Add(hool_teen_page);
            tab_control.Location = new Point(10, 12);
            tab_control.Name = "tab_control";
            tab_control.SelectedIndex = 0;
            tab_control.Size = new Size(778, 440);
            tab_control.TabIndex = 0;
            // 
            // omanik_page
            // 
            omanik_page.Controls.Add(label1);
            omanik_page.Controls.Add(lisa_omanik_btn);
            omanik_page.Controls.Add(kust_omanik_btn);
            omanik_page.Controls.Add(omanik_data);
            omanik_page.Location = new Point(4, 24);
            omanik_page.Name = "omanik_page";
            omanik_page.Padding = new Padding(3);
            omanik_page.Size = new Size(770, 412);
            omanik_page.TabIndex = 0;
            omanik_page.Text = "Omanikud";
            omanik_page.UseVisualStyleBackColor = true;
            // 
            // auto_page
            // 
            auto_page.Location = new Point(4, 24);
            auto_page.Name = "auto_page";
            auto_page.Padding = new Padding(3);
            auto_page.Size = new Size(770, 412);
            auto_page.TabIndex = 1;
            auto_page.Text = "Autod";
            auto_page.UseVisualStyleBackColor = true;
            // 
            // hool_teen_page
            // 
            hool_teen_page.Location = new Point(4, 24);
            hool_teen_page.Name = "hool_teen_page";
            hool_teen_page.Padding = new Padding(3);
            hool_teen_page.Size = new Size(707, 329);
            hool_teen_page.TabIndex = 2;
            hool_teen_page.Text = "Hooldus ja Teenused";
            hool_teen_page.UseVisualStyleBackColor = true;
            // 
            // omanik_data
            // 
            omanik_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            omanik_data.Location = new Point(12, 17);
            omanik_data.Name = "omanik_data";
            omanik_data.Size = new Size(439, 376);
            omanik_data.TabIndex = 0;
            // 
            // kust_omanik_btn
            // 
            kust_omanik_btn.Location = new Point(634, 320);
            kust_omanik_btn.Name = "kust_omanik_btn";
            kust_omanik_btn.Size = new Size(107, 44);
            kust_omanik_btn.TabIndex = 1;
            kust_omanik_btn.Text = "Kustuta";
            kust_omanik_btn.UseVisualStyleBackColor = true;
            // 
            // lisa_omanik_btn
            // 
            lisa_omanik_btn.Location = new Point(502, 320);
            lisa_omanik_btn.Name = "lisa_omanik_btn";
            lisa_omanik_btn.Size = new Size(107, 44);
            lisa_omanik_btn.TabIndex = 2;
            lisa_omanik_btn.Text = "Lisa";
            lisa_omanik_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(496, 27);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 468);
            Controls.Add(tab_control);
            Name = "Form1";
            Text = "Form1";
            tab_control.ResumeLayout(false);
            omanik_page.ResumeLayout(false);
            omanik_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)omanik_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab_control;
        private TabPage omanik_page;
        private TabPage auto_page;
        private TabPage hool_teen_page;
        private Button lisa_omanik_btn;
        private Button kust_omanik_btn;
        private DataGridView omanik_data;
        private Label label1;
    }
}
