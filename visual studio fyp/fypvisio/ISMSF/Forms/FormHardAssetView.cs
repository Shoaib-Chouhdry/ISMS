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
    public partial class FormHardAssetView : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZOHAIB\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");

        SqlDataAdapter adpt;
       
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT* FROM hardr", conn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            hardgridview.DataSource = dt;
        }
        public FormHardAssetView()
        {
            InitializeComponent();
            showdata();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelhv.Controls.Clear();
            f.TopLevel = false;
            this.panelhv.Controls.Add(f);
            f.Show();
        }
    


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("People Asset View")) peop();
            if (comboBox1.Text.Equals("Soft Asset View")) soft();
        }
        void peop()
        {
            loadform(new FormPeopAssetView());
        }
        void soft()
        {
            loadform(new FormSoftAssetView());
        }

        private void panelhv_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
