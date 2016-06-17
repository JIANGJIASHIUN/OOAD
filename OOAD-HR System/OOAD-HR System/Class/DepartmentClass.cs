﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class DepartmentClass
    {

        private String _depertmentID = null;
        private String _departmentName = null;
        private DateTime _departmentStartTime;
        private DateTime _departmentEndTime;
        private String _departmentManager = null;

        // ---------------------------------------------建構子---------------------------------------------
        public DepartmentClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        public void SetId(String newDepartmentID)
        {
            this._depertmentID = newDepartmentID;
        }

        // ---------------------------------------------取得id---------------------------------------------
        public String GetId()
        {
            return this._depertmentID;
        }

        // ---------------------------------------------設置名稱---------------------------------------------
        public void SetName(String departmentName)
        {
            this._departmentName = departmentName;
        }

        // ---------------------------------------------取得名稱---------------------------------------------
        public String GetName()
        {
            return this._departmentName;
        }

        // ---------------------------------------------設置創立時間---------------------------------------------
        public void SetStartTime(DateTime departmentStartTime)
        {
            this._departmentStartTime = departmentStartTime;
        }

        // ---------------------------------------------取得創立時間---------------------------------------------
        public DateTime GetStartTime()
        {
            return this._departmentStartTime;
        }

        // ---------------------------------------------設置關閉時間---------------------------------------------
        public void SetEndTime(DateTime departmentEndTime)
        {
            this._departmentEndTime = departmentEndTime;
        }

        // ---------------------------------------------取得關閉時間---------------------------------------------
        public DateTime GetEndTime()
        {
            return this._departmentEndTime;
        }

        // ---------------------------------------------設置管理人---------------------------------------------
        public void SetManager(String departmentManager)
        {
            this._departmentManager = departmentManager;
        }

        // ---------------------------------------------取得管理人---------------------------------------------
        public String GetManager()
        {
            return this._departmentManager; 
        }

    }
}
