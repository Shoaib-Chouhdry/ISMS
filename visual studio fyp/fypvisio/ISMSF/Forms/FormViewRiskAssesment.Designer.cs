
namespace ISMSF.Forms
{
    partial class FormViewRiskAssesment
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
            this.panelra = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridra = new System.Windows.Forms.DataGridView();
            this.panelra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelra
            // 
            this.panelra.Controls.Add(this.button1);
            this.panelra.Controls.Add(this.label1);
            this.panelra.Controls.Add(this.gridra);
            this.panelra.Location = new System.Drawing.Point(3, 5);
            this.panelra.Name = "panelra";
            this.panelra.Size = new System.Drawing.Size(918, 493);
            this.panelra.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(718, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Risk Assesment View";
            // 
            // gridra
            // 
            this.gridra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridra.Location = new System.Drawing.Point(31, 66);
            this.gridra.Name = "gridra";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridra.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridra.RowTemplate.Height = 25;
            this.gridra.Size = new System.Drawing.Size(789, 358);
            this.gridra.TabIndex = 0;
            // 
            // FormViewRiskAssesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 494);
            this.Controls.Add(this.panelra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewRiskAssesment";
            this.Text = "FormViewRiskAssesment";
            this.panelra.ResumeLayout(false);
            this.panelra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelra;
        private System.Windows.Forms.DataGridView gridra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}