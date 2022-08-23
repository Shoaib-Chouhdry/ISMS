
namespace ISMSF.Forms
{
    partial class FormSoftAssetView
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
            this.panelsv = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.softgridview = new System.Windows.Forms.DataGridView();
            this.panelsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsv
            // 
            this.panelsv.Controls.Add(this.label1);
            this.panelsv.Controls.Add(this.button3);
            this.panelsv.Controls.Add(this.softgridview);
            this.panelsv.Location = new System.Drawing.Point(2, 1);
            this.panelsv.Name = "panelsv";
            this.panelsv.Size = new System.Drawing.Size(859, 489);
            this.panelsv.TabIndex = 3;
            this.panelsv.Paint += new System.Windows.Forms.PaintEventHandler(this.panelsv_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Software Asset View";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(669, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // softgridview
            // 
            this.softgridview.AllowUserToAddRows = false;
            this.softgridview.AllowUserToDeleteRows = false;
            this.softgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.softgridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.softgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.softgridview.Location = new System.Drawing.Point(23, 80);
            this.softgridview.Name = "softgridview";
            this.softgridview.ReadOnly = true;
            this.softgridview.RowTemplate.Height = 25;
            this.softgridview.Size = new System.Drawing.Size(735, 305);
            this.softgridview.TabIndex = 4;
            // 
            // FormSoftAssetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 487);
            this.Controls.Add(this.panelsv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSoftAssetView";
            this.Text = "FormSoftAssetView";
            this.panelsv.ResumeLayout(false);
            this.panelsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.softgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelsv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView softgridview;
        private System.Windows.Forms.Label label1;
    }
}