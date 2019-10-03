namespace Kalkulator
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
            this.model = new System.Windows.Forms.ComboBox();
            this.cekHasil = new System.Windows.Forms.Button();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstHasil = new System.Windows.Forms.ListBox();
            this.iki = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan"});
            this.model.Location = new System.Drawing.Point(135, 71);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(121, 21);
            this.model.TabIndex = 0;
            // 
            // cekHasil
            // 
            this.cekHasil.Location = new System.Drawing.Point(383, 71);
            this.cekHasil.Name = "cekHasil";
            this.cekHasil.Size = new System.Drawing.Size(185, 112);
            this.cekHasil.TabIndex = 1;
            this.cekHasil.Text = "Hitung";
            this.cekHasil.UseVisualStyleBackColor = true;
            this.cekHasil.Click += new System.EventHandler(this.cekHasil_Click);
            // 
            // NilaiA
            // 
            this.NilaiA.Location = new System.Drawing.Point(135, 125);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(100, 20);
            this.NilaiA.TabIndex = 3;
            // 
            // NilaiB
            // 
            this.NilaiB.Location = new System.Drawing.Point(135, 163);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(100, 20);
            this.NilaiB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // lstHasil
            // 
            this.lstHasil.FormattingEnabled = true;
            this.lstHasil.Location = new System.Drawing.Point(135, 198);
            this.lstHasil.Name = "lstHasil";
            this.lstHasil.Size = new System.Drawing.Size(100, 17);
            this.lstHasil.TabIndex = 5;
            // 
            // iki
            // 
            this.iki.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iki.Enabled = false;
            this.iki.ForeColor = System.Drawing.SystemColors.Desktop;
            this.iki.Location = new System.Drawing.Point(350, 215);
            this.iki.Name = "iki";
            this.iki.Size = new System.Drawing.Size(100, 20);
            this.iki.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iki);
            this.Controls.Add(this.lstHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.cekHasil);
            this.Controls.Add(this.model);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.Button cekHasil;
        private System.Windows.Forms.TextBox NilaiA;
        private System.Windows.Forms.TextBox NilaiB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstHasil;
        private System.Windows.Forms.TextBox iki;
    }
}

