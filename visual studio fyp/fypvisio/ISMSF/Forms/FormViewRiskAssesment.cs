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
    public partial class FormViewRiskAssesment : Form
    {
        public FormViewRiskAssesment()
        {
            InitializeComponent();
            showdata();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=ZOHAIB\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");

        SqlDataAdapter adpt;
       
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT* FROM Ra", conn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            gridra.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new FormRAssesment());
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelra.Controls.Clear();
            f.TopLevel = false;
            this.panelra.Controls.Add(f);
            f.Show();
        }
    }
}
