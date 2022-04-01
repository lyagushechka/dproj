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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panellogo = new System.Windows.Forms.Panel();
            this.settingmenu = new FontAwesome.Sharp.IconButton();
            this.sotrudnikmenu = new FontAwesome.Sharp.IconButton();
            this.pacientmenu = new FontAwesome.Sharp.IconButton();
            this.calendarmenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelmenu.Controls.Add(this.settingmenu);
            this.panelmenu.Controls.Add(this.sotrudnikmenu);
            this.panelmenu.Controls.Add(this.pacientmenu);
            this.panelmenu.Controls.Add(this.calendarmenu);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 782);
            this.panelmenu.TabIndex = 0;
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.pictureBox1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(220, 100);
            this.panellogo.TabIndex = 0;
            // 
            // settingmenu
            // 
            this.settingmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingmenu.FlatAppearance.BorderSize = 0;
            this.settingmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingmenu.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingmenu.IconColor = System.Drawing.SystemColors.HotTrack;
            this.settingmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingmenu.Location = new System.Drawing.Point(0, 310);
            this.settingmenu.Name = "settingmenu";
            this.settingmenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.settingmenu.Size = new System.Drawing.Size(220, 70);
            this.settingmenu.TabIndex = 4;
            this.settingmenu.Text = "Настройки";
            this.settingmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingmenu.UseVisualStyleBackColor = true;
            // 
            // sotrudnikmenu
            // 
            this.sotrudnikmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.sotrudnikmenu.FlatAppearance.BorderSize = 0;
            this.sotrudnikmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sotrudnikmenu.IconChar = FontAwesome.Sharp.IconChar.User;
            this.sotrudnikmenu.IconColor = System.Drawing.SystemColors.HotTrack;
            this.sotrudnikmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sotrudnikmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sotrudnikmenu.Location = new System.Drawing.Point(0, 240);
            this.sotrudnikmenu.Name = "sotrudnikmenu";
            this.sotrudnikmenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.sotrudnikmenu.Size = new System.Drawing.Size(220, 70);
            this.sotrudnikmenu.TabIndex = 3;
            this.sotrudnikmenu.Text = "Сотрудники";
            this.sotrudnikmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sotrudnikmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sotrudnikmenu.UseVisualStyleBackColor = true;
            // 
            // pacientmenu
            // 
            this.pacientmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacientmenu.FlatAppearance.BorderSize = 0;
            this.pacientmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacientmenu.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.pacientmenu.IconColor = System.Drawing.SystemColors.HotTrack;
            this.pacientmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pacientmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacientmenu.Location = new System.Drawing.Point(0, 170);
            this.pacientmenu.Name = "pacientmenu";
            this.pacientmenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.pacientmenu.Size = new System.Drawing.Size(220, 70);
            this.pacientmenu.TabIndex = 2;
            this.pacientmenu.Text = "Пациенты";
            this.pacientmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pacientmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pacientmenu.UseVisualStyleBackColor = true;
            this.pacientmenu.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // calendarmenu
            // 
            this.calendarmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarmenu.FlatAppearance.BorderSize = 0;
            this.calendarmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarmenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calendarmenu.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.calendarmenu.IconColor = System.Drawing.SystemColors.HotTrack;
            this.calendarmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.calendarmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarmenu.Location = new System.Drawing.Point(0, 100);
            this.calendarmenu.Name = "calendarmenu";
            this.calendarmenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.calendarmenu.Size = new System.Drawing.Size(220, 70);
            this.calendarmenu.TabIndex = 1;
            this.calendarmenu.Text = "Календарь";
            this.calendarmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.calendarmenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 782);
            this.Controls.Add(this.panelmenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 829);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f2";
            this.Load += new System.EventHandler(this.f2_Load);
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton settingmenu;
        private FontAwesome.Sharp.IconButton sotrudnikmenu;
        private FontAwesome.Sharp.IconButton calendarmenu;
        private System.Windows.Forms.Panel panellogo;
        private FontAwesome.Sharp.IconButton pacientmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}