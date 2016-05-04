using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    class DepartmentClass
    {

        String _id;
        String _name;
        DateTime _startTime;
        DateTime _endTime;
        String _manager;

        // ---------------------------------------------建構子---------------------------------------------
        DepartmentClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置id---------------------------------------------
        void setId(String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得id---------------------------------------------
        String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置名稱---------------------------------------------
        void setName(String name)
        {
            this._name = name;
        }

        // ---------------------------------------------取得名稱---------------------------------------------
        String getName()
        {
            return this._name;
        }

        // ---------------------------------------------設置創立時間---------------------------------------------
        void setStartTime(DateTime startTime)
        {
            this._startTime = startTime;
        }

        // ---------------------------------------------取得創立時間---------------------------------------------
        DateTime getStartTime()
        {
            return this._startTime;
        }

        // ---------------------------------------------設置關閉時間---------------------------------------------
        void setEndTime(DateTime endTime)
        {
            this._endTime = endTime;
        }

        // ---------------------------------------------取得關閉時間---------------------------------------------
        DateTime getEndTime()
        {
            return this._endTime;
        }

        // ---------------------------------------------設置管理人---------------------------------------------
        void setManager(String manager)
        {
            this._manager = manager;
        }

        // ---------------------------------------------取得管理人---------------------------------------------
        String getManager()
        {
            return this._manager; 
        }

    }
}
