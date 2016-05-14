using MySql.Data.MySqlClient;
using OOAD_HR_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Service
{
    class EmployeeService
    {

        private MySqlConnection myConnection = new MySqlConnection("server=118.166.192.62;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        EmployeeModel _employeeModel = new EmployeeModel();
        public void setId(String emplID, String newEmplID)
        {
            _employeeModel.setId(emplID, newEmplID);
        }

        // ---------------------------------------------設置姓名---------------------------------------------
        public void setName(String emplName)
        {
            _employeeModel.setName(emplName);
        }

        // ---------------------------------------------設置身分證字號---------------------------------------------
        public void setSsn(String emplID, String ssn)
        {
            _employeeModel.setSsn(emplID, ssn);
        }


        // ---------------------------------------------設置性別---------------------------------------------
        public void setSex(String emplID, String sex)
        {
            _employeeModel.setSex(emplID, sex);
        }


        // ---------------------------------------------設置血型---------------------------------------------
        public void setBlood(String emplID, String blood)
        {
            _employeeModel.setBlood(emplID, blood);
        }

        // ---------------------------------------------取得聯絡電話---------------------------------------------
        public void setPhone(String emplID, String phone)
        {
            _employeeModel.setPhone(emplID, phone);
        }


        // ---------------------------------------------設置住址---------------------------------------------
        public void setAddress(String emplID, String addr)
        {
            _employeeModel.setAddress(emplID, addr);
        }


        // ---------------------------------------------取得緊急聯絡人---------------------------------------------
        public void setEmerPerson(String emplID, String emerPerson)
        {
            _employeeModel.setEmerPerson(emplID, emerPerson);
        }

        // ---------------------------------------------設置緊急連絡電話---------------------------------------------
        public void setEmerPhone(String emplID, String emerPhone)
        {
            _employeeModel.setEmerPhone(emplID, emerPhone);
        }

        // ---------------------------------------------設置兵役狀態---------------------------------------------
        public void setMilitary(String emplID, String military)
        {
            _employeeModel.setMilitary(emplID, military);
        }

        // ---------------------------------------------設置工作狀態---------------------------------------------
        public void setJobState(String emplID, String jobState)
        {
            _employeeModel.setJobState(emplID, jobState);
        }

        // ---------------------------------------------設置婚姻狀態---------------------------------------------
        public void setMarriedState(String emplID, String marriedState)
        {
            _employeeModel.setMarriedState(emplID, marriedState);
        }

        // ---------------------------------------------設置配偶---------------------------------------------
        public void setSpouse(String emplID, String spouse)
        {
            _employeeModel.setSpouse(emplID, spouse);
        }

        // ---------------------------------------------設置出生日期---------------------------------------------
        public void setBirth(String emplID, DateTime birth)
        {
            _employeeModel.setBirth(emplID, birth);
        }
        // ---------------------------------------------設置底薪---------------------------------------------
        public void setBasicSalary(String emplID, float basicSalary)
        {
            _employeeModel.setBasicSalary(emplID, basicSalary);
        }
        // ---------------------------------------------設置所屬部門編號---------------------------------------------
        public void setDeptId(String emplID, String deptId)
        {
            _employeeModel.setDeptId(emplID, deptId);
        }

        // ---------------------------------------------設置職位編號---------------------------------------------
        public void setPositionId(String emplID, String positionId)
        {
            _employeeModel.setPositionId(emplID, positionId);
        }

        // 建立與資料庫連線
        private Boolean connectToDB()
        {
            try
            {
                myConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public void InsertData()
        {
            if (this.connectToDB())
            {
                try
                {
                    string id = _employeeModel.getId();
                    string sql = "INSERT INTO employee(emplID,emplName,ssn,sex,blood,phone,"
                        + "emerPerson,emerPhoneNum,military,jobStat,marriedStat"
                        + ",spouse,birth,basicSalary,deptID,positionID,address)"
                        + "VALUES('"
                        + _employeeModel.getId() + "','" + _employeeModel.getName(id) + "','" + _employeeModel.getSsn(id)
                        + "','" + _employeeModel.getSex(id) + "','" + _employeeModel.getBlood(id) + "','" + _employeeModel.getPhone(id)
                        + "','" + _employeeModel.getEmerPerson(id) + "','" + _employeeModel.getEmerPhone(id) + "','" + _employeeModel.getMilitary(id)
                        + "','" + _employeeModel.getJobState(id) + "','" + _employeeModel.getMarriedState(id) + "','" + _employeeModel.getSpouse(id)
                        + "','" + _employeeModel.getBirth(id) + "','" + _employeeModel.getBasicSalary(id) + "','" + _employeeModel.getDeptId(id)
                        + "','" + _employeeModel.getPositionId(id) + "','" + _employeeModel.getAddress(id)+ "')";
                    MySqlCommand cmd = new MySqlCommand(sql, myConnection);
                    int temp = cmd.ExecuteNonQuery();
                    /*
                 DataTable dataSet = new DataTable();
                    
                MySqlCommand search = new MySqlCommand("SELECT * FROM `account` WHERE `account` = '" + account + "'", myConnection);
                search.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(search);
                adapter.Fill(dataSet);

                foreach (DataRow searchDr in dataSet.Rows)
                {
                    _loginModel.setAccount(searchDr["account"].ToString());
                    _loginModel.setPassword(searchDr["password"].ToString());
                }
                */
                }
                catch (MySqlException ex)
                {

                }
            }

            myConnection.Close();

        }
    }
}
