namespace WindowsFormsApplication1
{
    partial class addsotrudnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addsotrudnik));
            this.gradientPanel1 = new WindowsFormsApplication1.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.exitoknosave = new FontAwesome.Sharp.IconButton();
            this.pnladdsotr = new System.Windows.Forms.Panel();
            this.mtxtphone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxotche = new System.Windows.Forms.TextBox();
            this.textBoxfamil = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnladdsotr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.iconPictureBox1);
            this.gradientPanel1.Controls.Add(this.exitoknosave);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(599, 60);
            this.gradientPanel1.TabIndex = 5;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.label2.Size = new System.Drawing.Size(155, 49);
            this.label2.TabIndex = 55;
            this.label2.Text = "MedCenter";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Medrt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(66, 60);
            this.iconPictureBox1.TabIndex = 54;
            this.iconPictureBox1.TabStop = false;
            // 
            // exitoknosave
            // 
            this.exitoknosave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitoknosave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(141)))), ((int)(((byte)(131)))));
            this.exitoknosave.FlatAppearance.BorderSize = 0;
            this.exitoknosave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitoknosave.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exitoknosave.IconColor = System.Drawing.Color.White;
            this.exitoknosave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitoknosave.IconSize = 25;
            this.exitoknosave.Location = new System.Drawing.Point(539, 0);
            this.exitoknosave.Name = "exitoknosave";
            this.exitoknosave.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.exitoknosave.Size = new System.Drawing.Size(60, 36);
            this.exitoknosave.TabIndex = 1;
            this.exitoknosave.UseVisualStyleBackColor = false;
            this.exitoknosave.Click += new System.EventHandler(this.exitoknosave_Click);
            // 
            // pnladdsotr
            // 
            this.pnladdsotr.Controls.Add(this.mtxtphone);
            this.pnladdsotr.Controls.Add(this.label6);
            this.pnladdsotr.Controls.Add(this.label9);
            this.pnladdsotr.Controls.Add(this.label4);
            this.pnladdsotr.Controls.Add(this.textBoxotche);
            this.pnladdsotr.Controls.Add(this.textBoxfamil);
            this.pnladdsotr.Controls.Add(this.textBoxname);
            this.pnladdsotr.Controls.Add(this.label1);
            this.pnladdsotr.Controls.Add(this.button_add);
            this.pnladdsotr.Controls.Add(this.button_clear);
            this.pnladdsotr.Controls.Add(this.label3);
            this.pnladdsotr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnladdsotr.Location = new System.Drawing.Point(0, 60);
            this.pnladdsotr.Name = "pnladdsotr";
            this.pnladdsotr.Size = new System.Drawing.Size(599, 517);
            this.pnladdsotr.TabIndex = 6;
            // 
            // mtxtphone
            // 
            this.mtxtphone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtxtphone.Location = new System.Drawing.Point(261, 313);
            this.mtxtphone.Mask = "+7(000)000-00-00";
            this.mtxtphone.Name = "mtxtphone";
            this.mtxtphone.Size = new System.Drawing.Size(203, 34);
            this.mtxtphone.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.label6.Location = new System.Drawing.Point(58, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 23);
            this.label6.TabIndex = 115;
            this.label6.Text = "Номер телефона:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.label9.Location = new System.Drawing.Point(70, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 113;
            this.label9.Text = "Отчество: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.label4.Location = new System.Drawing.Point(81, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 114;
            this.label4.Text = "Фамилия: ";
            // 
            // textBoxotche
            // 
            this.textBoxotche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxotche.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxotche.Location = new System.Drawing.Point(209, 221);
            this.textBoxotche.Multiline = true;
            this.textBoxotche.Name = "textBoxotche";
            this.textBoxotche.Size = new System.Drawing.Size(255, 32);
            this.textBoxotche.TabIndex = 107;
            // 
            // textBoxfamil
            // 
            this.textBoxfamil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxfamil.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.textBoxfamil.Location = new System.Drawing.Point(209, 164);
            this.textBoxfamil.Multiline = true;
            this.textBoxfamil.Name = "textBoxfamil";
            this.textBoxfamil.Size = new System.Drawing.Size(255, 32);
            this.textBoxfamil.TabIndex = 106;
            // 
            // textBoxname
            // 
            this.textBoxname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxname.Location = new System.Drawing.Point(209, 102);
            this.textBoxname.Multiline = true;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(255, 32);
            this.textBoxname.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(126, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 112;
            this.label1.Text = "Имя: ";
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(449, 451);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(131, 39);
            this.button_add.TabIndex = 109;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(325, 451);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 110;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 28);
            this.label3.TabIndex = 111;
            this.label3.Text = "   Добавить сотрудника";
            // 
            // addsotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 577);
            this.Controls.Add(this.pnladdsotr);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addsotrudnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addsotrudnik";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnladdsotr.ResumeLayout(false);
            this.pnladdsotr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private FontAwesome.Sharp.IconButton exitoknosave;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.Panel pnladdsotr;
        private System.Windows.Forms.MaskedTextBox mtxtphone;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxotche;
        private System.Windows.Forms.TextBox textBoxfamil;
        private System.Windows.Forms.TextBox textBoxname;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_add;
        public System.Windows.Forms.Button button_clear;
        public System.Windows.Forms.Label label3;

    }
}