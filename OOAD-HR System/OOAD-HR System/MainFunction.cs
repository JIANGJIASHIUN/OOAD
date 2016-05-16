﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_HR_System.PresentationModel;
using OOAD_HR_System.Controller;

namespace OOAD_HR_System
{
    public partial class _mainFunction : Form
    {

        private Form _login = new Form();
        private EmployeePresentationModel _employeePresentationModel = new EmployeePresentationModel();
        private EmployeeController _employeeController;

        public _mainFunction(Form login)
        {
            _login = login;

            InitializeComponent();
        }

        // form load
        private void LoadMainFunction(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'positionDataSet.position' 資料表。您可以視需要進行移動或移除。
            this.positionTableAdapter.Fill(this.positionDataSet.position);
            // TODO:  這行程式碼會將資料載入 'deptDataSet.department' 資料表。您可以視需要進行移動或移除。
            this.departmentTableAdapter.Fill(this.deptDataSet.department);

            // 設置所有UI的預設值
            this.ResetNewEmplUI();
            this.ResetEditEmplUI();
        }

        // reset all add employee UI 預設值
        private void ResetNewEmplUI() 
        {
            _newEmplJobStatCB.SelectedIndex = 0;
            _newEmplMarriedStatCB.SelectedIndex = 0;
            _newEmplMilitaryStatCB.SelectedIndex = 0;
            _newEmplBloodCB.SelectedIndex = 0;
            _newEmplSexCB.SelectedIndex = 0;
            this.SetAllNewEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _newEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // reset all edit employee UI
        private void ResetEditEmplUI()
        {
            _editEmplJobStatCB.SelectedIndex = 0;
            _editEmplMarriedStatCB.SelectedIndex = 0;
            _editEmplMilitaryStatCB.SelectedIndex = 0;
            _editEmplBloodCB.SelectedIndex = 0;
            _editEmplSexCB.SelectedIndex = 0;
            _editEmplDeptCB.SelectedIndex = 0;
            _editEmplPositionCB.SelectedIndex = 0;
            _editEmplBirthDTP.Value = DateTime.Now;
            this.SetAllEditEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _editEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // 設置查詢後 all edit employee UI
        private void ResetSearchEditEmplUI()
        {
            _editEmplBirthDTP.Value = _employeePresentationModel.GetBirth();
            _editEmplMarriedStatCB.SelectedItem = _employeePresentationModel.GetMarriedStatus();
            // 1 為未婚
            // 0 為已婚
            if (_editEmplMarriedStatCB.SelectedIndex == 1)
            {
                _editEmplSpouseTB.Text = _employeePresentationModel.GetSpouse();
            }
            else if (_editEmplMarriedStatCB.SelectedIndex == 0)
            {
                _editEmplSpouseTB.ReadOnly = true;
                _editEmplSpouseTB.Text = null;
            }
            _editEmplJobStatCB.SelectedItem = _employeePresentationModel.GetJobStatus(); 
            _editEmplMilitaryStatCB.SelectedItem = _employeePresentationModel.GetMilitaryStatus();
            _editEmplBloodCB.SelectedItem = _employeePresentationModel.GetBlood();
            _editEmplSexCB.SelectedItem = _employeePresentationModel.GetSex();
            _editEmplNameTB.Text = _employeePresentationModel.GetName();
            _editEmplSsnTB.Text = _employeePresentationModel.GetSsn(); ;
            _editEmplAddrTB.Text = _employeePresentationModel.GetAddress();
            _editEmplEmerPersonTB.Text = _employeePresentationModel.GetEmerPerson();
            _editEmplEmerPhoneTB.Text = _employeePresentationModel.GetEmerPhone();
            _editEmplBasicSalaryTB.Text = _employeePresentationModel.GetBasicSalary().ToString();
            _editEmplPhoneTB.Text = _employeePresentationModel.GetPhone();
            _editEmplDeptCB.SelectedValue = _employeePresentationModel.GetDeptID();
            _editEmplPositionCB.SelectedValue = _employeePresentationModel.GetPositionID();
        }

        // 按下登出鍵
        private void ClickLogoutButton(object sender, EventArgs e)
        {
            _login.Visible = true;
            this.Close();
        }

        // 按下右上角關閉
        private void CloseMainFunction(object sender, FormClosedEventArgs e)
        {
            _login.Visible = true;
        }

        // 根據婚姻狀況修改配偶欄是否可以填寫(new)
        private void ChangedNewEmplMarriedStatCBSelectedIndex(object sender, EventArgs e)
        {
            // 1 為未婚
            // 0 為已婚
            if (_newEmplMarriedStatCB.SelectedIndex == 1)
            {
                _newEmplSpouseTB.ReadOnly = false;
            }
            else if (_newEmplMarriedStatCB.SelectedIndex == 0)
            {
                _newEmplSpouseTB.ReadOnly = true;
                _newEmplSpouseTB.Text = null;
            }
        }

        // 根據婚姻狀況修改配偶欄是否可以填寫(edit)
        private void ChangedEditEmplMarriedStatCBSelectedIndex(object sender, EventArgs e)
        {
            // 1 為未婚
            // 0 為已婚
            if (_editEmplMarriedStatCB.SelectedIndex == 1)
            {
                _editEmplSpouseTB.ReadOnly = false;
            }
            else if (_editEmplMarriedStatCB.SelectedIndex == 0)
            {
                _editEmplSpouseTB.ReadOnly = true;
                _editEmplSpouseTB.Text = null;
            }
        }

        // 根據選取職位 顯示職位底薪(new)
        private void ChangedNewEmplPositionCBSelectedIndex(object sender, EventArgs e)
        {
            this.SetAllNewEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _newEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // 根據選取職位 顯示職位底薪(edit)
        private void ChangedEditEmplPositionCBSelectedIndex(object sender, EventArgs e)
        {
            this.SetAllEditEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _editEmplBasicSalaryTB.Text = _employeeController.SearchBasicSalaryByPositionID();
        }

        // 將UI上的empl變數存入presentationModel中(new)
        private void SetAllNewEmplVariableToPM()
        {
            String emplID = _newEmplIDTB.Text;  
            String emplName = _newEmplNameTB.Text;
            String ssn = _newEmpllSsnTB.Text;
            String sex = _newEmplSexCB.SelectedItem.ToString();
            String blood = _newEmplBloodCB.SelectedItem.ToString();
            String phone = _newEmplPhoneTB.Text;
            String addr = _newEmplAddrTB.Text;
            String emerPerson = _newEmplEmerPersonTB.Text;
            String emerPhone = _newEmplEmerPhoneTB.Text;
            String military = _newEmplMilitaryStatCB.SelectedItem.ToString();
            String jobState = _newEmplJobStatCB.SelectedItem.ToString();
            String marriedState = _newEmplMarriedStatCB.SelectedItem.ToString();
            String spouse = _newEmplSpouseTB.Text;
            DateTime birth = _newEmplBirthDP.Value;
            if (_newEmplBasicSalaryTB.Text == "")
                _newEmplBasicSalaryTB.Text = "0";
            float basicSalary = System.Convert.ToSingle(_newEmplBasicSalaryTB.Text);
            String deptID = "";
            String positionID = "";
            if (_newEmplDeptCB.SelectedValue != null)
                deptID = _newEmplDeptCB.SelectedValue.ToString();
            if (_newEmplPositionCB.SelectedValue != null)
                positionID = _newEmplPositionCB.SelectedValue.ToString();

            _employeePresentationModel.SetEmplID(emplID);
            _employeePresentationModel.SetName(emplName);
            _employeePresentationModel.SetSsn(ssn);
            _employeePresentationModel.SetSex(sex);
            _employeePresentationModel.SetBlood(blood);
            _employeePresentationModel.SetPhone(phone);
            _employeePresentationModel.SetAddress(addr);
            _employeePresentationModel.SetEmerPerson(emerPerson);
            _employeePresentationModel.SetEmerPhone(emerPhone);
            _employeePresentationModel.SetMilitaryStatus(military);
            _employeePresentationModel.SetJobStatus(jobState);
            _employeePresentationModel.SetMarriedStatus(marriedState);
            _employeePresentationModel.SetSpouse(spouse);
            _employeePresentationModel.SetBirth(birth);
            _employeePresentationModel.SetBasicSalary(basicSalary);
            _employeePresentationModel.SetDeptID(deptID);
            _employeePresentationModel.SetPositoinID(positionID);
        }

        // 將UI上的empl變數存入presentationModel中(edit)
        private void SetAllEditEmplVariableToPM()
        {
            String emplID = _editEmplIDTB.Text;
            String emplName = _editEmplNameTB.Text;
            String ssn = _editEmplSsnTB.Text;
            String sex = _editEmplSexCB.SelectedItem.ToString();
            String blood = _editEmplBloodCB.SelectedItem.ToString();
            String phone = _editEmplPhoneTB.Text;
            String addr = _editEmplAddrTB.Text;
            String emerPerson = _editEmplEmerPersonTB.Text;
            String emerPhone = _editEmplEmerPhoneTB.Text;
            String military = _editEmplMilitaryStatCB.SelectedItem.ToString();
            String jobState = _editEmplJobStatCB.SelectedItem.ToString();
            String marriedState = _editEmplMarriedStatCB.SelectedItem.ToString();
            String spouse = _editEmplSpouseTB.Text;
            DateTime birth = _editEmplBirthDTP.Value;
            if (_editEmplBasicSalaryTB.Text == "")
                _editEmplBasicSalaryTB.Text = "0";
            float basicSalary = System.Convert.ToSingle(_editEmplBasicSalaryTB.Text);
            String deptID = "";
            String positionID = "";
            if (_editEmplDeptCB.SelectedValue != null)
                deptID = _editEmplDeptCB.SelectedValue.ToString();
            if (_editEmplPositionCB.SelectedValue != null)
                positionID = _editEmplPositionCB.SelectedValue.ToString();

            _employeePresentationModel.SetEmplID(emplID);
            _employeePresentationModel.SetName(emplName);
            _employeePresentationModel.SetSsn(ssn);
            _employeePresentationModel.SetSex(sex);
            _employeePresentationModel.SetBlood(blood);
            _employeePresentationModel.SetPhone(phone);
            _employeePresentationModel.SetAddress(addr);
            _employeePresentationModel.SetEmerPerson(emerPerson);
            _employeePresentationModel.SetEmerPhone(emerPhone);
            _employeePresentationModel.SetMilitaryStatus(military);
            _employeePresentationModel.SetJobStatus(jobState);
            _employeePresentationModel.SetMarriedStatus(marriedState);
            _employeePresentationModel.SetSpouse(spouse);
            _employeePresentationModel.SetBirth(birth);
            _employeePresentationModel.SetBasicSalary(basicSalary);
            _employeePresentationModel.SetDeptID(deptID);
            _employeePresentationModel.SetPositoinID(positionID);
        }
        
        // 按下新增員工按鈕
        private void ClickAddEmplButton(object sender, EventArgs e)
        {
            this.SetAllNewEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            _employeeController.AddEmployee();
        }

        // 按下修改員工資料按鈕
        private void ClickEditEmplButtom(object sender, EventArgs e)
        {
            this.SetAllEditEmplVariableToPM();

            _employeeController = new EmployeeController(_employeePresentationModel);
            if (_employeeController.EditEmployee())
            {
                this.SetAllEditToNotEnable();
                this.ResetEditEmplUI();
            }
        }

        // 設置所有編輯的UI 可以更改
        private void SetAllEditToNotEnable()
        {
            _editEmplIDTB.ReadOnly = false;
            _editEmplIDTB.Text = "";
            _editEmplNameTB.ReadOnly = true;
            _editEmplNameTB.Text = "";
            _editEmplSsnTB.ReadOnly = true;
            _editEmplSsnTB.Text = "";
            _editEmplAddrTB.ReadOnly = true;
            _editEmplAddrTB.Text = "";
            _editEmplEmerPersonTB.ReadOnly = true;
            _editEmplEmerPersonTB.Text = "";
            _editEmplEmerPhoneTB.ReadOnly = true;
            _editEmplEmerPhoneTB.Text = "";
            _editEmplBasicSalaryTB.ReadOnly = true;
            _editEmplBasicSalaryTB.Text = "";
            _editEmplPhoneTB.ReadOnly = true;
            _editEmplPhoneTB.Text = "";
            _editEmplSpouseTB.ReadOnly = true;
            _editEmplSpouseTB.Text = "";
            _editEmplJobStatCB.Enabled = false;
            _editEmplJobStatCB.Text = "";
            _editEmplDeptCB.Enabled = false;
            _editEmplDeptCB.Text = "";
            _editEmplPositionCB.Enabled = false;
            _editEmplPositionCB.Text = "";
            _editEmplSexCB.Enabled = false;
            _editEmplSexCB.Text = "";
            _editEmplBloodCB.Enabled = false;
            _editEmplBloodCB.Text = "";
            _editEmplMilitaryStatCB.Enabled = false;
            _editEmplMarriedStatCB.Enabled = false;
            _editEmplButton.Enabled = false;
            _editEmplBirthDTP.Enabled = false;
        }

        // 設置所有編輯的UI 可以更改
        private void SetAllEditToEnable()
        {
            _editEmplIDTB.ReadOnly = true;
            _editEmplNameTB.ReadOnly = false;
            _editEmplSsnTB.ReadOnly = false;
            _editEmplAddrTB.ReadOnly = false;
            _editEmplEmerPersonTB.ReadOnly = false;
            _editEmplEmerPhoneTB.ReadOnly = false;
            _editEmplBasicSalaryTB.ReadOnly = false;
            _editEmplPhoneTB.ReadOnly = false;
            _editEmplSpouseTB.ReadOnly = false;
            _editEmplJobStatCB.Enabled = true;
            _editEmplDeptCB.Enabled = true;
            _editEmplPositionCB.Enabled = true;
            _editEmplSexCB.Enabled = true;
            _editEmplBloodCB.Enabled = true;
            _editEmplMilitaryStatCB.Enabled = true;
            _editEmplMarriedStatCB.Enabled = true;
            _editEmplButton.Enabled = true;
            _editEmplBirthDTP.Enabled = true;
        }

        // 按下查詢員工按鈕
        private void ClickSearchEmplButtom(object sender, EventArgs e)
        {
            String emplID = _editEmplIDTB.Text;
            _employeePresentationModel.SetEmplID(emplID);

            _employeeController = new EmployeeController(_employeePresentationModel);
            _employeePresentationModel = _employeeController.SearchDataByEmplID();

            if (_employeePresentationModel.GetEmplID() == null || _employeePresentationModel.GetEmplID() == "")
                return;

            this.SetAllEditToEnable();
            this.ResetSearchEditEmplUI();
        }

    }
}
