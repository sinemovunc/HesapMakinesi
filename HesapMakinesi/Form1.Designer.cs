namespace HesapMakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam1_Button = new System.Windows.Forms.Button();
            this.rakam2_Button = new System.Windows.Forms.Button();
            this.rakam3_Button = new System.Windows.Forms.Button();
            this.rakam6_Button = new System.Windows.Forms.Button();
            this.rakam5_Button = new System.Windows.Forms.Button();
            this.rakam4_Button = new System.Windows.Forms.Button();
            this.rakam9_Button = new System.Windows.Forms.Button();
            this.rakam8_Button = new System.Windows.Forms.Button();
            this.rakam7_Button = new System.Windows.Forms.Button();
            this.result_Button = new System.Windows.Forms.Button();
            this.rakam0_Button = new System.Windows.Forms.Button();
            this.CE_Button = new System.Windows.Forms.Button();
            this.division_Button = new System.Windows.Forms.Button();
            this.multiplation_Button = new System.Windows.Forms.Button();
            this.decal_Button = new System.Windows.Forms.Button();
            this.plus_Button = new System.Windows.Forms.Button();
            this.C_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sonuc_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BackColor = System.Drawing.Color.White;
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(25, 39);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(399, 76);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekranLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rakam1_Button
            // 
            this.rakam1_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam1_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1_Button.Location = new System.Drawing.Point(25, 132);
            this.rakam1_Button.Name = "rakam1_Button";
            this.rakam1_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam1_Button.TabIndex = 1;
            this.rakam1_Button.Text = "1";
            this.rakam1_Button.UseVisualStyleBackColor = false;
            this.rakam1_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // rakam2_Button
            // 
            this.rakam2_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam2_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2_Button.Location = new System.Drawing.Point(106, 132);
            this.rakam2_Button.Name = "rakam2_Button";
            this.rakam2_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam2_Button.TabIndex = 2;
            this.rakam2_Button.Text = "2";
            this.rakam2_Button.UseVisualStyleBackColor = false;
            this.rakam2_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // rakam3_Button
            // 
            this.rakam3_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam3_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3_Button.Location = new System.Drawing.Point(187, 132);
            this.rakam3_Button.Name = "rakam3_Button";
            this.rakam3_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam3_Button.TabIndex = 3;
            this.rakam3_Button.Text = "3";
            this.rakam3_Button.UseVisualStyleBackColor = false;
            this.rakam3_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // rakam6_Button
            // 
            this.rakam6_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam6_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6_Button.Location = new System.Drawing.Point(187, 213);
            this.rakam6_Button.Name = "rakam6_Button";
            this.rakam6_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam6_Button.TabIndex = 6;
            this.rakam6_Button.Text = "6";
            this.rakam6_Button.UseVisualStyleBackColor = false;
            this.rakam6_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // rakam5_Button
            // 
            this.rakam5_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam5_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5_Button.Location = new System.Drawing.Point(106, 213);
            this.rakam5_Button.Name = "rakam5_Button";
            this.rakam5_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam5_Button.TabIndex = 5;
            this.rakam5_Button.Text = "5";
            this.rakam5_Button.UseVisualStyleBackColor = false;
            this.rakam5_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // rakam4_Button
            // 
            this.rakam4_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam4_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4_Button.Location = new System.Drawing.Point(25, 213);
            this.rakam4_Button.Name = "rakam4_Button";
            this.rakam4_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam4_Button.TabIndex = 4;
            this.rakam4_Button.Text = "4";
            this.rakam4_Button.UseVisualStyleBackColor = false;
            this.rakam4_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // rakam9_Button
            // 
            this.rakam9_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam9_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9_Button.Location = new System.Drawing.Point(187, 294);
            this.rakam9_Button.Name = "rakam9_Button";
            this.rakam9_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam9_Button.TabIndex = 9;
            this.rakam9_Button.Text = "9";
            this.rakam9_Button.UseVisualStyleBackColor = false;
            this.rakam9_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // rakam8_Button
            // 
            this.rakam8_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam8_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8_Button.Location = new System.Drawing.Point(106, 294);
            this.rakam8_Button.Name = "rakam8_Button";
            this.rakam8_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam8_Button.TabIndex = 8;
            this.rakam8_Button.Text = "8";
            this.rakam8_Button.UseVisualStyleBackColor = false;
            this.rakam8_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // rakam7_Button
            // 
            this.rakam7_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam7_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7_Button.Location = new System.Drawing.Point(25, 294);
            this.rakam7_Button.Name = "rakam7_Button";
            this.rakam7_Button.Size = new System.Drawing.Size(75, 75);
            this.rakam7_Button.TabIndex = 7;
            this.rakam7_Button.Text = "7";
            this.rakam7_Button.UseVisualStyleBackColor = false;
            this.rakam7_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // result_Button
            // 
            this.result_Button.BackColor = System.Drawing.Color.Bisque;
            this.result_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.result_Button.Location = new System.Drawing.Point(349, 294);
            this.result_Button.Name = "result_Button";
            this.result_Button.Size = new System.Drawing.Size(75, 156);
            this.result_Button.TabIndex = 12;
            this.result_Button.Text = "=";
            this.result_Button.UseVisualStyleBackColor = false;
            this.result_Button.Click += new System.EventHandler(this.result_Button_Click);
            // 
            // rakam0_Button
            // 
            this.rakam0_Button.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rakam0_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0_Button.Location = new System.Drawing.Point(25, 375);
            this.rakam0_Button.Name = "rakam0_Button";
            this.rakam0_Button.Size = new System.Drawing.Size(156, 75);
            this.rakam0_Button.TabIndex = 11;
            this.rakam0_Button.Text = "0";
            this.rakam0_Button.UseVisualStyleBackColor = false;
            this.rakam0_Button.Click += new System.EventHandler(this.RakamOlay);
            // 
            // CE_Button
            // 
            this.CE_Button.BackColor = System.Drawing.Color.Red;
            this.CE_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CE_Button.ForeColor = System.Drawing.Color.GhostWhite;
            this.CE_Button.Location = new System.Drawing.Point(349, 132);
            this.CE_Button.Name = "CE_Button";
            this.CE_Button.Size = new System.Drawing.Size(75, 75);
            this.CE_Button.TabIndex = 10;
            this.CE_Button.Text = "CE";
            this.CE_Button.UseVisualStyleBackColor = false;
            this.CE_Button.Click += new System.EventHandler(this.CE_Button_Click);
            // 
            // division_Button
            // 
            this.division_Button.BackColor = System.Drawing.Color.Pink;
            this.division_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.division_Button.Location = new System.Drawing.Point(268, 375);
            this.division_Button.Name = "division_Button";
            this.division_Button.Size = new System.Drawing.Size(75, 75);
            this.division_Button.TabIndex = 16;
            this.division_Button.Text = "/";
            this.division_Button.UseVisualStyleBackColor = false;
            this.division_Button.Click += new System.EventHandler(this.OptIslem);
            // 
            // multiplation_Button
            // 
            this.multiplation_Button.BackColor = System.Drawing.Color.Pink;
            this.multiplation_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.multiplation_Button.Location = new System.Drawing.Point(268, 294);
            this.multiplation_Button.Name = "multiplation_Button";
            this.multiplation_Button.Size = new System.Drawing.Size(75, 75);
            this.multiplation_Button.TabIndex = 15;
            this.multiplation_Button.Text = "x";
            this.multiplation_Button.UseVisualStyleBackColor = false;
            this.multiplation_Button.Click += new System.EventHandler(this.OptIslem);
            // 
            // decal_Button
            // 
            this.decal_Button.BackColor = System.Drawing.Color.Pink;
            this.decal_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.decal_Button.Location = new System.Drawing.Point(268, 213);
            this.decal_Button.Name = "decal_Button";
            this.decal_Button.Size = new System.Drawing.Size(75, 75);
            this.decal_Button.TabIndex = 14;
            this.decal_Button.Text = "-";
            this.decal_Button.UseVisualStyleBackColor = false;
            this.decal_Button.Click += new System.EventHandler(this.OptIslem);
            // 
            // plus_Button
            // 
            this.plus_Button.BackColor = System.Drawing.Color.Pink;
            this.plus_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plus_Button.Location = new System.Drawing.Point(268, 132);
            this.plus_Button.Name = "plus_Button";
            this.plus_Button.Size = new System.Drawing.Size(75, 75);
            this.plus_Button.TabIndex = 13;
            this.plus_Button.Text = "+";
            this.plus_Button.UseVisualStyleBackColor = false;
            this.plus_Button.Click += new System.EventHandler(this.OptIslem);
            // 
            // C_Button
            // 
            this.C_Button.BackColor = System.Drawing.Color.Red;
            this.C_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C_Button.ForeColor = System.Drawing.Color.GhostWhite;
            this.C_Button.Location = new System.Drawing.Point(349, 213);
            this.C_Button.Name = "C_Button";
            this.C_Button.Size = new System.Drawing.Size(75, 75);
            this.C_Button.TabIndex = 17;
            this.C_Button.Text = "C";
            this.C_Button.UseVisualStyleBackColor = false;
            this.C_Button.Click += new System.EventHandler(this.C_Button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(187, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 18;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sonuc_Label
            // 
            this.sonuc_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sonuc_Label.Location = new System.Drawing.Point(25, 15);
            this.sonuc_Label.Name = "sonuc_Label";
            this.sonuc_Label.Size = new System.Drawing.Size(399, 24);
            this.sonuc_Label.TabIndex = 19;
            this.sonuc_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sonuc_Label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 466);
            this.Controls.Add(this.sonuc_Label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.C_Button);
            this.Controls.Add(this.division_Button);
            this.Controls.Add(this.multiplation_Button);
            this.Controls.Add(this.decal_Button);
            this.Controls.Add(this.plus_Button);
            this.Controls.Add(this.result_Button);
            this.Controls.Add(this.rakam0_Button);
            this.Controls.Add(this.CE_Button);
            this.Controls.Add(this.rakam9_Button);
            this.Controls.Add(this.rakam8_Button);
            this.Controls.Add(this.rakam7_Button);
            this.Controls.Add(this.rakam6_Button);
            this.Controls.Add(this.rakam5_Button);
            this.Controls.Add(this.rakam4_Button);
            this.Controls.Add(this.rakam3_Button);
            this.Controls.Add(this.rakam2_Button);
            this.Controls.Add(this.rakam1_Button);
            this.Controls.Add(this.ekranLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "HESAP MAKİNESİ";
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam1_Button;
        private System.Windows.Forms.Button rakam2_Button;
        private System.Windows.Forms.Button rakam3_Button;
        private System.Windows.Forms.Button rakam6_Button;
        private System.Windows.Forms.Button rakam5_Button;
        private System.Windows.Forms.Button rakam4_Button;
        private System.Windows.Forms.Button rakam9_Button;
        private System.Windows.Forms.Button rakam8_Button;
        private System.Windows.Forms.Button rakam7_Button;
        private System.Windows.Forms.Button result_Button;
        private System.Windows.Forms.Button rakam0_Button;
        private System.Windows.Forms.Button CE_Button;
        private System.Windows.Forms.Button division_Button;
        private System.Windows.Forms.Button multiplation_Button;
        private System.Windows.Forms.Button decal_Button;
        private System.Windows.Forms.Button plus_Button;
        private System.Windows.Forms.Button C_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label sonuc_Label;
    }
}

