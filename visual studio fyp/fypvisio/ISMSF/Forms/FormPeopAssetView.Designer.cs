
namespace ISMSF.Forms
{
    partial class FormPeopAssetView
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
            this.panelpv = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gridpeop = new System.Windows.Forms.DataGridView();
            this.panelpv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpeop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelpv
            // 
            this.panelpv.Controls.Add(this.label1);
            this.panelpv.Controls.Add(this.button3);
            this.panelpv.Controls.Add(this.gridpeop);
            this.panelpv.Location = new System.Drawing.Point(0, 1);
            this.panelpv.Name = "panelpv";
            this.panelpv.Size = new System.Drawing.Size(846, 527);
            this.panelpv.TabIndex = 3;
            this.panelpv.Paint += new System.Windows.Forms.PaintEventHandler(this.panelpv_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "People Asset View";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(520, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridpeop
            // 
            this.gridpeop.AllowUserToAddRows = false;
            this.gridpeop.AllowUserToDeleteRows = false;
            this.gridpeop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridpeop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridpeop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridpeop.Location = new System.Drawing.Point(14, 77);
            this.gridpeop.Name = "gridpeop";
            this.gridpeop.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridpeop.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridpeop.RowTemplate.Height = 25;
            this.gridpeop.Size = new System.Drawing.Size(591, 259);
            this.gridpeop.TabIndex = 4;
            // 
            // FormPeopAssetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 507);
            this.Controls.Add(this.panelpv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPeopAssetView";
            this.Text = "people_asset_view";
            this.panelpv.ResumeLayout(false);
            this.panelpv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpeop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelpv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView gridpeop;
        private System.Windows.Forms.Label label1;
    }
}