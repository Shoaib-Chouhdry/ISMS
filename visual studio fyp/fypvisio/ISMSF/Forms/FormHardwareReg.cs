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
using System.Configuration;

namespace ISMSF.Forms
{
    public partial class FormHardwareReg : Form
    {
        public FormHardwareReg()
        {
           
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelhr.Controls.Clear();
            f.TopLevel = false;
            this.panelhr.Controls.Add(f);
            f.Show();
        }
     


        

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into hardr(Id,Assetname,Maincode,Location,Model,Type,Quantity,Purchaseyear,Domain,Manufacture,Harddisk,Processor,Operatingsystem,Ownerid,Ownername)values('" + textid.Text + "','" + textaname.Text + "','" + mcode.Text + "','" + location.Text + "','" + model.Text + "','" + type.Text + "','" + quantity.Text + "','" + py.Text + "','" + domain.Text + "','" + manu.Text + "','" + hard.Text + "','" + processor.Text + "','" + os.Text + "','" + oid.Text + "','" + oname.Text + "')", con);
            if ( textid.Text==""|| textaname.Text == "" || mcode.Text == "" || location.Text == "" || model.Text == "" || type.Text == "" || quantity.Text == "" || py.Text == "" || domain.Text == "" || manu.Text == "" || hard.Text == "" || processor.Text == "" || os.Text == "" || oid.Text == "" || oname.Text == "" )
            {
                MessageBox.Show("Error !! Fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("Data added successfully");
            }
            cmd.ExecuteNonQuery();
            textid.Text = "";
            textaname.Text = "";
            mcode.Text = "";
            location.Text = "";
            model.Text = "";
            type.Text = "";
            quantity.Text = "";
            py.Text = "";
            domain.Text = "";
            manu.Text = "";
            hard.Text = "";
            processor.Text = "";
            os.Text = "";
            oid.Text = "";
            oname.Text = "";



            con.Close();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("People Registration")) peop();
            if (comboBox1.Text.Equals("Software Registration")) soft();
        }
        void peop()
        {
            loadform(new FormPeopleReg());
        }
        void soft()
        {
            loadform(new FormSoftwareReg());
        }

        private void panelhr_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(id as int)),0)+1 from hardr", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textid.Text = dt.Rows[0][0].ToString();
        }
    }
}
