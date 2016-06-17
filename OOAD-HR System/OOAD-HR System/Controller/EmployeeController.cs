﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_HR_System.PresentationModel;
using OOAD_HR_System.Model;
using OOAD_HR_System.Service;
using System.Text.RegularExpressions;


namespace OOAD_HR_System.Controller
{
    public class EmployeeController
    {

        private EmployeeModel _employeeModel = new EmployeeModel();
        private PositionModel _positionModel = new PositionModel();
        private EmployeeService _employeeService;
        private PositionService _positionService;

        // 建構子
        public EmployeeController(EmployeePresentationModel employeePresentationModel)
        {
            this._employeeModel.SetEmplID(employeePresentationModel.GetEmplID());
            this._employeeModel.SetName(employeePresentationModel.GetName());
            this._employeeModel.SetSsn(employeePresentationModel.GetSsn());
            this._employeeModel.SetSex(employeePresentationModel.GetSex());
            this._employeeModel.SetPhone(employeePresentationModel.GetPhone());
            this._employeeModel.SetAddress(employeePresentationModel.GetAddress());
            this._employeeModel.SetBlood(employeePresentationModel.GetBlood());
            this._employeeModel.SetBirth(employeePresentationModel.GetBirth());
            this._employeeModel.SetEmerPerson(employeePresentationModel.GetEmerPerson());
            this._employeeModel.SetEmerPhone(employeePresentationModel.GetEmerPhone());
            this._employeeModel.SetMilitaryStatus(employeePresentationModel.GetMilitaryStatus());
            this._employeeModel.SetJobStatus(employeePresentationModel.GetJobStatus());
            this._employeeModel.SetMarriedStatus(employeePresentationModel.GetMarriedStatus());
            this._employeeModel.SetSpouse(employeePresentationModel.GetSpouse());
            this._employeeModel.SetDeptID(employeePresentationModel.GetDeptID());
            this._employeeModel.SetPositoinID(employeePresentationModel.GetPositionID());
            this._employeeModel.SetBasicSalary(employeePresentationModel.GetBasicSalary());
            this._employeeModel.SetEmplLoginPassword(employeePresentationModel.GetEmplLoginPassword());
        }

        // 判斷各個員工資料格式是否錯誤
        private int JudgeEmplDataFormat()
        {
            int errorFlag = 0;

            if (this._employeeModel.GetEmplID() == "" || this._employeeModel.GetName() == "" || this._employeeModel.GetSsn() == "" || this._employeeModel.GetPhone() == "" ||
                this._employeeModel.GetAddress() == "" || this._employeeModel.GetEmerPerson() == "" || this._employeeModel.GetEmerPhone() == "" || this._employeeModel.GetEmplLoginPassword() == "" ||
                (this._employeeModel.GetMarriedStatus() == "已婚" && this._employeeModel.GetSpouse() == ""))
            {
                MessageBox.Show("尚有欄位為空白, 請重新確認是否填寫完畢!");
                errorFlag = 1;
            }
            else
            {
                if (this.JudgeSsnValid(this._employeeModel.GetSsn()) == false)
                {
                    MessageBox.Show("Ssn格式錯誤!");
                    errorFlag = 1;
                }
                if (this.JudgePhoneFormat(this._employeeModel.GetPhone()) == false)
                {
                    MessageBox.Show("連絡電話格式錯誤!");
                    errorFlag = 1;
                }
                if (this.JudgePhoneFormat(this._employeeModel.GetEmerPhone()) == false)
                {
                    MessageBox.Show("緊急連絡電話格式錯誤!");
                    errorFlag = 1;
                }
                if (this.JudgeBasicSalaryRange(this._employeeModel.GetPositionID(), this._employeeModel.GetBasicSalary()) == false)
                {
                    MessageBox.Show("輸入底薪範圍超過該職位底薪之正負5000");
                    errorFlag = 1;
                }
            }

            return errorFlag;
        }

        // 呼叫service, 將資料新增至資料庫
        public void AddEmployee()
        {
            this._employeeService = new EmployeeService(this._employeeModel);
            AccountService accountService = new AccountService(this._employeeModel.GetEmplID(), this._employeeModel.GetEmplLoginPassword());

            int errorFlag = 0;

            errorFlag = JudgeEmplDataFormat();

            if (errorFlag == 1)
                return;

            // 新增員工資料與帳號資訊
            if (_employeeService.AddEmployee() && accountService.AddAccount())
                MessageBox.Show("新增成功!");
            else
                MessageBox.Show("新增失敗!");
        }

        // 呼叫service, 將資料更新制資料庫(edit)
        public Boolean EditEmployee()
        {
            this._employeeService = new EmployeeService(this._employeeModel);

            int errorFlag = 0;

            errorFlag = JudgeEmplDataFormat();

            if (errorFlag == 1)
                return false;

            if (_employeeService.EditEmployee())
                MessageBox.Show("修改成功!");
            else
            {
                MessageBox.Show("修改失敗!");
                return false;
            }

            return true;
        }

        // 呼叫position service利用所選取之職位查詢該職位底薪
        public String SearchBasicSalaryByPositionID()
        {
            String positionID = this._employeeModel.GetPositionID();
            this._positionModel.SetId(positionID);

            this._positionService = new PositionService(this._positionModel);

            this._positionModel = _positionService.SearchBsicSalaryByPositionID();

            return this._positionModel.GetBasicSalary().ToString();
        }

        // 取得與開頭英文字母相對應之數字
        private int[] ConvertSsnStartCharToInt(String ssnStartChar)
        {
            int[] ssnStartCharInt = new int[2];
            switch (ssnStartChar)
            {
                case "A" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 0;
                    break;
                case "B" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 1;
                    break;
                case "C" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 2;
                    break;
                case "D" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 3;
                    break;
                case "E" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 4;
                    break;
                case "F" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 5;
                    break;
                case "G" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 6;
                    break;
                case "H" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 7;
                    break;
                case "I" :
                    ssnStartCharInt[0] = 3;
                    ssnStartCharInt[1] = 4;
                    break;
                case "J" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 8;
                    break;
                case "K" :
                    ssnStartCharInt[0] = 1;
                    ssnStartCharInt[1] = 9;
                    break;
                case "L" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 0;
                    break;
                case "M" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 1;
                    break;
                case "N" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 2;
                    break;
                case "O" :
                    ssnStartCharInt[0] = 3;
                    ssnStartCharInt[1] = 5;
                    break;
                case "P" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 3;
                    break;
                case "Q" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 4;
                    break;
                case "R" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 5;
                    break;
                case "S" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 6;
                    break;
                case "T" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 7;
                    break;
                case "U" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 8;
                    break;
                case "V" :
                    ssnStartCharInt[0] = 2;
                    ssnStartCharInt[1] = 9;
                    break;
                case "W" :
                    ssnStartCharInt[0] = 3;
                    ssnStartCharInt[1] = 2;
                    break;
                case "X" :
                    ssnStartCharInt[0] = 3;
                    ssnStartCharInt[1] = 0;
                    break;
                case "Y" :
                    ssnStartCharInt[0] = 3;
                    ssnStartCharInt[1] = 1;
                    break;
                case "Z" :
                    ssnStartCharInt[0] = 3;
                    ssnStartCharInt[1] = 3;
                    break;
                default:
                    break;
            }
            return ssnStartCharInt;
        }

        // 判斷身分證是否有效
        private Boolean JudgeSsnValid(String ssn)
        {

            if (ssn == null || ssn.Length == 0)
                return false;

            // 身分證有效判定公式: (n1*1 + n2*9 + n3*8 + n4*7 + n5*6 + n6*5 + n7*4 + n8*3 + n9*2 + n10*1 + n11*1) mod 10 = 0
            // 設置身分證是否有效判定公式的n1, n2(為開頭英文對應, 後面九碼為後面九個數字
            int[] ssnInt = new int[11];
            String startChar = ssn.Substring(0, 1);
            String secondChar = ssn.Substring(1, 1);

            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[A-Z]+$");

            // 判斷是否為十碼
            if (ssn.Length == 10) 
            {
                // 判斷開頭自母是否為大寫英文字母
                if (reg.IsMatch(startChar))
                {
                    // 判斷第一個數字是否為1 or 2
                    if (secondChar == "1" || secondChar == "2")
                    {
                        int[] startCharInt = new int[2];
                        // 取得與開頭英文字母相對應之數字
                        startCharInt = this.ConvertSsnStartCharToInt(startChar);
                        ssnInt[0] = startCharInt[0];
                        ssnInt[1] = startCharInt[1];

                        // 將剩餘九位數字轉成int存至陣列
                        for (int i = 1; i < 10; i++)
                            ssnInt[i + 1] = System.Convert.ToInt32(ssn.Substring(i, 1));

                        // 利用公式計算是否有效
                        int ssnSum = 0;
                        ssnSum += ssnInt[0];
                        ssnSum += ssnInt[10];
                        for (int i = 1; i < 10; i++)
                            ssnSum += ssnInt[i] * (10 - i);
                        if (ssnSum % 10 == 0)
                            return true;
                    }
                }
            }

            return false;
        }

        // 判斷電話號碼格式是否正確
        private Boolean JudgePhoneFormat(String phone)
        {
            if (phone.Length != 10)
                return false;

            return true;
        }

        // 判斷底薪範圍 -5000~+5000
        private Boolean JudgeBasicSalaryRange(String positionID, float basicSalary)
        {
            const int RANGE = 5000;

            this._positionModel.SetId(positionID);

            this._positionService = new PositionService(this._positionModel);

            this._positionModel = _positionService.SearchBsicSalaryByPositionID();

            float positionBasicSalary = this._positionModel.GetBasicSalary();

            if (Math.Abs(basicSalary - positionBasicSalary) > RANGE)
                return false;

            return true;
        }

        // 呼叫service 利用員工ID查詢員工資料
        public EmployeePresentationModel SearchDataByEmplID()
        {
            EmployeePresentationModel emplPresentationModel = new EmployeePresentationModel();

            if (this._employeeModel.GetEmplID() == null || this._employeeModel.GetEmplID() == "")
                MessageBox.Show("請輸入員工ID");
            else
            {
                _employeeService = new EmployeeService(this._employeeModel);
                _employeeModel = _employeeService.searchByEmplID();

                emplPresentationModel.SetEmplID(_employeeModel.GetEmplID());
                emplPresentationModel.SetName(_employeeModel.GetName());
                emplPresentationModel.SetSsn(_employeeModel.GetSsn());
                emplPresentationModel.SetSex(_employeeModel.GetSex());
                emplPresentationModel.SetPhone(_employeeModel.GetPhone());
                emplPresentationModel.SetAddress(_employeeModel.GetAddress());
                emplPresentationModel.SetBlood(_employeeModel.GetBlood());
                emplPresentationModel.SetBirth(_employeeModel.GetBirth());
                emplPresentationModel.SetEmerPerson(_employeeModel.GetEmerPerson());
                emplPresentationModel.SetEmerPhone(_employeeModel.GetEmerPhone());
                emplPresentationModel.SetMilitaryStatus(_employeeModel.GetMilitaryStatus());
                emplPresentationModel.SetJobStatus(_employeeModel.GetJobStatus());
                emplPresentationModel.SetMarriedStatus(_employeeModel.GetMarriedStatus());
                emplPresentationModel.SetSpouse(_employeeModel.GetSpouse());
                emplPresentationModel.SetDeptID(_employeeModel.GetDeptID());
                emplPresentationModel.SetPositoinID(_employeeModel.GetPositionID());
                emplPresentationModel.SetBasicSalary(_employeeModel.GetBasicSalary());

                if (_employeeModel.GetName() == null || _employeeModel.GetName() == "")
                {
                    MessageBox.Show("此員工ID不存在!");
                    emplPresentationModel.SetEmplID(null);
                }
            }        

            return emplPresentationModel;
        }

    }
}
