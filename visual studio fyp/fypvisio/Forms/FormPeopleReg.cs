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
    public partial class FormPeopleReg : Form
    {
        public FormPeopleReg()
        {
            InitializeComponent();
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
           
            

            SqlConnection con= new SqlConnection("Data Source=DESKTOP-OCHGI6M\\SQLEXPRESS;Initial Catalog=final;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into prt(id,name,email) values('"+idpr.Text+"','"+namepr.Text+"','"+emailpr.Text+"')",con);
            int i = cmd.ExecuteNonQuery();
            if(i!=0)
            {

                MessageBox.Show("Successfully Data Added");
                this.Hide();
               

            }
            else
            {
                MessageBox.Show("error");

            }
            con.Close();

            
        }

        private void FormPeopleReg_Load(object sender, EventArgs e)
        {

        }
    }
}
