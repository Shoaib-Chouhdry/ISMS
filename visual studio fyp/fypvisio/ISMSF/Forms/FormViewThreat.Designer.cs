
namespace ISMSF.Forms
{
    partial class FormViewThreat
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
            this.panelvt = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Threatgridview = new System.Windows.Forms.DataGridView();
            this.panelvt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Threatgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelvt
            // 
            this.panelvt.Controls.Add(this.label1);
            this.panelvt.Controls.Add(this.button3);
            this.panelvt.Controls.Add(this.Threatgridview);
            this.panelvt.Location = new System.Drawing.Point(2, 1);
            this.panelvt.Name = "panelvt";
            this.panelvt.Size = new System.Drawing.Size(803, 454);
            this.panelvt.TabIndex = 3;
            this.panelvt.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvt_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Threat View";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(534, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Threatgridview
            // 
            this.Threatgridview.AllowUserToAddRows = false;
            this.Threatgridview.AllowUserToDeleteRows = false;
            this.Threatgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Threatgridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Threatgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Threatgridview.Location = new System.Drawing.Point(30, 68);
            this.Threatgridview.Name = "Threatgridview";
            this.Threatgridview.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Threatgridview.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Threatgridview.RowTemplate.Height = 25;
            this.Threatgridview.Size = new System.Drawing.Size(583, 268);
            this.Threatgridview.TabIndex = 4;
            // 
            // FormViewThreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelvt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewThreat";
            this.Text = "FormViewThreat";
            this.panelvt.ResumeLayout(false);
            this.panelvt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Threatgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelvt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Threatgridview;
        private System.Windows.Forms.Label label1;
    }
}