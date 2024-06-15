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
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtFullName.Text;
            String idnumber = txtIDnumber.Text;
            String gender = " ";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNumber.Text);
            String mail = txtEmail.Text;
            String semester = txtSemester.Text;
            String module = txtModule.Text;
            String duration = txtDuration.Text;
            String add = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-OH976SKT;database=XYZInstituteDB;integrated security=true";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "insert into NewAdmission (fname,IDnumber,gender,dob,mobile,email,semester,module,duration,addres)values ('" + name + "','" + idnumber + "','" + gender + "','" + dob + "','" + mobile + "','" + mail + "','" + semester + "','" + module + "','" + duration + "','" + add + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved.Remember The Register ID,Thank You.", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtIDnumber.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            txtMobileNumber.Clear();
           txtEmail.Clear();
            txtModule.ResetText();
            txtSemester.ResetText();
            txtDuration.ResetText();

        }
            private void New_Admission_Load(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-OH976SKT;database=XYZInstituteDB;integrated security=true";
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select max(NAID) from NewAdmission";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label13.Text = abc.ToString();
        }
    }
}
