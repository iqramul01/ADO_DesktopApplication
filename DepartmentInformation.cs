using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class DepartmentInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;


        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        public DepartmentInformation()
        {
            InitializeComponent();
        }

        private void showinfo()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM Department", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgDepartmentInformation.DataSource = dt;
        }

        private void DepartmentInformation_Load(object sender, EventArgs e)
        {
            showinfo();
        }

        private void dgDepartmentInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDepartmentID.Text = this.dgDepartmentInformation.CurrentRow.Cells["DepID"].Value.ToString();
            txtDepartmentName.Text = this.dgDepartmentInformation.CurrentRow.Cells["DepartmentName"].Value.ToString();
            txtNumberofSeat.Text = this.dgDepartmentInformation.CurrentRow.Cells["NumberofSeat"].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }

        public void ClearAllData()
        {
            txtDepartmentID.Text = "";
            txtDepartmentName.Text = "";
            txtNumberofSeat.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO Department(DepartmentName, NumberOfSeat) VALUES(@departmentname, @numberofseat)", con);
            cmd.Parameters.AddWithValue("@departmentname", txtDepartmentName.Text);
            cmd.Parameters.AddWithValue("@numberofseat", txtNumberofSeat.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully.");

            showinfo();
            ClearAllData();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDepartmentID.Text != "")
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("UPDATE Department SET DepartmentName=@departmentname, NumberOfSeat=@numberofseat WHERE DepID=@departmentid", con);
                cmd.Parameters.AddWithValue("@departmentid", txtDepartmentID.Text);
                cmd.Parameters.AddWithValue("@departmentname", txtDepartmentName.Text);
                cmd.Parameters.AddWithValue("@numberofseat", txtNumberofSeat.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully.");


                showinfo();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Department ID Not Found!!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDepartmentID.Text != "")
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("DELETE FROM Department WHERE DepID=@departmentid", con);
                cmd.Parameters.AddWithValue("@departmentid", txtDepartmentID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully.");

                showinfo();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Department ID Not Found!!!!");
            }
        }
    }
}
