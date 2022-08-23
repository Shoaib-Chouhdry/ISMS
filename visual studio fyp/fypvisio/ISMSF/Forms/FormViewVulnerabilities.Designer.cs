
namespace ISMSF.Forms
{
    partial class FormViewVulnerabilities
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
            this.panelvv = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Vulnergridview = new System.Windows.Forms.DataGridView();
            this.panelvv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vulnergridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelvv
            // 
            this.panelvv.Controls.Add(this.label1);
            this.panelvv.Controls.Add(this.button3);
            this.panelvv.Controls.Add(this.Vulnergridview);
            this.panelvv.Location = new System.Drawing.Point(0, -6);
            this.panelvv.Name = "panelvv";
            this.panelvv.Size = new System.Drawing.Size(851, 512);
            this.panelvv.TabIndex = 3;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vulnerabilities View";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(614, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Vulnergridview
            // 
            this.Vulnergridview.AllowUserToAddRows = false;
            this.Vulnergridview.AllowUserToDeleteRows = false;
            this.Vulnergridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Vulnergridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Vulnergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vulnergridview.Location = new System.Drawing.Point(12, 83);
            this.Vulnergridview.Name = "Vulnergridview";
            this.Vulnergridview.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Vulnergridview.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Vulnergridview.RowTemplate.Height = 25;
            this.Vulnergridview.Size = new System.Drawing.Size(683, 292);
            this.Vulnergridview.TabIndex = 3;
            // 
            // FormViewVulnerabilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 518);
            this.Controls.Add(this.panelvv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewVulnerabilities";
            this.Text = "FormViewVulnerabilities";
            this.panelvv.ResumeLayout(false);
            this.panelvv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vulnergridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelvv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Vulnergridview;
        private System.Windows.Forms.Label label1;
    }
}