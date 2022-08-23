namespace ISMSF.Forms
{
    partial class FormAddthreats
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
            this.paneltr = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.impact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.paneltr.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltr
            // 
            this.paneltr.Controls.Add(this.comboBox1);
            this.paneltr.Controls.Add(this.label1);
            this.paneltr.Controls.Add(this.id);
            this.paneltr.Controls.Add(this.impact);
            this.paneltr.Controls.Add(this.label4);
            this.paneltr.Controls.Add(this.name);
            this.paneltr.Controls.Add(this.button4);
            this.paneltr.Controls.Add(this.label6);
            this.paneltr.Controls.Add(this.label8);
            this.paneltr.Location = new System.Drawing.Point(1, 4);
            this.paneltr.Name = "paneltr";
            this.paneltr.Size = new System.Drawing.Size(830, 443);
            this.paneltr.TabIndex = 54;
            this.paneltr.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltr_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "View Threat"});
            this.comboBox1.Location = new System.Drawing.Point(574, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 23);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.Text = "Select For View Threat";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 64;
            this.label1.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(274, 106);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(240, 23);
            this.id.TabIndex = 63;
            // 
            // impact
            // 
            this.impact.Location = new System.Drawing.Point(274, 203);
            this.impact.Name = "impact";
            this.impact.Size = new System.Drawing.Size(240, 23);
            this.impact.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(186, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "Impact";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(274, 154);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(240, 23);
            this.name.TabIndex = 58;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(335, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 34);
            this.button4.TabIndex = 57;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(186, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(274, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 32);
            this.label8.TabIndex = 54;
            this.label8.Text = "Threats Registration";
            // 
            // FormAddthreats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 445);
            this.Controls.Add(this.paneltr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddthreats";
            this.Text = "FormAddthreats";
            this.paneltr.ResumeLayout(false);
            this.paneltr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneltr;
        private System.Windows.Forms.TextBox impact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}