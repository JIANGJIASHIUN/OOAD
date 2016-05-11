using OOAD_HR_System.Class;
using OOAD_HR_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_HR_System
{
    public partial class _mainFunction : Form
    {
        EmployeeController employeeController = new EmployeeController();
        private Form _login = new Form();

        public _mainFunction(Form login)
        {
            _login = login;
            InitializeComponent();
        }

        private void CloseMainFunvrion(object sender, FormClosedEventArgs e)
        {
            _login.Visible = true;
        }

        private void ClickLogoutToolStripMenuItem(object sender, EventArgs e)
        {
            _login.Visible = true;
            this.Close();
        }

        private void ClickAddEmplDataButtonbutton(object sender, EventArgs e)
        {
            employeeController.SetId(string.Empty, _emplIdTextBox.Text);
            employeeController.SetName(_emplNameTextBox.Text);
            employeeController.SetSsn(_emplIdTextBox.Text, _ssnTextBox.Text);
            employeeController.SetSex(_emplIdTextBox.Text, _sexTextBox.Text);
            employeeController.SetBlood(_emplIdTextBox.Text, _bloodTextBox.Text);
            employeeController.SetPhone(_emplIdTextBox.Text,_phoneTextBox.Text);
            employeeController.SetAddress(_emplIdTextBox.Text,_addrTextBox.Text);
            employeeController.SetEmerPerson(_emplIdTextBox.Text,_emerPersonTextBox.Text);
            employeeController.SetEmerPhone(_emplIdTextBox.Text,_emerPhoneTextBox.Text);
            employeeController.SetMilitary(_emplIdTextBox.Text,_militaryTextBox.Text);
            employeeController.SetJobState(_emplIdTextBox.Text,_jobStateTextBox.Text);
            employeeController.SetMarriedState(_emplIdTextBox.Text,_marriedStateTextBox.Text);
            employeeController.SetSpouse(_emplIdTextBox.Text,_spouseTextBox.Text);
            employeeController.SetBirth(_emplIdTextBox.Text,_birthDateTimePicker.Value);
            employeeController.SetBasicSalary(_emplIdTextBox.Text,Convert.ToInt32(_basicSalaryTextBox.Text));
            employeeController.SetDeptId(_emplIdTextBox.Text,_deptIdTextBox.Text);
            employeeController.SetPositionId(_emplIdTextBox.Text,_positionIdTextBox.Text);
            MessageBox.Show("新增完成");
        }
    }
}
