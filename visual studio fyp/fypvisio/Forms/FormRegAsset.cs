using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMSF.Forms
{
    public partial class FormRegAsset : Form
    {
      

        public FormRegAsset()
        {
            InitializeComponent();
            
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Show();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            loadform(new FormHardwareReg());
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadform(new FormSoftwareReg());
            }

        private void button6_Click(object sender, EventArgs e)
        {
            loadform(new FormPeopleReg());

             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
