
namespace ISMSF.Forms
{
    partial class FormViewComplaints
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcv = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tech = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridviewc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panelcv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcv
            // 
            this.panelcv.Controls.Add(this.label4);
            this.panelcv.Controls.Add(this.id);
            this.panelcv.Controls.Add(this.button2);
            this.panelcv.Controls.Add(this.label3);
            this.panelcv.Controls.Add(this.tech);
            this.panelcv.Controls.Add(this.label2);
            this.panelcv.Controls.Add(this.stat);
            this.panelcv.Controls.Add(this.button1);
            this.panelcv.Controls.Add(this.label1);
            this.panelcv.Controls.Add(this.gridviewc);
            this.panelcv.Location = new System.Drawing.Point(1, 1);
            this.panelcv.Name = "panelcv";
            this.panelcv.Size = new System.Drawing.Size(806, 453);
            this.panelcv.TabIndex = 10;
            
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(329, 20);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 23);
            this.id.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(653, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(241, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tech Comments";
            // 
            // tech
            // 
            this.tech.Location = new System.Drawing.Point(378, 54);
            this.tech.Name = "tech";
            this.tech.Size = new System.Drawing.Size(248, 23);
            this.tech.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(444, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Status";
            // 
            // stat
            // 
            this.stat.Location = new System.Drawing.Point(526, 20);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(100, 23);
            this.stat.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(641, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Comlaints View";
            // 
            // gridviewc
            // 
            this.gridviewc.AllowUserToAddRows = false;
            this.gridviewc.AllowUserToDeleteRows = false;
            this.gridviewc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridviewc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewc.Location = new System.Drawing.Point(28, 83);
            this.gridviewc.Name = "gridviewc";
            this.gridviewc.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewc.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewc.RowTemplate.Height = 25;
            this.gridviewc.Size = new System.Drawing.Size(715, 297);
            this.gridviewc.TabIndex = 6;
            this.gridviewc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridviewc_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(241, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID";
            // 
            // FormViewComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewComplaints";
            this.Text = "FormViewComplaints";
         
            this.panelcv.ResumeLayout(false);
            this.panelcv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridviewc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tech;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stat;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
    }
}