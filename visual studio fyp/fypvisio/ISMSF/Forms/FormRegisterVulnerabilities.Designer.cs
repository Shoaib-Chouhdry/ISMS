
namespace ISMSF.Forms
{
    partial class FormRegisterVulnerabilities
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
            this.panelvr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.aid = new System.Windows.Forms.TextBox();
            this.namer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vulnerabilitiesr = new System.Windows.Forms.TextBox();
            this.idr = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelvr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelvr
            // 
            this.panelvr.Controls.Add(this.comboBox1);
            this.panelvr.Controls.Add(this.label1);
            this.panelvr.Controls.Add(this.aid);
            this.panelvr.Controls.Add(this.namer);
            this.panelvr.Controls.Add(this.label4);
            this.panelvr.Controls.Add(this.vulnerabilitiesr);
            this.panelvr.Controls.Add(this.idr);
            this.panelvr.Controls.Add(this.button4);
            this.panelvr.Controls.Add(this.label5);
            this.panelvr.Controls.Add(this.label6);
            this.panelvr.Controls.Add(this.label8);
            this.panelvr.Location = new System.Drawing.Point(3, 3);
            this.panelvr.Name = "panelvr";
            this.panelvr.Size = new System.Drawing.Size(804, 502);
            this.panelvr.TabIndex = 54;
            this.panelvr.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvr_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "Asset ID";
            // 
            // aid
            // 
            this.aid.Location = new System.Drawing.Point(239, 152);
            this.aid.Name = "aid";
            this.aid.Size = new System.Drawing.Size(179, 23);
            this.aid.TabIndex = 63;
            // 
            // namer
            // 
            this.namer.Location = new System.Drawing.Point(239, 208);
            this.namer.Name = "namer";
            this.namer.Size = new System.Drawing.Size(179, 23);
            this.namer.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(107, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "Asset Name";
            // 
            // vulnerabilitiesr
            // 
            this.vulnerabilitiesr.Location = new System.Drawing.Point(239, 269);
            this.vulnerabilitiesr.Name = "vulnerabilitiesr";
            this.vulnerabilitiesr.Size = new System.Drawing.Size(179, 23);
            this.vulnerabilitiesr.TabIndex = 59;
            // 
            // idr
            // 
            this.idr.Location = new System.Drawing.Point(239, 96);
            this.idr.Name = "idr";
            this.idr.Size = new System.Drawing.Size(179, 23);
            this.idr.TabIndex = 58;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(273, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 34);
            this.button4.TabIndex = 57;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(107, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Vulnerabilities";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(107, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "ID ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(94, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 32);
            this.label8.TabIndex = 54;
            this.label8.Text = "Vulnerabilities Registration";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "View Vulnerabilities"});
            this.comboBox1.Location = new System.Drawing.Point(452, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 23);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.Text = "Select For View Vulnerabilities";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormRegisterVulnerabilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 478);
            this.Controls.Add(this.panelvr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegisterVulnerabilities";
            this.Text = "FormAddRisk";
            this.panelvr.ResumeLayout(false);
            this.panelvr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelvr;
        private System.Windows.Forms.TextBox namer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vulnerabilitiesr;
        private System.Windows.Forms.TextBox idr;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aid;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}