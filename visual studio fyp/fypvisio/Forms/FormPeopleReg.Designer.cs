
namespace ISMSF.Forms
{
    partial class FormPeopleReg
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
            this.label1 = new System.Windows.Forms.Label();
            this.pid = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.Label();
            this.pemail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.idpr = new System.Windows.Forms.TextBox();
            this.namepr = new System.Windows.Forms.TextBox();
            this.emailpr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "People Registration";
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pid.Location = new System.Drawing.Point(35, 135);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(31, 21);
            this.pid.TabIndex = 1;
            this.pid.Text = "ID ";
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pname.Location = new System.Drawing.Point(35, 180);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(56, 21);
            this.pname.TabIndex = 2;
            this.pname.Text = "Name";
            // 
            // pemail
            // 
            this.pemail.AutoSize = true;
            this.pemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pemail.Location = new System.Drawing.Point(35, 228);
            this.pemail.Name = "pemail";
            this.pemail.Size = new System.Drawing.Size(57, 21);
            this.pemail.TabIndex = 3;
            this.pemail.Text = "E Mail";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(260, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idpr
            // 
            this.idpr.Location = new System.Drawing.Point(144, 137);
            this.idpr.Name = "idpr";
            this.idpr.Size = new System.Drawing.Size(313, 23);
            this.idpr.TabIndex = 6;
            // 
            // namepr
            // 
            this.namepr.Location = new System.Drawing.Point(144, 182);
            this.namepr.Name = "namepr";
            this.namepr.Size = new System.Drawing.Size(313, 23);
            this.namepr.TabIndex = 7;
            // 
            // emailpr
            // 
            this.emailpr.Location = new System.Drawing.Point(144, 230);
            this.emailpr.Name = "emailpr";
            this.emailpr.Size = new System.Drawing.Size(313, 23);
            this.emailpr.TabIndex = 8;
            // 
            // FormPeopleReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 376);
            this.Controls.Add(this.emailpr);
            this.Controls.Add(this.namepr);
            this.Controls.Add(this.idpr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pemail);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.pid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPeopleReg";
            this.Text = "FormPeopleReg";
            this.Load += new System.EventHandler(this.FormPeopleReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label pemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idpr;
        private System.Windows.Forms.TextBox namepr;
        private System.Windows.Forms.TextBox emailpr;
    }
}