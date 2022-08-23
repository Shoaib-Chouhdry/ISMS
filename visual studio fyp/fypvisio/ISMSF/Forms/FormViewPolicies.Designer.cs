
namespace ISMSF.Forms
{
    partial class FormViewPolicies
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
            this.panelpo = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridpolicy = new System.Windows.Forms.DataGridView();
            this.panelpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpolicy)).BeginInit();
            this.SuspendLayout();
            // 
            // panelpo
            // 
            this.panelpo.Controls.Add(this.comboBox1);
            this.panelpo.Controls.Add(this.label1);
            this.panelpo.Controls.Add(this.gridpolicy);
            this.panelpo.Location = new System.Drawing.Point(1, 3);
            this.panelpo.Name = "panelpo";
            this.panelpo.Size = new System.Drawing.Size(910, 491);
            this.panelpo.TabIndex = 0;
            this.panelpo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelpo_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add Policies",
            "Assign Policies",
            "View Assign Policies"});
            this.comboBox1.Location = new System.Drawing.Point(735, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Open And Select For";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Policies View";
            // 
            // gridpolicy
            // 
            this.gridpolicy.AllowUserToAddRows = false;
            this.gridpolicy.AllowUserToDeleteRows = false;
            this.gridpolicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridpolicy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridpolicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridpolicy.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridpolicy.Location = new System.Drawing.Point(30, 53);
            this.gridpolicy.Name = "gridpolicy";
            this.gridpolicy.ReadOnly = true;
            this.gridpolicy.RowTemplate.Height = 25;
            this.gridpolicy.Size = new System.Drawing.Size(855, 387);
            this.gridpolicy.TabIndex = 10;
            // 
            // FormViewPolicies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 506);
            this.Controls.Add(this.panelpo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewPolicies";
            this.Text = "FormViewPolicies";
            this.panelpo.ResumeLayout(false);
            this.panelpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridpolicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelpo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridpolicy;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}