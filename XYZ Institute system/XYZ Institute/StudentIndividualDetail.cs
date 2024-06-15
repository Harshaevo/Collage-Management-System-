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
    public partial class StudentIndividualDetail : Form
    {
        public StudentIndividualDetail()
        {
            InitializeComponent();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-OH976SKT; database = XYZInstituteDB; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText ="select * from NewAdmission where NAID= "+txtBoxRegID.Text+"";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {

                lblFullName.Text = ds.Tables[0].Rows[0][1].ToString();
                lblIDNumber.Text = ds.Tables[0].Rows[0][2].ToString();
                lblGender.Text = ds.Tables[0].Rows[0][3].ToString();
                lblDofBirth.Text = ds.Tables[0].Rows[0][4].ToString();
                lblMobilenumber.Text = ds.Tables[0].Rows[0][5].ToString();
                lblEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                lblSemester.Text = ds.Tables[0].Rows[0][7].ToString();
                lblModule.Text = ds.Tables[0].Rows[0][8].ToString();
                lblDuration.Text = ds.Tables[0].Rows[0][9].ToString();
                lblAddress.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            //Record error
            {
                MessageBox.Show("No Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFullName.Text = "..........";
                lblIDNumber.Text = "..........";
                lblGender.Text = "..........";
                lblDofBirth.Text = "..........";
                lblMobilenumber.Text = "..........";
                lblEmail.Text = "..........";
                lblSemester.Text = "..........";
                lblModule.Text = "..........";
                lblDuration.Text = "..........";
                lblAddress.Text = "..........";
            }
        }
        //reset records
        private void btnReset2_Click(object sender, EventArgs e)
        {
            lblFullName.Text = "..........";
            lblIDNumber.Text = "..........";
            lblGender.Text = "..........";
            lblDofBirth.Text = "..........";
            lblMobilenumber.Text = "..........";
            lblEmail.Text = "..........";
            lblSemester.Text = "..........";
            lblModule.Text = "..........";
            lblDuration.Text = "..........";
            lblAddress.Text = "..........";
        }
    }
}
