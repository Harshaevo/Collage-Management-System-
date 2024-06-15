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
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-OH976SKT;database=XYZInstituteDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission.NAID as Studenr_ID,NewAdmission.fname as Full_Name,NewAdmission.IDnumber as ID_Number,NewAdmission.gender as Gender,NewAdmission.dob as Date_Of_Birth,NewAdmission.mobile as Mobile_Number,NewAdmission.email as Email , NewAdmission.semester as Semester, NewAdmission.module as Module, NewAdmission.duration as Duration, NewAdmission.addres as Address,fees.fees as Fees from NewAdmission inner join fees on NewAdmission.NAID=fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewSerchStud.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-OH976SKT;database=XYZInstituteDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID = "+textBox1.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewSerchStud.DataSource = ds.Tables[0];
        }
    }
}
