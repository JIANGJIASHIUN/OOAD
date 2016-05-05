using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class WorkAttendanceClass
    {

        private DateTime _date;
        private DateTime _time;
        private String _state;

        // ---------------------------------------------建構子---------------------------------------------
        public WorkAttendanceClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置考勤狀態---------------------------------------------
        public void setWorkState(String emplId, DateTime date, DateTime time, String state)
        {
            this._date = date;
            this._time = time;
            this._state = state;
        }

        // ---------------------------------------------檢查考勤日期---------------------------------------------
        public String checkWorkState(String emplId, DateTime date, DateTime time)
        {
            return this._state;
        } 


    }
}
