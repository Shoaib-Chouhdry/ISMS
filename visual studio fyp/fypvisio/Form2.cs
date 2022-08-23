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
            loadform(new FormRegAsset());
           
        }

        private void btnAssetsid_Click(object sender, EventArgs e)
        {
            loadform(new FormViewAsset());
        }

        private void btnthreats_Click(object sender, EventArgs e)
        {
            loadform(new FormThreatReg());
        }

        private void btnrisk_Click(object sender, EventArgs e)
        {
            loadform(new FormRiskAssesment());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            loadform(new policies_reg());
        }
    }
}
