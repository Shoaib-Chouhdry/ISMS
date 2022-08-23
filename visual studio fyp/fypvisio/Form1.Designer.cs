
namespace ISMSF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblhome = new System.Windows.Forms.Label();
            this.paneldesktop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldesktop
            // 
            this.paneldesktop.Controls.Add(this.panel2);
            this.paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktop.Location = new System.Drawing.Point(0, 83);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(847, 414);
            this.paneldesktop.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Login);
            this.panel2.Controls.Add(this.btnadmin);
            this.panel2.Location = new System.Drawing.Point(247, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 352);
            this.panel2.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(136, 163);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(166, 23);
            this.password.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password   :";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(136, 104);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(166, 23);
            this.username.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name :";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login.Location = new System.Drawing.Point(136, 242);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(152, 45);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadmin.FlatAppearance.BorderSize = 0;
            this.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnadmin.Image = ((System.Drawing.Image)(resources.GetObject("btnadmin.Image")));
            this.btnadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.Location = new System.Drawing.Point(126, 0);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnadmin.Size = new System.Drawing.Size(176, 85);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "   Admin";
            this.btnadmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.lblhome);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(847, 83);
            this.panelTitleBar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 73);
            this.panel1.TabIndex = 1;
            // 
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblhome.ForeColor = System.Drawing.Color.White;
            this.lblhome.Location = new System.Drawing.Point(155, 32);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(624, 35);
            this.lblhome.TabIndex = 0;
            this.lblhome.Text = "Information Security Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 497);
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paneldesktop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldesktop;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
    }
}

