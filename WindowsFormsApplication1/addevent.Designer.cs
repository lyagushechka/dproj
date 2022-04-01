namespace WindowsFormsApplication1
{
    partial class addevent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addevent));
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtevent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtfio = new System.Windows.Forms.TextBox();
            this.lblphon = new System.Windows.Forms.Label();
            this.gradientPanel1 = new WindowsFormsApplication1.GradientPanel();
            this.lbltime = new System.Windows.Forms.Label();
            this.mtxtphone = new System.Windows.Forms.MaskedTextBox();
            this.cmbtime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(239, 656);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(124, 46);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Отмена";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(91)))), ((int)(((byte)(106)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(369, 656);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(124, 46);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Добавить";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtdate.Location = new System.Drawing.Point(37, 103);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(142, 38);
            this.txtdate.TabIndex = 1;
            // 
            // txtevent
            // 
            this.txtevent.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtevent.Location = new System.Drawing.Point(37, 492);
            this.txtevent.Multiline = true;
            this.txtevent.Name = "txtevent";
            this.txtevent.Size = new System.Drawing.Size(382, 91);
            this.txtevent.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дата:";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblevent.Location = new System.Drawing.Point(31, 458);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(172, 31);
            this.lblevent.TabIndex = 54;
            this.lblevent.Text = "Обследование:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblname.Location = new System.Drawing.Point(31, 261);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(70, 31);
            this.lblname.TabIndex = 56;
            this.lblname.Text = "ФИО:";
            // 
            // txtfio
            // 
            this.txtfio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtfio.Location = new System.Drawing.Point(37, 306);
            this.txtfio.Multiline = true;
            this.txtfio.Name = "txtfio";
            this.txtfio.Size = new System.Drawing.Size(382, 35);
            this.txtfio.TabIndex = 3;
            // 
            // lblphon
            // 
            this.lblphon.AutoSize = true;
            this.lblphon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblphon.Location = new System.Drawing.Point(31, 358);
            this.lblphon.Name = "lblphon";
            this.lblphon.Size = new System.Drawing.Size(109, 31);
            this.lblphon.TabIndex = 56;
            this.lblphon.Text = "Телефон:";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(165)))), ((int)(((byte)(214)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(505, 42);
            this.gradientPanel1.TabIndex = 9;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltime.Location = new System.Drawing.Point(31, 160);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(86, 31);
            this.lbltime.TabIndex = 54;
            this.lbltime.Text = "Время:";
            // 
            // mtxtphone
            // 
            this.mtxtphone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtxtphone.Location = new System.Drawing.Point(37, 392);
            this.mtxtphone.Mask = "+7(000)000-00-00";
            this.mtxtphone.Name = "mtxtphone";
            this.mtxtphone.Size = new System.Drawing.Size(258, 38);
            this.mtxtphone.TabIndex = 4;
            // 
            // cmbtime
            // 
            this.cmbtime.AutoCompleteCustomSource.AddRange(new string[] {
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00"});
            this.cmbtime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbtime.FormattingEnabled = true;
            this.cmbtime.Items.AddRange(new object[] {
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.cmbtime.Location = new System.Drawing.Point(37, 203);
            this.cmbtime.Name = "cmbtime";
            this.cmbtime.Size = new System.Drawing.Size(142, 39);
            this.cmbtime.TabIndex = 2;
            // 
            // addevent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(505, 714);
            this.Controls.Add(this.mtxtphone);
            this.Controls.Add(this.cmbtime);
            this.Controls.Add(this.lblphon);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtfio);
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtevent);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addevent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addevent";
            this.Load += new System.EventHandler(this.addevent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtevent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtfio;
        private System.Windows.Forms.Label lblphon;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.MaskedTextBox mtxtphone;
        private System.Windows.Forms.ComboBox cmbtime;
    }
}