
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class frmPatientReleaseInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow dr;

        public frmPatientReleaseInformation()
        {
            InitializeComponent();
            GetDepartmentID();
            GetPatientID();
            
        }
        public void ClearAllData()
        {
            txtBillNo.Text = "";
            txtTotalBill.Text = "";
            txtDiscountRate.Text = "";
            cmbBoxDepID.Text = "Department Name";
            cmbBoxPatientID.Text = "Patient ID";
        }

        public void GetDepartmentID()
        {
            con = new SqlConnection(cs);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Department", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Choose Department ID" };
            dt.Rows.InsertAt(dr, 0);

            cmbBoxDepID.ValueMember = "DepID";
            cmbBoxDepID.DisplayMember = "DepartmentName";

            cmbBoxDepID.DataSource = dt;

            con.Close();
        }

        public void GetPatientID()
        {
            con = new SqlConnection(cs);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM PatientAdmit", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Choose Patient ID" };
            dt.Rows.InsertAt(dr, 0);

            cmbBoxPatientID.ValueMember = "PatientID";
            cmbBoxPatientID.DisplayMember = "PatientID";

            cmbBoxPatientID.DataSource = dt;

            con.Close();
        }

        private void showPatientReleaseInfo()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM PatientRelease", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgPatientRelease.DataSource = dt;
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
    
        private void frmPatientReleaseInformation_Load(object sender, EventArgs e)
        {
            showPatientReleaseInfo();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBillNo.Text != "")
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("DELETE FROM PatientRelease WHERE BillNo=@billno", con);
                cmd.Parameters.AddWithValue("@billno", txtBillNo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully.");

                showPatientReleaseInfo();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Bill No Not Found!!!!");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            cmd = new SqlCommand("EXEC sp_PatientReleaseInsert @billno,@releaseDate,@totalBill,@discountrate,@depid,@patientid", con);

            cmd.Parameters.AddWithValue("@billno", txtBillNo.Text);
            cmd.Parameters.AddWithValue("@releaseDate", dtpReleaseDate.Text);
            cmd.Parameters.AddWithValue("@totalBill", txtTotalBill.Text);
            cmd.Parameters.AddWithValue("@discountrate", txtDiscountRate.Text);
            cmd.Parameters.AddWithValue("@depid", cmbBoxDepID.SelectedValue);
            cmd.Parameters.AddWithValue("@patientid", cmbBoxPatientID.SelectedValue);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully.");
            showPatientReleaseInfo();
            ClearAllData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        
            if (txtBillNo.Text != "")
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("UPDATE PatientRelease SET ReleaseDate=@releasedate, TotalBill=@totalbill, DiscountRate=@discountrate, DepID=@depid, PatientID=@patientid WHERE BillNo=@billno", con);
                cmd.Parameters.AddWithValue("@billno", txtBillNo.Text);
                cmd.Parameters.AddWithValue("@releasedate", dtpReleaseDate.Text);
                cmd.Parameters.AddWithValue("@totalbill", txtTotalBill.Text);
                cmd.Parameters.AddWithValue("@discountrate", txtDiscountRate.Text);
                cmd.Parameters.AddWithValue("@depid", cmbBoxDepID.SelectedValue);
                cmd.Parameters.AddWithValue("@patientid", cmbBoxPatientID.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully.");
                showPatientReleaseInfo();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Bill No Not Found!!!!");
            }
        }
    }
}
