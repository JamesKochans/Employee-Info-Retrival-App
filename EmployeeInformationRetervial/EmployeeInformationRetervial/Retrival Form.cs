using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EmployeeInformationRetervial
{
    public partial class frmEmployeeRetrevial : Form
    {
        Employees[] eArray;
        int intEmpID = 0;
        public frmEmployeeRetrevial()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes app
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the input and output fields
            txtEmployeeNumber.Text = "";
            txtEmployeeName.Text = "";
            txtEmployeeInformation.Text = "";
        }
        //loads an employee into the edit form
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtEmployeeInformation.Text=="")
            {
                MessageBox.Show("Please select an employee to edit.");
                return;
            }
            frmEditEmployeeInfo frmEdit = new frmEditEmployeeInfo(eArray,intEmpID);
            frmEdit.ShowDialog();
        }
        //loads the create employee form.
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            frmCreateNewEmployee frmCreate = new frmCreateNewEmployee();
            frmCreate.ShowDialog();
        }
        //makes the request to the API to the database for ALL employees
        private void frmAPIPrac_Load(object sender, EventArgs e)
        {

            var client = new RestClient();
            //client.endPoint = @"https://cis294.hfcc.edu/api.php"; //real client
            client.endPoint = @"https://cislinux.hfcc.edu/~micah/shadowgames/api.php"; //micah test client
            client.httpMethod = httpVerb.GET;
            // intEmpID =  (int.Parse(txtEmployeeNumber.Text)-1);
            //string jsonText = client.makeRequest("?login=1&password=123456&request=employee_list");
            string jsonText = client.makeRequest("?request=employee_list&login=1&password=123456");
  
            //Create a list and fill with deserialized data from api
            List<Employees> empList = JsonConvert.DeserializeObject<List<Employees>>(jsonText);
            eArray = empList.ToArray();
            //searches through the employee for the SPEICFIC employee they asked for by name or number.
            try
            {
                if (txtEmployeeNumber.Text != "")
                {
                    intEmpID = (int.Parse(txtEmployeeNumber.Text) - 1);
                    for (int i = 0; i < eArray.Length; i++)
                    {
                        if (i == intEmpID)
                        {
                            txtEmployeeInformation.Text = "EmployeeID: ";
                            txtEmployeeInformation.Text += eArray[i].EmployeeID + Environment.NewLine;
                            txtEmployeeInformation.Text += "Name: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_F_Name;
                            txtEmployeeInformation.Text += " ";
                            txtEmployeeInformation.Text += eArray[i].Employee_L_Name + Environment.NewLine;
                            txtEmployeeInformation.Text += "Address: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Address + Environment.NewLine;
                            txtEmployeeInformation.Text += eArray[i].Employee_Address2 + Environment.NewLine;
                            txtEmployeeInformation.Text += "City: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_City + Environment.NewLine;
                            txtEmployeeInformation.Text += "State: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_State + Environment.NewLine;
                            txtEmployeeInformation.Text += "ZipCode: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_ZipCode + Environment.NewLine;
                            txtEmployeeInformation.Text += "Phone: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Phone + Environment.NewLine;
                            txtEmployeeInformation.Text += "Email: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Email + Environment.NewLine;
                            txtEmployeeInformation.Text += "Date of birth: ";
                            txtEmployeeInformation.Text += Convert.ToDateTime(eArray[i].Employee_DOB).ToShortDateString() + Environment.NewLine;
                            txtEmployeeInformation.Text += "Date of hire: ";
                            txtEmployeeInformation.Text += Convert.ToDateTime(eArray[i].Employee_HireDate).ToShortDateString() + Environment.NewLine;
                            txtEmployeeInformation.Text += "Job title: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_JobTitle + Environment.NewLine;
                            txtEmployeeInformation.Text += "Status: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Status + Environment.NewLine;
                            txtEmployeeInformation.Text += "Marital status: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Marital_Status + Environment.NewLine;
                            txtEmployeeInformation.Text += "Number of dependents: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Num_Dependents + Environment.NewLine;
                            txtEmployeeInformation.Text += "Federal Tax deductions: $";
                            txtEmployeeInformation.Text += eArray[i].Employee_Fed_Tax + Environment.NewLine;
                            txtEmployeeInformation.Text += "State tax deductions: $";
                            txtEmployeeInformation.Text += eArray[i].Employee_State_Tax + Environment.NewLine;
                            txtEmployeeInformation.Text += "Payrate: $";
                            txtEmployeeInformation.Text += eArray[i].Employee_PayRate + Environment.NewLine;
                            txtEmployeeInformation.Text += "Reports to: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_ReportTo + Environment.NewLine;
                            //txtEmployeeInformation.Text += "Password: ";
                            //txtEmployeeInformation.Text += eArray[intEmpID].Employee_Password + Environment.NewLine;
                            intEmpID = i;
                            return;
                        }
                    }
                }

                else if (txtEmployeeName.Text != "")
                {
                    string strEmpName = txtEmployeeName.Text;
                    for (int i = 0; i < eArray.Length; i++)
                    {
                        if (strEmpName == eArray[i].Employee_F_Name + " " + eArray[i].Employee_L_Name)
                        {
                            txtEmployeeInformation.Text = "EmployeeID: ";
                            txtEmployeeInformation.Text += eArray[i].EmployeeID + Environment.NewLine;
                            txtEmployeeInformation.Text += "Name: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_F_Name;
                            txtEmployeeInformation.Text += " ";
                            txtEmployeeInformation.Text += eArray[i].Employee_L_Name + Environment.NewLine;
                            txtEmployeeInformation.Text += "Address: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Address + Environment.NewLine;
                            txtEmployeeInformation.Text += eArray[i].Employee_Address2 + Environment.NewLine;
                            txtEmployeeInformation.Text += "City: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_City + Environment.NewLine;
                            txtEmployeeInformation.Text += "State: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_State + Environment.NewLine;
                            txtEmployeeInformation.Text += "ZipCode: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_ZipCode + Environment.NewLine;
                            txtEmployeeInformation.Text += "Phone: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Phone + Environment.NewLine;
                            txtEmployeeInformation.Text += "Email: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Email + Environment.NewLine;
                            txtEmployeeInformation.Text += "Date of birth: ";
                            txtEmployeeInformation.Text += Convert.ToDateTime(eArray[i].Employee_DOB).ToShortDateString() + Environment.NewLine;
                            txtEmployeeInformation.Text += "Date of hire: ";
                            txtEmployeeInformation.Text += Convert.ToDateTime(eArray[i].Employee_HireDate).ToShortDateString() + Environment.NewLine;
                            txtEmployeeInformation.Text += "Job title: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_JobTitle + Environment.NewLine;
                            txtEmployeeInformation.Text += "Status: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Status + Environment.NewLine;
                            txtEmployeeInformation.Text += "Marital status: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Marital_Status + Environment.NewLine;
                            txtEmployeeInformation.Text += "Number of dependents: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_Num_Dependents + Environment.NewLine;
                            txtEmployeeInformation.Text += "Federal Tax deductions: $";
                            txtEmployeeInformation.Text += eArray[i].Employee_Fed_Tax + Environment.NewLine;
                            txtEmployeeInformation.Text += "State tax deductions: $";
                            txtEmployeeInformation.Text += eArray[i].Employee_State_Tax + Environment.NewLine;
                            txtEmployeeInformation.Text += "Payrate: $";
                            txtEmployeeInformation.Text += eArray[i].Employee_PayRate + Environment.NewLine;
                            txtEmployeeInformation.Text += "Reports to: ";
                            txtEmployeeInformation.Text += eArray[i].Employee_ReportTo + Environment.NewLine;
                            //txtEmployeeInformation.Text += "Password: ";
                            //txtEmployeeInformation.Text += eArray[intEmpID].Employee_Password + Environment.NewLine;
                            intEmpID = i;
                            return;
                        }
                    }
                }
                MessageBox.Show("Employee not found");
                txtEmployeeInformation.Clear();
                intEmpID = 0;

            }

            catch
            {
                MessageBox.Show("Invalid Entry");
                txtEmployeeName.Text = "";
                txtEmployeeNumber.Text = "";
                txtEmployeeNumber.Focus();
            }
        }
        //clears name/emp number if they start searching for the other. Or vice/versa
        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            txtEmployeeNumber.Text = "";
        }

        private void txtEmployeeNumber_TextChanged(object sender, EventArgs e)
        {
            txtEmployeeName.Text = "";
        }
        //Only allows numbers
        private void txtPayRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        //only allows letters
        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
