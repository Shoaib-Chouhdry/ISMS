
namespace ISMSF.Forms
{
    partial class FormHardAssetView
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
            this.panelhv = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hardgridview = new System.Windows.Forms.DataGridView();
            this.panelhv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelhv
            // 
            this.panelhv.Controls.Add(this.comboBox1);
            this.panelhv.Controls.Add(this.label1);
            this.panelhv.Controls.Add(this.hardgridview);
            this.panelhv.Location = new System.Drawing.Point(1, 3);
            this.panelhv.Name = "panelhv";
            this.panelhv.Size = new System.Drawing.Size(837, 503);
            this.panelhv.TabIndex = 5;
            this.panelhv.Paint += new System.Windows.Forms.PaintEventHandler(this.panelhv_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "People Asset View",
            "Soft Asset View"});
            this.comboBox1.Location = new System.Drawing.Point(625, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Open and select for";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hardware Asset View";
            // 
            // hardgridview
            // 
            this.hardgridview.AllowUserToAddRows = false;
            this.hardgridview.AllowUserToDeleteRows = false;
            this.hardgridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.hardgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hardgridview.Location = new System.Drawing.Point(22, 59);
            this.hardgridview.Name = "hardgridview";
            this.hardgridview.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hardgridview.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hardgridview.RowTemplate.Height = 25;
            this.hardgridview.Size = new System.Drawing.Size(760, 350);
            this.hardgridview.TabIndex = 6;
            // 
            // FormHardAssetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 496);
            this.Controls.Add(this.panelhv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHardAssetView";
            this.Text = "FormHardAssetView";
            this.panelhv.ResumeLayout(false);
            this.panelhv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelhv;
        private System.Windows.Forms.DataGridView hardgridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}