using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
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

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DepartmentInformation depinfo = new DepartmentInformation();
            this.Hide();
            depinfo.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorInformation docinfo = new DoctorInformation();
            this.Hide();
            docinfo.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientInformation ptninfo = new PatientInformation();
            this.Hide();
            ptninfo.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmPatientReleaseInformation stfinfo = new frmPatientReleaseInformation();
            this.Hide();
            stfinfo.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            BillView billview = new BillView();
            billview.Show();
        }
    }
}
