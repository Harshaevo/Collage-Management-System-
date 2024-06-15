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
    public partial class Add_Lecturer_Information : Form
    {
        public Add_Lecturer_Information()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Lecturer_Information_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveL_Click(object sender, EventArgs e)
        {
            String gender = "";
            bool isChecked = radioButton1MaleL.Checked;

            if(isChecked)
            {
                gender = radioButton1MaleL.Text;
            }
            else
            {
                gender = radioButton2FemaleL.Text;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-OH976SKT;database=XYZInstituteDB;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into lecturer (fname,gender,dob,mobile,email,semester,modul,yer,adr)  values ('"+txtFNameL.Text+"','"+gender+"','"+dateTimePickerDOBL.Text+"','"+txtMNumberL.Text+"','"+txtEmailL.Text+"','"+txtSemesterL+"','"+txtModuleL+"','"+txtDurationL+"','"+txtAddressL+"')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
