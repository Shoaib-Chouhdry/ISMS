
namespace ISMSF.Forms
{
    partial class FormRAssesment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.catg = new System.Windows.Forms.ComboBox();
            this.maxi = new System.Windows.Forms.ComboBox();
            this.avai = new System.Windows.Forms.ComboBox();
            this.intg = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.risk = new System.Windows.Forms.TextBox();
            this.imp = new System.Windows.Forms.ComboBox();
            this.pro = new System.Windows.Forms.ComboBox();
            this.conf = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tcombo = new System.Windows.Forms.ComboBox();
            this.aid = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vr = new System.Windows.Forms.TextBox();
            this.tr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.catg);
            this.panel1.Controls.Add(this.maxi);
            this.panel1.Controls.Add(this.avai);
            this.panel1.Controls.Add(this.intg);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.risk);
            this.panel1.Controls.Add(this.imp);
            this.panel1.Controls.Add(this.pro);
            this.panel1.Controls.Add(this.conf);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tcombo);
            this.panel1.Controls.Add(this.aid);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.vr);
            this.panel1.Controls.Add(this.tr);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.aname);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 502);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(11, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 21);
            this.label14.TabIndex = 64;
            this.label14.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(128, 71);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(135, 23);
            this.id.TabIndex = 63;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "Get RiskValue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // catg
            // 
            this.catg.FormattingEnabled = true;
            this.catg.Location = new System.Drawing.Point(641, 225);
            this.catg.Name = "catg";
            this.catg.Size = new System.Drawing.Size(85, 23);
            this.catg.TabIndex = 61;
            // 
            // maxi
            // 
            this.maxi.FormattingEnabled = true;
            this.maxi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.maxi.Location = new System.Drawing.Point(418, 225);
            this.maxi.Name = "maxi";
            this.maxi.Size = new System.Drawing.Size(91, 23);
            this.maxi.TabIndex = 60;
            // 
            // avai
            // 
            this.avai.FormattingEnabled = true;
            this.avai.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.avai.Location = new System.Drawing.Point(418, 172);
            this.avai.Name = "avai";
            this.avai.Size = new System.Drawing.Size(91, 23);
            this.avai.TabIndex = 59;
            // 
            // intg
            // 
            this.intg.FormattingEnabled = true;
            this.intg.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.intg.Location = new System.Drawing.Point(417, 112);
            this.intg.Name = "intg";
            this.intg.Size = new System.Drawing.Size(91, 23);
            this.intg.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(521, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 57;
            this.label13.Text = "Risk Value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(514, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Probability";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(514, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 55;
            this.label11.Text = "Impact";
            // 
            // risk
            // 
            this.risk.Location = new System.Drawing.Point(641, 174);
            this.risk.Name = "risk";
            this.risk.Size = new System.Drawing.Size(85, 23);
            this.risk.TabIndex = 54;
            // 
            // imp
            // 
            this.imp.FormattingEnabled = true;
            this.imp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.imp.Location = new System.Drawing.Point(641, 67);
            this.imp.Name = "imp";
            this.imp.Size = new System.Drawing.Size(85, 23);
            this.imp.TabIndex = 53;
            // 
            // pro
            // 
            this.pro.FormattingEnabled = true;
            this.pro.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.pro.Location = new System.Drawing.Point(641, 108);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(85, 23);
            this.pro.TabIndex = 52;
            // 
            // conf
            // 
            this.conf.FormattingEnabled = true;
            this.conf.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.conf.Location = new System.Drawing.Point(418, 69);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(90, 23);
            this.conf.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RA View"});
            this.comboBox1.Location = new System.Drawing.Point(574, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 23);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.Text = "Select For RA View";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tcombo
            // 
            this.tcombo.FormattingEnabled = true;
            this.tcombo.Location = new System.Drawing.Point(128, 236);
            this.tcombo.Name = "tcombo";
            this.tcombo.Size = new System.Drawing.Size(135, 23);
            this.tcombo.TabIndex = 49;
            this.tcombo.Text = "Select ThreatId";
            this.tcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // aid
            // 
            this.aid.FormattingEnabled = true;
            this.aid.Location = new System.Drawing.Point(128, 108);
            this.aid.Name = "aid";
            this.aid.Size = new System.Drawing.Size(135, 23);
            this.aid.TabIndex = 48;
            this.aid.Text = "Select AssetId ";
            this.aid.SelectedIndexChanged += new System.EventHandler(this.vc_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "Threat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Vulnerability";
            // 
            // vr
            // 
            this.vr.Location = new System.Drawing.Point(128, 199);
            this.vr.Name = "vr";
            this.vr.Size = new System.Drawing.Size(135, 23);
            this.vr.TabIndex = 45;
            // 
            // tr
            // 
            this.tr.Location = new System.Drawing.Point(128, 273);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(135, 23);
            this.tr.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(269, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "Max(Asset Value)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(269, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "Availability";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(514, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(202, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 32);
            this.label9.TabIndex = 36;
            this.label9.Text = "Risk Assesment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(269, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Integrity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(269, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "confidentiality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Asset ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(429, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Asset Name";
            // 
            // aname
            // 
            this.aname.Location = new System.Drawing.Point(128, 157);
            this.aname.Name = "aname";
            this.aname.Size = new System.Drawing.Size(135, 23);
            this.aname.TabIndex = 8;
            // 
            // FormRAssesment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRAssesment";
            this.Text = "FormViewRIskAssesment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox aname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox vr;
        private System.Windows.Forms.TextBox tr;
        private System.Windows.Forms.ComboBox tcombo;
        private System.Windows.Forms.ComboBox aid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox conf;
        private System.Windows.Forms.ComboBox catg;
        private System.Windows.Forms.ComboBox maxi;
        private System.Windows.Forms.ComboBox avai;
        private System.Windows.Forms.ComboBox intg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox risk;
        private System.Windows.Forms.ComboBox imp;
        private System.Windows.Forms.ComboBox pro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox id;
    }
}