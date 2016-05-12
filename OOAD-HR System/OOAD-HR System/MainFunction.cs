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
            if (!employeeController.SetId(string.Empty, _emplIdTextBox.Text))
            {
                MessageBox.Show("請輸入員工編號");
            }
            else if (!employeeController.SetName(_emplNameTextBox.Text))
            {
                MessageBox.Show("請輸入員工姓名");
            }
            else if (!employeeController.SetSsn(_emplIdTextBox.Text, _ssnTextBox.Text))
            {
                MessageBox.Show("請輸入正確的身分證字號");
            }
            else if (!employeeController.SetSex(_emplIdTextBox.Text, _sexComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入性別");
            }
            else if (!employeeController.SetBlood(_emplIdTextBox.Text, _bloodComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入血型");
            }
            else if (!employeeController.SetPhone(_emplIdTextBox.Text, _phoneTextBox.Text))
            {
                MessageBox.Show("請輸入連絡電話");
            }
            else if (!employeeController.SetAddress(_emplIdTextBox.Text, _addrTextBox.Text))
            {
                MessageBox.Show("請輸入住址");
            }
            else if (!employeeController.SetEmerPerson(_emplIdTextBox.Text, _emerPersonTextBox.Text))
            {
                MessageBox.Show("請輸入緊急聯絡人");
            }
            else if (!employeeController.SetEmerPhone(_emplIdTextBox.Text, _emerPhoneTextBox.Text))
            {
                MessageBox.Show("請輸入緊急聯絡人電話");
            }
            else if (!employeeController.SetMilitary(_emplIdTextBox.Text, _militaryComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入兵役狀態");
            }
            else if (!employeeController.SetJobState(_emplIdTextBox.Text, _jobStateTextBox.Text))
            {
                MessageBox.Show("請輸入工作狀態");
            }
            else if (!employeeController.SetMarriedState(_emplIdTextBox.Text, _marriedStateComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入婚姻狀態");
            }
            else if (!employeeController.SetBasicSalary(_emplIdTextBox.Text, _basicSalaryTextBox.Text))
            {
                MessageBox.Show("請輸入底薪");
            }
            else if (!employeeController.SetDeptId(_emplIdTextBox.Text, _deptIdTextBox.Text))
            {
                MessageBox.Show("請輸入部門編號");
            }
            else if (!employeeController.SetPositionId(_emplIdTextBox.Text, _positionIdTextBox.Text))
            {
                MessageBox.Show("請輸入職位編號");
            }
            else
            {
                employeeController.SetSpouse(_emplIdTextBox.Text, _spouseTextBox.Text);
                employeeController.SetBirth(_emplIdTextBox.Text, _birthDateTimePicker.Value);
                MessageBox.Show("新增完成");
            }
        }

        private void KeyPressNumberOnlyTextBox(object sender, KeyPressEventArgs e)
        {
            //不輸入輸入除了數字之外的所有非法字符的判斷                 
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }
    }
}
