namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pendidikan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pekerjaan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(98, 33);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(396, 26);
            this.txtNama.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt1.Location = new System.Drawing.Point(16, 301);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(478, 26);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt2.Location = new System.Drawing.Point(16, 342);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(478, 26);
            this.txt2.TabIndex = 5;
            // 
            // txt3
            // 
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt3.Location = new System.Drawing.Point(16, 389);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(478, 26);
            this.txt3.TabIndex = 6;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(98, 80);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(396, 30);
            this.cmbPendidikan.TabIndex = 7;
            this.cmbPendidikan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPekerjaan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.ItemHeight = 23;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(98, 135);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(396, 140);
            this.lstPekerjaan.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Location = new System.Drawing.Point(12, 432);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(482, 33);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(506, 473);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstPekerjaan);
            this.Controls.Add(this.cmbPendidikan);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tugas 3.2 (Desain Menggunakan Komponen Layout)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.Button btnOK;
    }
}

