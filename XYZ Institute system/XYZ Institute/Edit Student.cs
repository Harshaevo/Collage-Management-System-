using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Institute
{
    public partial class Edit_Student : Form
    {
        public Edit_Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString= "data source = LAPTOP-OH976SKT;database=XYZInstituteDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewDelete.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete warning
            if(MessageBox.Show("Do you want Delete Data?","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                //delete unit
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-OH976SKT;database=XYZInstituteDB;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewAdmission where NAID =" + txtRegID.Text + "";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Deletion Successful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            
    }
}
