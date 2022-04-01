namespace WindowsFormsApplication1
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.settingmenu = new FontAwesome.Sharp.IconButton();
            this.sotrudnikmenu = new FontAwesome.Sharp.IconButton();
            this.pacientmenu = new FontAwesome.Sharp.IconButton();
            this.btntimetable = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.calendarmenu = new FontAwesome.Sharp.IconButton();
            this.panellogo = new WindowsFormsApplication1.GradientPanel();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.IblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new WindowsFormsApplication1.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Maxim = new FontAwesome.Sharp.IconButton();
            this.Minimize = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelmenu.Controls.Add(this.settingmenu);
            this.panelmenu.Controls.Add(this.sotrudnikmenu);
            this.panelmenu.Controls.Add(this.pacientmenu);
            this.panelmenu.Controls.Add(this.btntimetable);
            this.panelmenu.Controls.Add(this.iconButton1);
            this.panelmenu.Controls.Add(this.calendarmenu);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 55);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(250, 905);
            this.panelmenu.TabIndex = 0;
            // 
            // settingmenu
            // 
            this.settingmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingmenu.FlatAppearance.BorderSize = 0;
            this.settingmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingmenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingmenu.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingmenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.settingmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingmenu.IconSize = 65;
            this.settingmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingmenu.Location = new System.Drawing.Point(0, 562);
            this.settingmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingmenu.Name = "settingmenu";
            this.settingmenu.Padding = new System.Windows.Forms.Padding(11, 0, 21, 0);
            this.settingmenu.Size = new System.Drawing.Size(250, 98);
            this.settingmenu.TabIndex = 5;
            this.settingmenu.Text = "Настройки";
            this.settingmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingmenu.UseVisualStyleBackColor = true;
            this.settingmenu.Click += new System.EventHandler(this.settingmenu_Click);
            // 
            // sotrudnikmenu
            // 
            this.sotrudnikmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.sotrudnikmenu.FlatAppearance.BorderSize = 0;
            this.sotrudnikmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sotrudnikmenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotrudnikmenu.IconChar = FontAwesome.Sharp.IconChar.User;
            this.sotrudnikmenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.sotrudnikmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sotrudnikmenu.IconSize = 65;
            this.sotrudnikmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sotrudnikmenu.Location = new System.Drawing.Point(0, 464);
            this.sotrudnikmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sotrudnikmenu.Name = "sotrudnikmenu";
            this.sotrudnikmenu.Padding = new System.Windows.Forms.Padding(11, 0, 21, 0);
            this.sotrudnikmenu.Size = new System.Drawing.Size(250, 98);
            this.sotrudnikmenu.TabIndex = 4;
            this.sotrudnikmenu.Text = "Сотрудники";
            this.sotrudnikmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sotrudnikmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sotrudnikmenu.UseVisualStyleBackColor = true;
            this.sotrudnikmenu.Click += new System.EventHandler(this.sotrudnikmenu_Click);
            // 
            // pacientmenu
            // 
            this.pacientmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacientmenu.FlatAppearance.BorderSize = 0;
            this.pacientmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacientmenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacientmenu.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.pacientmenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.pacientmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pacientmenu.IconSize = 65;
            this.pacientmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacientmenu.Location = new System.Drawing.Point(0, 366);
            this.pacientmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pacientmenu.Name = "pacientmenu";
            this.pacientmenu.Padding = new System.Windows.Forms.Padding(11, 0, 21, 0);
            this.pacientmenu.Size = new System.Drawing.Size(250, 98);
            this.pacientmenu.TabIndex = 3;
            this.pacientmenu.Text = "Пациенты";
            this.pacientmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacientmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pacientmenu.UseVisualStyleBackColor = true;
            this.pacientmenu.Click += new System.EventHandler(this.pacientmenu_Click);
            // 
            // btntimetable
            // 
            this.btntimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntimetable.FlatAppearance.BorderSize = 0;
            this.btntimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntimetable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimetable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntimetable.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.btntimetable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btntimetable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntimetable.IconSize = 65;
            this.btntimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimetable.Location = new System.Drawing.Point(0, 284);
            this.btntimetable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntimetable.Name = "btntimetable";
            this.btntimetable.Padding = new System.Windows.Forms.Padding(11, 0, 21, 0);
            this.btntimetable.Size = new System.Drawing.Size(250, 82);
            this.btntimetable.TabIndex = 2;
            this.btntimetable.Text = "Расписание на неделю";
            this.btntimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimetable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntimetable.UseVisualStyleBackColor = true;
            this.btntimetable.Click += new System.EventHandler(this.btntimetable_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(176)))), ((int)(((byte)(191)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(135)))), ((int)(((byte)(157)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 80;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(0, 789);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(110, 116);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Справка";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // calendarmenu
            // 
            this.calendarmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarmenu.FlatAppearance.BorderSize = 0;
            this.calendarmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarmenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarmenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calendarmenu.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.calendarmenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.calendarmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.calendarmenu.IconSize = 65;
            this.calendarmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarmenu.Location = new System.Drawing.Point(0, 191);
            this.calendarmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calendarmenu.Name = "calendarmenu";
            this.calendarmenu.Padding = new System.Windows.Forms.Padding(11, 0, 21, 0);
            this.calendarmenu.Size = new System.Drawing.Size(250, 93);
            this.calendarmenu.TabIndex = 1;
            this.calendarmenu.Text = "Расписание на месяц";
            this.calendarmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calendarmenu.UseVisualStyleBackColor = true;
            this.calendarmenu.Click += new System.EventHandler(this.calendarmenu_Click);
            // 
            // panellogo
            // 
            this.panellogo.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.panellogo.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.panellogo.Controls.Add(this.IconCurrentChildForm);
            this.panellogo.Controls.Add(this.IblTitleChildForm);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(250, 191);
            this.panellogo.TabIndex = 0;
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.IconSize = 95;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(73, 26);
            this.IconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(95, 96);
            this.IconCurrentChildForm.TabIndex = 1;
            this.IconCurrentChildForm.TabStop = false;
            this.IconCurrentChildForm.Click += new System.EventHandler(this.IconCurrentChildForm_Click);
            // 
            // IblTitleChildForm
            // 
            this.IblTitleChildForm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IblTitleChildForm.AutoSize = true;
            this.IblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.IblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.IblTitleChildForm.Location = new System.Drawing.Point(68, 138);
            this.IblTitleChildForm.Name = "IblTitleChildForm";
            this.IblTitleChildForm.Size = new System.Drawing.Size(88, 28);
            this.IblTitleChildForm.TabIndex = 0;
            this.IblTitleChildForm.Text = "Кабинет";
            this.IblTitleChildForm.Click += new System.EventHandler(this.IblTitleChildForm_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(250, 55);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1253, 905);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.iconPictureBox1);
            this.gradientPanel1.Controls.Add(this.Maxim);
            this.gradientPanel1.Controls.Add(this.Minimize);
            this.gradientPanel1.Controls.Add(this.iconButton3);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1503, 55);
            this.gradientPanel1.TabIndex = 4;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.label1.Size = new System.Drawing.Size(155, 49);
            this.label1.TabIndex = 53;
            this.label1.Text = "MedCenter";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Medrt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(66, 55);
            this.iconPictureBox1.TabIndex = 52;
            this.iconPictureBox1.TabStop = false;
            // 
            // Maxim
            // 
            this.Maxim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maxim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(149)))), ((int)(((byte)(252)))));
            this.Maxim.FlatAppearance.BorderSize = 0;
            this.Maxim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maxim.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.Maxim.IconColor = System.Drawing.Color.White;
            this.Maxim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Maxim.IconSize = 25;
            this.Maxim.Location = new System.Drawing.Point(1382, 0);
            this.Maxim.Name = "Maxim";
            this.Maxim.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Maxim.Size = new System.Drawing.Size(60, 36);
            this.Maxim.TabIndex = 0;
            this.Maxim.UseVisualStyleBackColor = false;
            this.Maxim.Click += new System.EventHandler(this.Maxim_Click);
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
            this.Minimize.Location = new System.Drawing.Point(1321, 0);
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
            this.iconButton3.Location = new System.Drawing.Point(1443, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(60, 36);
            this.iconButton3.TabIndex = 0;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 960);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистратура";
            this.Load += new System.EventHandler(this.f2_Load);
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label IblTitleChildForm;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton calendarmenu;
        private GradientPanel panellogo;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton Maxim;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton Minimize;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton settingmenu;
        private FontAwesome.Sharp.IconButton sotrudnikmenu;
        private FontAwesome.Sharp.IconButton pacientmenu;
        private FontAwesome.Sharp.IconButton btntimetable;
    }
}