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
            /*EmployeeClass ec = new EmployeeClass();
            ec.setId(string.Empty, _emplIdTextBox.Text);
            ec.setName(_emplNameTextBox.Text);
            ec.setSsn(_emplIdTextBox.Text, _ssnTextBox.Text);
            ec.setSex(_emplIdTextBox.Text, _sexTextBox.Text);
            ec.setBlood(_emplIdTextBox.Text, _bloodTextBox.Text);
            ec.setPhone(_emplIdTextBox.Text,_phoneTextBox.Text);
            ec.setAddress(_emplIdTextBox.Text,_addrTextBox.Text);
            ec.setEmerPerson(_emplIdTextBox.Text,_emerPersonTextBox.Text);
            ec.setEmerPhone(_emplIdTextBox.Text,_emerPhoneTextBox.Text);
            ec.setMilitary(_emplIdTextBox.Text,_militaryTextBox.Text);
            ec.setJobState(_emplIdTextBox.Text,_jobStateTextBox.Text);
            ec.setMarriedState(_emplIdTextBox.Text,_marriedStateTextBox.Text);
            ec.setSpouse(_emplIdTextBox.Text,_spouseTextBox.Text);
            ec.setBirth(_emplIdTextBox.Text,_birthDateTimePicker.Value);
            ec.setBasicSalary(_emplIdTextBox.Text,Convert.ToInt32(_basicSalaryTextBox.Text));
            ec.setDeptId(_emplIdTextBox.Text,_deptIdTextBox.Text);
            ec.setPositionId(_emplIdTextBox.Text,_positionIdTextBox.Text);*/
        }
    }
}
