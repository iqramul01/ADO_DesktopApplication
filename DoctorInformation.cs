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
using System.IO;


namespace HospitalManagementSystem
{
    public partial class DoctorInformation : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataRow dr;
        public DoctorInformation()
        {
            InitializeComponent();
            GetDepartmentID();
        }

        private void showDoctorInfo()
        {
            con = new SqlConnection(cs);
            adapter = new SqlDataAdapter("SELECT * FROM Doctor", con);
            dt = new DataTable();
            adapter.Fill(dt);
            dgDoctorInformation.DataSource = dt;
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

        private void DoctorInformation_Load(object sender, EventArgs e)
        {
            showDoctorInfo();
        }
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*jpg; *jpeg; *gif; *bmp;)|*jpg; *jpeg; *gif; *bmp;";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtDoctorImagePath.Text = openFile.FileName;
                picBoxDoctor.Image = new Bitmap(openFile.FileName);
            }
        }

        public void ClearAllData()
        {
            txtDoctorID.Text = "";
            txtDoctorName.Text = "";
            txtContactNumber.Text = "";
            txtContactAddress.Text = "";
            txtEmailAddress.Text = "";
            txtDoctorImagePath.Text = "";
            cmbBoxDepID.Text = "Department Name";           
        }
        private void dgDoctorInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDoctorID.Text = this.dgDoctorInformation.CurrentRow.Cells["DoctorID"].Value.ToString();
            txtDoctorName.Text = this.dgDoctorInformation.CurrentRow.Cells["DoctorName"].Value.ToString();
            txtContactNumber.Text = this.dgDoctorInformation.CurrentRow.Cells["ContactNumber"].Value.ToString();
            txtContactAddress.Text = this.dgDoctorInformation.CurrentRow.Cells["ContactAddress"].Value.ToString();
            txtEmailAddress.Text = this.dgDoctorInformation.CurrentRow.Cells["EmailAddress"].Value.ToString();
            txtDoctorImagePath.Text = this.dgDoctorInformation.CurrentRow.Cells["DoctorImage"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.Copy(txtDoctorImagePath.Text, Path.Combine(@"E:\MyDesktopApplication_Iqramul\HospitalManagementSystem\Images", Path.GetFileName(txtDoctorImagePath.Text)), true);


            con = new SqlConnection(cs);
            cmd = new SqlCommand("INSERT INTO Doctor(DoctorName, ContactNumber, ContactAddress, EmailAddress, DepID, DoctorImage) VALUES(@doctorname, @contactnumber, @contactaddress, @emailaddress, @depid, @doctorimage)", con);
            cmd.Parameters.AddWithValue("@doctorname", txtDoctorName.Text);
            cmd.Parameters.AddWithValue("@contactnumber", txtContactNumber.Text);
            cmd.Parameters.AddWithValue("@contactaddress", txtContactAddress.Text);
            cmd.Parameters.AddWithValue("@emailaddress", txtEmailAddress.Text);
            cmd.Parameters.AddWithValue("@depid",cmbBoxDepID.SelectedValue);
            cmd.Parameters.AddWithValue("@doctorimage", txtDoctorImagePath.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully.");
            showDoctorInfo();
            ClearAllData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDoctorID.Text != "")
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("UPDATE Doctor SET DoctorName=@doctorname, ContactNumber=@contactnumber, ContactAddress=@contactaddress, EmailAddress=@emailaddress, DepID=@depid, DoctorImage=@doctorimage WHERE DoctorID=@doctorid", con);
                cmd.Parameters.AddWithValue("@doctorid", txtDoctorID.Text);
                cmd.Parameters.AddWithValue("@doctorname", txtDoctorName.Text);
                cmd.Parameters.AddWithValue("@contactnumber", txtContactNumber.Text);
                cmd.Parameters.AddWithValue("@contactaddress", txtContactAddress.Text);
                cmd.Parameters.AddWithValue("@emailaddress", txtEmailAddress.Text);
                cmd.Parameters.AddWithValue("@depid", cmbBoxDepID.SelectedValue);
                cmd.Parameters.AddWithValue("@doctorimage", txtDoctorImagePath.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully.");
                showDoctorInfo();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Doctor ID Not Found!!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDoctorID.Text != "")
            {
                con = new SqlConnection(cs);
                cmd = new SqlCommand("DELETE FROM Doctor WHERE DoctorID=@doctorid", con);
                cmd.Parameters.AddWithValue("@doctorid", txtDoctorID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully.");

                showDoctorInfo();
                ClearAllData();
            }
            else
            {
                MessageBox.Show("Doctor ID Not Found!!!!");
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            this.Hide();
            home.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DoctorsReport doctorReport = new DoctorsReport();           
            doctorReport.Show();           
        }
    }
}
