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
        EmployeeController _employeeController = new EmployeeController();
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
            if (!_employeeController.SetId(string.Empty, _emplIdTextBox.Text))
            {
                MessageBox.Show("請輸入員工編號");
            }
            else if (!_employeeController.SetName(_emplNameTextBox.Text))
            {
                MessageBox.Show("請輸入員工姓名");
            }
            else if (!_employeeController.SetSsn(_emplIdTextBox.Text, _ssnTextBox.Text))
            {
                MessageBox.Show("請輸入正確的身分證字號");
            }
            else if (!_employeeController.SetSex(_emplIdTextBox.Text, _sexComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入性別");
            }
            else if (!_employeeController.SetBlood(_emplIdTextBox.Text, _bloodComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入血型");
            }
            else if (!_employeeController.SetPhone(_emplIdTextBox.Text, _phoneTextBox.Text))
            {
                MessageBox.Show("請輸入連絡電話");
            }
            else if (!_employeeController.SetAddress(_emplIdTextBox.Text, _addrTextBox.Text))
            {
                MessageBox.Show("請輸入住址");
            }
            else if (!_employeeController.SetEmerPerson(_emplIdTextBox.Text, _emerPersonTextBox.Text))
            {
                MessageBox.Show("請輸入緊急聯絡人");
            }
            else if (!_employeeController.SetEmerPhone(_emplIdTextBox.Text, _emerPhoneTextBox.Text))
            {
                MessageBox.Show("請輸入緊急聯絡人電話");
            }
            else if (!_employeeController.SetMilitary(_emplIdTextBox.Text, _militaryComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入兵役狀態");
            }
            else if (!_employeeController.SetJobState(_emplIdTextBox.Text, _jobStateComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入工作狀態");
            }
            else if (!_employeeController.SetMarriedState(_emplIdTextBox.Text, _marriedStateComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("請輸入婚姻狀態");
            }
            else if (!_employeeController.SetBasicSalary(_emplIdTextBox.Text, _basicSalaryTextBox.Text))
            {
                MessageBox.Show("請輸入底薪");
            }
            else if (!_employeeController.SetDeptId(_emplIdTextBox.Text, _deptIdTextBox.Text))
            {
                MessageBox.Show("請輸入部門編號");
            }
            else if (!_employeeController.SetPositionId(_emplIdTextBox.Text, _positionIdTextBox.Text))
            {
                MessageBox.Show("請輸入職位編號");
            }
            else
            {
                _employeeController.SetSpouse(_emplIdTextBox.Text, _spouseTextBox.Text);
                _employeeController.SetBirth(_emplIdTextBox.Text, _birthDateTimePicker.Value);
                _employeeController.InsertData();
                MessageBox.Show("新增完成");
            }
        }

        private void KeyPressNumberOnlyTextBox(object sender, KeyPressEventArgs e)
        {
            //不輸入輸入除了數字之外的所有非法字符的判斷                 
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
