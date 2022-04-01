namespace WindowsFormsApplication1
{
    partial class calendar
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnback = new FontAwesome.Sharp.IconButton();
            this.btnext = new FontAwesome.Sharp.IconButton();
            this.lblDATE = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.AutoScroll = true;
            this.daycontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.daycontainer.Location = new System.Drawing.Point(2, 174);
            this.daycontainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1656, 736);
            this.daycontainer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Понедельник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(300, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вторник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(546, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Среда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(791, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Четверг";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1010, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пятница";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1253, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Суббота";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1472, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Воскресенье";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.btnback);
            this.panel8.Controls.Add(this.btnext);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.lblDATE);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1658, 176);
            this.panel8.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnback.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnback.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnback.IconSize = 50;
            this.btnback.Location = new System.Drawing.Point(1496, 31);
            this.btnback.Name = "btnback";
            this.btnback.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnback.Size = new System.Drawing.Size(54, 50);
            this.btnback.TabIndex = 5;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(193)))), ((int)(((byte)(205)))));
            this.btnext.FlatAppearance.BorderSize = 0;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnext.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnext.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnext.IconSize = 50;
            this.btnext.Location = new System.Drawing.Point(1556, 31);
            this.btnext.Name = "btnext";
            this.btnext.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnext.Size = new System.Drawing.Size(54, 50);
            this.btnext.TabIndex = 5;
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // lblDATE
            // 
            this.lblDATE.AutoSize = true;
            this.lblDATE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDATE.Location = new System.Drawing.Point(699, 30);
            this.lblDATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDATE.Name = "lblDATE";
            this.lblDATE.Size = new System.Drawing.Size(171, 41);
            this.lblDATE.TabIndex = 4;
            this.lblDATE.Text = "Месяц, Год";
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1658, 833);
            this.Controls.Add(this.daycontainer);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "calendar";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.calendar_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton btnback;
        private FontAwesome.Sharp.IconButton btnext;
        private System.Windows.Forms.Label lblDATE;
    }
}