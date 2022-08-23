using ISMSF.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMSF
{
    public partial class Form2 : Form
    {
     
        public Form2()
        {
            InitializeComponent();
        }

     

        public void loadform(object Form)
        {
            if (this.panelDesktoppannel.Controls.Count > 0)
                this.panelDesktoppannel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelDesktoppannel.Controls.Add(f);
            this.panelDesktoppannel.Tag = f;
            f.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            loadform(new FormAdmin());
        }

        private void btnAssetsAsses_Click(object sender, EventArgs e)
        {
           
            loadform(new FormHardwareReg());
           
        }

        private void btnAssetsid_Click(object sender, EventArgs e)
        {
            loadform(new FormHardAssetView());
        }

        private void btnthreats_Click(object sender, EventArgs e)
        {
            loadform(new FormAddthreats());
        }

        private void btnrisk_Click(object sender, EventArgs e)
        {
            loadform(new FormRegisterVulnerabilities());
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new FormRegisterComplaints());
        }

        private void panelDesktoppannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            loadform(new FormViewPolicies());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new FormRAssesment());
        }

        private void form_load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
