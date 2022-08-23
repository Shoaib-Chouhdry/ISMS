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
    public partial class FormRiskAssesment : Form
    {
        public FormRiskAssesment()
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
            loadform(new FormAddRisk());
        }
    }
}
