
namespace ISMSF.Forms
{
    partial class FormHardwareReg
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
            this.panelhr = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.processor = new System.Windows.Forms.TextBox();
            this.manu = new System.Windows.Forms.TextBox();
            this.os = new System.Windows.Forms.TextBox();
            this.oid = new System.Windows.Forms.TextBox();
            this.hard = new System.Windows.Forms.TextBox();
            this.oname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.py = new System.Windows.Forms.TextBox();
            this.domain = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mcode = new System.Windows.Forms.TextBox();
            this.textaname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelhr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelhr
            // 
            this.panelhr.Controls.Add(this.comboBox1);
            this.panelhr.Controls.Add(this.label13);
            this.panelhr.Controls.Add(this.label12);
            this.panelhr.Controls.Add(this.label11);
            this.panelhr.Controls.Add(this.label10);
            this.panelhr.Controls.Add(this.label9);
            this.panelhr.Controls.Add(this.label8);
            this.panelhr.Controls.Add(this.processor);
            this.panelhr.Controls.Add(this.manu);
            this.panelhr.Controls.Add(this.os);
            this.panelhr.Controls.Add(this.oid);
            this.panelhr.Controls.Add(this.hard);
            this.panelhr.Controls.Add(this.oname);
            this.panelhr.Controls.Add(this.label7);
            this.panelhr.Controls.Add(this.label5);
            this.panelhr.Controls.Add(this.label4);
            this.panelhr.Controls.Add(this.label3);
            this.panelhr.Controls.Add(this.label2);
            this.panelhr.Controls.Add(this.label1);
            this.panelhr.Controls.Add(this.type);
            this.panelhr.Controls.Add(this.location);
            this.panelhr.Controls.Add(this.quantity);
            this.panelhr.Controls.Add(this.py);
            this.panelhr.Controls.Add(this.domain);
            this.panelhr.Controls.Add(this.model);
            this.panelhr.Controls.Add(this.label6);
            this.panelhr.Controls.Add(this.mcode);
            this.panelhr.Controls.Add(this.textaname);
            this.panelhr.Controls.Add(this.label14);
            this.panelhr.Controls.Add(this.textid);
            this.panelhr.Controls.Add(this.button4);
            this.panelhr.Controls.Add(this.label17);
            this.panelhr.Controls.Add(this.label18);
            this.panelhr.Location = new System.Drawing.Point(0, -1);
            this.panelhr.Name = "panelhr";
            this.panelhr.Size = new System.Drawing.Size(841, 546);
            this.panelhr.TabIndex = 29;
            this.panelhr.Paint += new System.Windows.Forms.PaintEventHandler(this.panelhr_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "People Registration",
            "Software Registration"});
            this.comboBox1.Location = new System.Drawing.Point(579, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 23);
            this.comboBox1.TabIndex = 85;
            this.comboBox1.Text = "Open and select for";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(499, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 84;
            this.label13.Text = "Owner Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(21, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 83;
            this.label12.Text = "Manufacture";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(21, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 82;
            this.label11.Text = "Operating sys";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(255, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 81;
            this.label10.Text = "Owner ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(255, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 80;
            this.label9.Text = "Hard Disk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(499, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Processor";
            // 
            // processor
            // 
            this.processor.Location = new System.Drawing.Point(611, 264);
            this.processor.Name = "processor";
            this.processor.Size = new System.Drawing.Size(123, 23);
            this.processor.TabIndex = 78;
            // 
            // manu
            // 
            this.manu.Location = new System.Drawing.Point(134, 262);
            this.manu.Name = "manu";
            this.manu.Size = new System.Drawing.Size(100, 23);
            this.manu.TabIndex = 77;
            // 
            // os
            // 
            this.os.Location = new System.Drawing.Point(134, 310);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(100, 23);
            this.os.TabIndex = 76;
            // 
            // oid
            // 
            this.oid.Location = new System.Drawing.Point(375, 310);
            this.oid.Name = "oid";
            this.oid.Size = new System.Drawing.Size(118, 23);
            this.oid.TabIndex = 75;
            // 
            // hard
            // 
            this.hard.Location = new System.Drawing.Point(375, 262);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(118, 23);
            this.hard.TabIndex = 74;
            // 
            // oname
            // 
            this.oname.Location = new System.Drawing.Point(611, 310);
            this.oname.Name = "oname";
            this.oname.Size = new System.Drawing.Size(123, 23);
            this.oname.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(255, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(255, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "Purchase Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(499, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(499, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Domain";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(611, 161);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(123, 23);
            this.type.TabIndex = 66;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(134, 161);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(100, 23);
            this.location.TabIndex = 65;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(134, 214);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 23);
            this.quantity.TabIndex = 64;
            // 
            // py
            // 
            this.py.Location = new System.Drawing.Point(375, 215);
            this.py.Name = "py";
            this.py.Size = new System.Drawing.Size(118, 23);
            this.py.TabIndex = 63;
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(611, 213);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(123, 23);
            this.domain.TabIndex = 62;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(375, 161);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(118, 23);
            this.model.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(499, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Main Code";
            // 
            // mcode
            // 
            this.mcode.Location = new System.Drawing.Point(611, 107);
            this.mcode.Name = "mcode";
            this.mcode.Size = new System.Drawing.Size(123, 23);
            this.mcode.TabIndex = 49;
            // 
            // textaname
            // 
            this.textaname.Location = new System.Drawing.Point(375, 107);
            this.textaname.Name = "textaname";
            this.textaname.Size = new System.Drawing.Size(118, 23);
            this.textaname.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(255, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 21);
            this.label14.TabIndex = 36;
            this.label14.Text = "Asset Name";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(134, 107);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 23);
            this.textid.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(317, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 34);
            this.button4.TabIndex = 33;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(21, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 21);
            this.label17.TabIndex = 30;
            this.label17.Text = "ID ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(134, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(361, 32);
            this.label18.TabIndex = 29;
            this.label18.Text = "Assets(Hardware Registration)";
            // 
            // FormHardwareReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 510);
            this.Controls.Add(this.panelhr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHardwareReg";
            this.Text = "FormHardwareReg";
            this.panelhr.ResumeLayout(false);
            this.panelhr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelhr;
        private System.Windows.Forms.TextBox mcode;
        private System.Windows.Forms.TextBox textaname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox py;
        private System.Windows.Forms.TextBox domain;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox processor;
        private System.Windows.Forms.TextBox manu;
        private System.Windows.Forms.TextBox os;
        private System.Windows.Forms.TextBox oid;
        private System.Windows.Forms.TextBox hard;
        private System.Windows.Forms.TextBox oname;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}