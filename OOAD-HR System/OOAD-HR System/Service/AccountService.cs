﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using OOAD_HR_System.Model;

namespace OOAD_HR_System.Service
{
    public class AccountService
    {

        private MySqlConnection myConnection = new MySqlConnection("server=118.166.192.62;user id=hrms; password=hrms; database=hrms; CharSet=utf8");
        private LoginModel _loginModel = new LoginModel();

        public AccountService()
        {

        }

        // 建立與資料庫連線
        private Boolean connectToDB() {
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

        // 關閉資料庫連線
        private void closeConnextion()
        {
            myConnection.Close();
        }

        // 以輸入員工ID搜尋帳號密碼
        public LoginModel searchByAccount(String account)
        {
            if (this.connectToDB())
            {
                try {
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
                }
                catch (MySqlException ex)
                {

                }
            }

            this.closeConnextion();

            return this._loginModel;
        }

    }
}
