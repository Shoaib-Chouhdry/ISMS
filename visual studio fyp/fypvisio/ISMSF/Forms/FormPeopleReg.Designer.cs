
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
            this.components = new System.ComponentModel.Container();
            this.panelpr = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.emailpr = new System.Windows.Forms.TextBox();
            this.namepr = new System.Windows.Forms.TextBox();
            this.idpr = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelpr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelpr
            // 
            this.panelpr.Controls.Add(this.button3);
            this.panelpr.Controls.Add(this.emailpr);
            this.panelpr.Controls.Add(this.namepr);
            this.panelpr.Controls.Add(this.idpr);
            this.panelpr.Controls.Add(this.button4);
            this.panelpr.Controls.Add(this.label2);
            this.panelpr.Controls.Add(this.label3);
            this.panelpr.Controls.Add(this.label4);
            this.panelpr.Controls.Add(this.label5);
            this.panelpr.Location = new System.Drawing.Point(0, 0);
            this.panelpr.Name = "panelpr";
            this.panelpr.Size = new System.Drawing.Size(757, 432);
            this.panelpr.TabIndex = 10;
            this.panelpr.Paint += new System.Windows.Forms.PaintEventHandler(this.panelpr_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(461, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 34);
            this.button3.TabIndex = 18;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // emailpr
            // 
            this.emailpr.Location = new System.Drawing.Point(228, 227);
            this.emailpr.Name = "emailpr";
            this.emailpr.Size = new System.Drawing.Size(313, 23);
            this.emailpr.TabIndex = 17;
           
            // 
            // namepr
            // 
            this.namepr.Location = new System.Drawing.Point(228, 179);
            this.namepr.Name = "namepr";
            this.namepr.Size = new System.Drawing.Size(313, 23);
            this.namepr.TabIndex = 16;
            // 
            // idpr
            // 
            this.idpr.Location = new System.Drawing.Point(228, 134);
            this.idpr.Name = "idpr";
            this.idpr.Size = new System.Drawing.Size(313, 23);
            this.idpr.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(344, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 34);
            this.button4.TabIndex = 14;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "E Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(119, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(119, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(287, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "People Registration";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormPeopleReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 423);
            this.Controls.Add(this.panelpr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPeopleReg";
            this.Text = "FormPeopleReg";
            this.panelpr.ResumeLayout(false);
            this.panelpr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelpr;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox emailpr;
        private System.Windows.Forms.TextBox namepr;
        private System.Windows.Forms.TextBox idpr;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}