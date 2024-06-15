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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void txtRegisterNumber_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP - OH976SKT;database = XYZInstituteDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select fname,IDnumber,duration from NewAdmission where NAID = " + txtRegisterNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            MessageBox.Show("dsf");

           /// fnamelbl.Text = DS.Tables[0].Rows[0][0].ToString();
            ///IDnumberlbl.Text = DS.Tables[0].Rows[0][1].ToString();
           /// durationlbl.Text = DS.Tables[0].Rows[0][2].ToString();

        }
    }
}
