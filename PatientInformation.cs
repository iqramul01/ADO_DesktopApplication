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



namespace HospitalManagementSystem
{
    public partial class PatientInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow dr;
        string gender;

        public PatientInformation()
        {
            InitializeComponent();
            GetDepartmentID();
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
        private void showPatientAdmitInfo()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM PatientAdmit", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgPatientAdmitInfo.DataSource = dt;
        }
        private void PatientInformation_Load(object sender, EventArgs e)
        {
          
            showPatientAdmitInfo();
        }

        public void ClearAllData()
        {
            txtPatientID.Text = "";
            txtPatientName.Text = "";
            txtBloodGroup.Text = "";
            txtAdmitFee.Text = "";
            txtEmergencyContact.Text = "";
        }

        private void rdoButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdoButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void rdoButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Other";
        }

        private void dgPatientAdmitInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPatientID.Text = this.dgPatientAdmitInfo.CurrentRow.Cells["PatientID"].Value.ToString();
            txtPatientName.Text = this.dgPatientAdmitInfo.CurrentRow.Cells["PatientName"].Value.ToString();
            txtBloodGroup.Text = this.dgPatientAdmitInfo.CurrentRow.Cells["BloodGroup"].Value.ToString();       
            txtEmergencyContact.Text = this.dgPatientAdmitInfo.CurrentRow.Cells["EmergencyContact"].Value.ToString();           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            cmd = new SqlCommand("EXEC sp_PatientAddInsert @patientid,@patientname,@gender,@bloodgroup,@admitdate,@admitfee,@emergencycontact,@depid", con);

            cmd.Parameters.AddWithValue("@patientid", txtPatientID.Text);
            cmd.Parameters.AddWithValue("@patientname", txtPatientName.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@bloodgroup", txtBloodGroup.Text);
            cmd.Parameters.AddWithValue("@admitdate", dtpickerPatientAdmit.Text);
            cmd.Parameters.AddWithValue("@admitfee", txtAdmitFee.Text);
            cmd.Parameters.AddWithValue("@emergencycontact", txtEmergencyContact.Text);
            cmd.Parameters.AddWithValue("@depid", cmbBoxDepID.SelectedValue);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully.");
            showPatientAdmitInfo();
            ClearAllData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text != "")
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("UPDATE PatientAdmit SET PatientName=@patientname, BloodGroup=@bloodgroup,Gender=@gender, AdmitDate=@admitdate, AdmitFee=@admitfee, EmergencyContact=@emergencycontact WHERE PatientID=@patientid", con);
                cmd.Parameters.AddWithValue("@patientid", txtPatientID.Text);
                cmd.Parameters.AddWithValue("@patientname", txtPatientName.Text);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@bloodgroup", txtBloodGroup.Text);
                cmd.Parameters.AddWithValue("@admitdate", dtpickerPatientAdmit.Text);
                cmd.Parameters.AddWithValue("@admitfee", txtAdmitFee.Text);
                cmd.Parameters.AddWithValue("@emergencycontact", txtEmergencyContact.Text);
                //cmd.Parameters.AddWithValue("@dipid", cmbBoxDepID.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully.");
                showPatientAdmitInfo();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Patient ID Not Found!!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPatientID.Text != "")
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("DELETE FROM PatientAdmit WHERE PatientID=@patientid", con);
                cmd.Parameters.AddWithValue("@patientid", txtPatientID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully.");

                showPatientAdmitInfo();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Patient ID Not Found!!!!");
            }
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
    }
}
