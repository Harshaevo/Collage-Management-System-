﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Institute
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtboxusername.Text;
            String password = txtboxpassword.Text;

            if( username == "xyz" && password == "abc")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void upgardeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndividualDetail sid = new StudentIndividualDetail();
            sid.Show();
        }

        private void addLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Lecturer_Information at = new Add_Lecturer_Information();
            at.Show();

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Lecturer st = new Search_Lecturer();
            st.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Edit_Student rs = new Edit_Student();
            rs.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About au = new About();
            au.Show();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure? This will Delete Unsaved Your Data", "Confirmation Dialog!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK);
            Application.Exit();
        }
    }
}
