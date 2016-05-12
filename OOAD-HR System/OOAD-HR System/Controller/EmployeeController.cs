using OOAD_HR_System.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OOAD_HR_System.Controller
{
    class EmployeeController
    {
        EmployeeClass ec = new EmployeeClass();

        //建構子
        public EmployeeController()
        {

        }

        //設定員工編號
        public bool SetId(string oldId, string newId)
        {
            //判斷員工編號是否為空
            if (string.Equals(newId, string.Empty))
            {
                return false;
            }
            else
            {
                ec.setId(oldId, newId);
                return true;
            }
        }

        //設定員工姓名
        public bool SetName(string name)
        {
            //判斷員工編號是否為空
            if (string.Equals(string.Empty, name))
            {
                return false;
            }
            else
            {
                ec.setName(name);
                return true;
            }
        }

        //設定員工身分證字號
        public bool SetSsn(string id, string ssn)
        {
            //判斷員工身分證字號是否合乎規格
            if (CheckSsn(ssn))
            {
                ec.setSsn(id, ssn);
                return true;
            }
            return false;
        }

        //檢查身分證
        private bool CheckSsn(string ssn)
        {
            if (!string.IsNullOrEmpty(ssn))
            {
                ssn = ssn.ToUpper();
                var regex = new Regex("^[A-Z]{1}[0-9]{9}$");
                if (regex.IsMatch(ssn))
                {
                    return true;
                }
            }
            return false; //Regular Expression 驗證失敗，回傳 ID 錯誤
        }

        //設定員工性別
        public bool SetSex(string id, string sex)
        {
            //判斷員工性別是否為空
            if (string.Equals(string.Empty, sex))
            {
                return false;
            }
            else
            {
                ec.setSex(id, sex);
                return true;
            }
        }

        //設定員工血型
        public bool SetBlood(string id, string blood)
        {
            //判斷員工血型是否為空
            if (string.Equals(string.Empty, blood))
            {
                return false;
            }
            else
            {
                ec.setBlood(id, blood);
                return true;
            }
        }

        //設定員工連絡電話
        public bool SetPhone(string id, string phone)
        {
            //判斷員工連絡電話是否為空
            if (string.Equals(string.Empty, phone))
            {
                return false;
            }
            else
            {
                ec.setPhone(id, phone);
                return true;
            }
        }

        //設定員工住址
        public bool SetAddress(string id, string address)
        {
            //判斷員工住址是否為空
            if (string.Equals(string.Empty, address))
            {
                return false;
            }
            else
            {
                ec.setAddress(id, address);
                return true;
            }
        }

        //設定員工緊急聯絡人
        public bool SetEmerPerson(string id, string person)
        {
            //判斷員工緊急聯絡人是否為空
            if (string.Equals(string.Empty, person))
            {
                return false;
            }
            else
            {
                ec.setEmerPerson(id, person);
                return true;
            }
        }

        //設定員工緊急聯絡人電話
        public bool SetEmerPhone(string id, string phone)
        {
            //判斷員工緊急聯絡人電話是否為空
            if (string.Equals(string.Empty, phone))
            {
                return false;
            }
            else
            {
                ec.setEmerPhone(id, phone);
                return true;
            }
        }

        //設定員工兵役狀態
        public bool SetMilitary(string id, string military)
        {
            //判斷員工兵役狀態是否為空
            if (string.Equals(string.Empty, military))
            {
                return false;
            }
            else
            {
                ec.setMilitary(id, military);
                return true;
            }
        }

        //設定員工工作狀態
        public bool SetJobState(string id, string state)
        {
            //判斷員工工作狀態是否為空
            if (string.Equals(string.Empty, state))
            {
                return false;
            }
            else
            {
                ec.setJobState(id, state);
                return true;
            }
        }

        //設定員工編號
        public bool SetMarriedState(string id, string marriedState)
        {
            //判斷員工編號是否為空
            if (string.Equals(string.Empty, marriedState))
            {
                return false;
            }
            else
            {
                ec.setMarriedState(id, marriedState);
                return true;
            }
        }

        //設定員工配偶
        public void SetSpouse(string id, string spouse)
        {
            //判斷員工配偶是否為空
            if (string.Equals(string.Empty, spouse))
            {
                //若為空，則輸入"無"
                ec.setSpouse(id, "無");
            }
            else
            {
                ec.setSpouse(id, spouse);
            }
        }

        //設定員工生日
        public void SetBirth(string id, DateTime birth)
        {
            ec.setBirth(id, birth);
        }

        //設定員工底薪
        public bool SetBasicSalary(string id, string basicSalary)
        {
            if (string.Equals(string.Empty, basicSalary))
            {
                return false;
            }
            else
            {
                float convertBasicSalary = Convert.ToSingle(basicSalary);
                //判斷員工底薪是否為空
                if (convertBasicSalary <10000)
                {
                    return false;
                }
                else
                {
                    ec.setBasicSalary(id, convertBasicSalary);
                    return true;
                }
            }
        }

        //設定員工部門編號
        public bool SetDeptId(string id, string deptId)
        {
            //判斷員工部門編號是否為空
            if (string.Equals(string.Empty, deptId))
            {
                return false;
            }
            else
            {
                ec.setDeptId(id, deptId);
                return true;
            }
        }

        //設定員工職位編號
        public bool SetPositionId(string id, string positionId)
        {
            //判斷員工職位編號是否為空
            if (string.Equals(string.Empty, positionId))
            {
                return false;
            }
            else
            {
                ec.setPositionId(id, positionId);
                return true;
            }
        }

    }
}
