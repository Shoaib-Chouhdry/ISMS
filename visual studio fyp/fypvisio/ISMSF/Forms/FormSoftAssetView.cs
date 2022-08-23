using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISMSF.Forms
{
    public partial class FormSoftAssetView : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZOHAIB\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");

       
        SqlDataAdapter adpt;
       
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT* FROM softr", conn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            softgridview.DataSource = dt;
        }
        public FormSoftAssetView()
        {
            InitializeComponent();
            showdata();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelsv.Controls.Clear();
            f.TopLevel = false;
            this.panelsv.Controls.Add(f);
            f.Show();
        }

     
  

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new FormHardAssetView());
        }

        private void panelsv_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
