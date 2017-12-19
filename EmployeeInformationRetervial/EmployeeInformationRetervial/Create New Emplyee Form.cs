using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationRetervial
{
    public partial class frmCreateNewEmployee : Form
    {
        public frmCreateNewEmployee()
        {
            InitializeComponent();
        }

        private void frmAPIPrac_Load(object sender, EventArgs e)
        {
            if(!ValidateData())
            {
                return;
            }
            if(!ConfirmPassword())
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            var client = new RestClient();
           //client.endPoint = @"https://cis294.hfcc.edu/api.php"; //real client
            client.endPoint = @"https://cislinux.hfcc.edu/~micah/shadowgames/api.php"; //micah test client
            client.httpMethod = httpVerb.POST;
            client.makeRequest("?login=1&password=123456&request=employee_insert&employee_f_name="+txtFName.Text+
                "&employee_l_name="+txtLName.Text+
                "&employee_phone="+txtNumber.Text+
                "&employee_email="+txtEmail.Text+
                "&employee_address="+txtAddress.Text+
                "&employee_address2="+txtAddress2.Text+
                "&employee_city="+txtCity.Text+
                "&employee_state="+txtState.Text+
                "&employee_zipcode="+txtZipcode.Text+
                "&employee_dob="+dtpDOB.Text+
                "&employee_hire_date="+dtpHireDate.Text+
                "&employee_job_title="+txtTitle.Text+
                "&employee_status="+cmbStatus.Text+
                "&employee_marital_status="+cmbMaritalStatus.Text+
                "&employee_num_dependents="+txtDependents.Text+
                "&employee_fed_tax="+txtFedDeductions.Text+
                "&employee_state_tax="+txtStateDeductions.Text+
                "&employee_pay_rate="+txtPayRate.Text+
                "&employee_report_to="+txtReportsTo.Text+
                "&employee_password="+txtPassword.Text);
            MessageBox.Show("Employee Created");
            this.Close();
        }

        private bool ConfirmPassword()
        {
            if(txtPassword.Text==txtConfirmPass.Text)
            {
                return true;
            }

            return false;
        }

        private void frmCreateNewEmployee_Load(object sender, EventArgs e)
        {
            txtFName.Text = "Anderson";
            txtLName.Text = "Lowe";
            txtEmail.Text = "AndersonLowe@gmail.com";
            txtPayRate.Text = "14.00";
            dtpHireDate.Text = "2018/01/01";
            txtNumber.Text = "313-666-6666";
            txtAddress.Text = "16500 quarry rd";
            txtAddress2.Text = "apt 233";
            txtCity.Text = "Southgate";
            txtState.Text = "Mi";
            txtZipcode.Text = "48146";
            dtpDOB.Text = "1990/1/1";
            txtTitle.Text = "Boss";
            cmbStatus.SelectedItem = "Available";
            cmbMaritalStatus.SelectedItem = "S";
            txtReportsTo.Text = "Owner";
            txtPassword.Text = "12345";
            txtConfirmPass.Text = "12345";
            txtDependents.Text = "1";
            txtFedDeductions.Text = "20";
            txtStateDeductions.Text = "20";
        }

        private bool ValidateData()
        {
            if(txtFName.Text.Length>35)
            {
                MessageBox.Show("Name cannot exceed 35 characters.");
                txtFName.Focus();
                return false;
            }
            else if(txtFName.Text=="")
            {
                MessageBox.Show("Must enter a first name.");
                txtFName.Focus();
                return false;
            }

            if (txtLName.Text.Length > 35)
            {
                MessageBox.Show("Name cannot exceed 35 characters.");
                txtLName.Focus();
                return false;
            }
            else if (txtLName.Text == "")
            {
                MessageBox.Show("Must enter a last name.");
                txtLName.Focus();
                return false;
            }

            if(txtEmail.Text.Length>64)
            {
                MessageBox.Show("Email cannot exceed 64 characters.");
                txtEmail.Focus();
                return false;
            }
            else if(txtEmail.Text.Contains("@")==false || txtEmail.Text.Contains(".")==false)
            {
                MessageBox.Show("Must enter a valid email.");
                txtEmail.Focus();
                return false;
            }
            else if(txtEmail.Text=="")
            {
                MessageBox.Show("Must enter a email.");
                txtEmail.Focus();
                return false;
            }

            if (!double.TryParse(txtPayRate.Text,out double result)){
                MessageBox.Show("You must enter a valid payrate.");
                txtPayRate.Focus();
                return false;
            }
            else if(double.Parse(txtPayRate.Text)<8.90)
            {
                MessageBox.Show("You cannot pay less than minimum wage ($8.90)");
                txtPayRate.Focus();
                return false;
            }
            else if(txtPayRate.Text=="")
            {
                MessageBox.Show("You must enter a payrate.");
                txtPayRate.Focus();
                return false;
            }
            Regex phoneNumpattern = new Regex(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$");
            if (!phoneNumpattern.IsMatch(txtNumber.Text))
            {
                MessageBox.Show("Phone number is not correct, enter in XXX-XXX-XXXX format");
                txtNumber.Focus();
                return false;
            }
            else if(txtNumber.Text=="")
            {
                MessageBox.Show("You must enter a phone number.");
                txtNumber.Focus();
                return false;
            }
            else if(txtNumber.Text.Length>20)
            {
                MessageBox.Show("Phone number cannot exceed 20 characters.");
                txtNumber.Focus();
                return false;
            }

            if(txtAddress.Text.Length>255)
            {
                MessageBox.Show("Address cannot exceed 255 characters.");
                txtAddress.Focus();
                return false;
            }
            else if(txtAddress.Text=="")
            {
                MessageBox.Show("Must enter an address.");
                txtAddress.Focus();
                return false;
            }

            if(txtAddress2.Text.Length>255)
            {
                MessageBox.Show("Address 2 cannot exceed 255 characters.");
                txtAddress2.Focus();
                return false;
            }

            if (txtCity.Text.Length>50)
            {
                MessageBox.Show("City cannot exceed 50 characters.");
                txtCity.Focus();
                return false;
            }
            else if(txtCity.Text=="")
            {
                MessageBox.Show("Must enter a city.");
                txtCity.Focus();
                return false;
            }

            if(txtState.Text.Length>2)
            {
                MessageBox.Show("City cannot exceed 2 characters, use state abbreviations.");
                txtState.Focus();
                return false;
            }
            else if(txtState.Text=="")
            {
                MessageBox.Show("Must enter an state.");
                txtState.Focus();
                return false;
            }

            if(txtZipcode.Text.Length<5 || txtZipcode.Text.Length>5)
            {
                MessageBox.Show("Zipcode must be exactly 5 numbers");
                txtZipcode.Focus();
                return false;
            }

            if(txtTitle.Text=="")
            {
                MessageBox.Show("Must enter a title");
                txtTitle.Focus();
                return false;
            }
            else if(txtTitle.Text.Length>255)
            {
                MessageBox.Show("Title cannot exceed 255 characters");
                txtTitle.Focus();
                return false;
            }

            if(txtReportsTo.Text=="")
            {
                MessageBox.Show("Must enter who employee reports to.");
                txtReportsTo.Focus();
                return false;
            }
            else if(txtReportsTo.Text.Length>50)
            {
                MessageBox.Show("Reports to cannot exceed 50 characters.");
                txtReportsTo.Focus();
                return false;
            }

            if(txtPassword.Text.Length<6)
            {
                MessageBox.Show("Password must be at least 6 characters");
                txtPassword.Focus();
                return false;
            }
            else if(txtPassword.Text.Length>64)
            {
                MessageBox.Show("Password cannot exceed 64 characters");
                txtPassword.Focus();
                return false;
            }

            if (txtDependents.Text == "")
            {
                MessageBox.Show("Must enter number of dependents");
                txtDependents.Focus();
                return false;
            }
            else if (!int.TryParse(txtDependents.Text, out int depResult))
            {
                MessageBox.Show("Must enter a valid number for dependents");
                txtDependents.Focus();
                return false;
            }
            else if(int.Parse(txtDependents.Text)>50) {
                MessageBox.Show("Dependents cannot exceed 50.");
                txtDependents.Focus();
                return false;
            }

            if (txtFedDeductions.Text == "")
            {
                MessageBox.Show("Must enter federal deductions");
                txtDependents.Focus();
                return false;
            }
            else if (!int.TryParse(txtFedDeductions.Text, out int fedResult))
            {
                MessageBox.Show("Must enter a valid number for federal deductions");
                txtDependents.Focus();
                return false;
            }
            else if (int.Parse(txtFedDeductions.Text) > 50)
            {
                MessageBox.Show("Federal deductions cannot exceed 50.");
                txtDependents.Focus();
                return false;
            }

            if (txtStateDeductions.Text == "")
            {
                MessageBox.Show("Must enter number of state deductions");
                txtDependents.Focus();
                return false;
            }
            else if (!int.TryParse(txtStateDeductions.Text, out int stateResult))
            {
                MessageBox.Show("Must enter a valid number for dependents");
                txtDependents.Focus();
                return false;
            }
            else if (int.Parse(txtStateDeductions.Text) > 50)
            {
                MessageBox.Show("State deductions cannot exceed 50.");
                txtDependents.Focus();
                return false;
            }



            return true;
        }

        private void txtPayRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
