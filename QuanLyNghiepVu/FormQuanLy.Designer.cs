namespace QuanLyNghiepVu
{
    partial class form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.photo_user = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_menu = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.photo_user);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 428);
            this.panel1.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(87, 32);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(106, 20);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Nhât Kim Anh";
            // 
            // photo_user
            // 
            this.photo_user.Image = ((System.Drawing.Image)(resources.GetObject("photo_user.Image")));
            this.photo_user.Location = new System.Drawing.Point(0, 10);
            this.photo_user.Name = "photo_user";
            this.photo_user.Size = new System.Drawing.Size(107, 57);
            this.photo_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo_user.TabIndex = 2;
            this.photo_user.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(296, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 425);
            this.panel2.TabIndex = 1;
            // 
            // btn_menu
            // 
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_menu.Location = new System.Drawing.Point(299, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 32);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 426);
            this.Controls.Add(this.panel1);
            this.Name = "form_main";
            this.Text = "Trình Quản Lí";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_menu;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox photo_user;
    }
}

