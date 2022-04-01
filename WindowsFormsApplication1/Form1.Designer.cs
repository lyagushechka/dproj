namespace WindowsFormsApplication1
{
    partial class Loginform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonvxod = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbparol = new System.Windows.Forms.TextBox();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new WindowsFormsApplication1.GradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonvxod);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbparol);
            this.panel1.Controls.Add(this.tblogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 477);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.label2.Location = new System.Drawing.Point(415, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вход";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(135)))), ((int)(((byte)(157)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Medrt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(135)))), ((int)(((byte)(157)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 191;
            this.iconPictureBox1.Location = new System.Drawing.Point(369, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(191, 207);
            this.iconPictureBox1.TabIndex = 51;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(364, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 57;
            // 
            // buttonvxod
            // 
            this.buttonvxod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonvxod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.buttonvxod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonvxod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonvxod.ForeColor = System.Drawing.Color.White;
            this.buttonvxod.Location = new System.Drawing.Point(402, 396);
            this.buttonvxod.Name = "buttonvxod";
            this.buttonvxod.Size = new System.Drawing.Size(139, 50);
            this.buttonvxod.TabIndex = 2;
            this.buttonvxod.Text = "Вход";
            this.buttonvxod.UseVisualStyleBackColor = false;
            this.buttonvxod.Click += new System.EventHandler(this.buttonvxod_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.label5.Location = new System.Drawing.Point(278, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.label6.Location = new System.Drawing.Point(283, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 54;
            this.label6.Text = "Логин";
            // 
            // tbparol
            // 
            this.tbparol.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbparol.Location = new System.Drawing.Point(369, 294);
            this.tbparol.Margin = new System.Windows.Forms.Padding(4);
            this.tbparol.Name = "tbparol";
            this.tbparol.Size = new System.Drawing.Size(228, 38);
            this.tbparol.TabIndex = 1;
            this.tbparol.UseSystemPasswordChar = true;
            // 
            // tblogin
            // 
            this.tblogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblogin.Location = new System.Drawing.Point(369, 237);
            this.tblogin.Margin = new System.Windows.Forms.Padding(4);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(228, 38);
            this.tblogin.TabIndex = 0;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.Minimize);
            this.gradientPanel1.Controls.Add(this.iconButton3);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(943, 60);
            this.gradientPanel1.TabIndex = 8;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(179, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(532, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "MedCenter Регистратура глазной микрохирургии";
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Minimize.IconColor = System.Drawing.Color.White;
            this.Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Minimize.IconSize = 25;
            this.Minimize.Location = new System.Drawing.Point(822, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.Minimize.Size = new System.Drawing.Size(60, 36);
            this.Minimize.TabIndex = 0;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(141)))), ((int)(((byte)(131)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(883, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(60, 36);
            this.iconButton3.TabIndex = 0;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GradientPanel gradientPanel1;
        private FontAwesome.Sharp.IconButton Minimize;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonvxod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbparol;
        private System.Windows.Forms.TextBox tblogin;
    }
}

