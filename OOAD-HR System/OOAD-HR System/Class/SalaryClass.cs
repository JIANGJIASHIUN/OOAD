using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class SalaryClass
    {

        private DateTime _year;
        private DateTime _month;
        private int _salaryT;           // 期別
        private String _accountData;
        private String _payWay;

        // ---------------------------------------------建構子---------------------------------------------
        public SalaryClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置薪水年分---------------------------------------------
        public void setYear(String emplId, DateTime year)
        {
            this._year = year;
        }

        // ---------------------------------------------取得薪水年份---------------------------------------------
        public DateTime getYear(String emplId)
        {
            return this._year;
        }

        // ---------------------------------------------設置薪水月份---------------------------------------------
        public void setMonth(String emplId, DateTime month)
        {
            this._month = month;
        }

        // ---------------------------------------------取得薪水月份---------------------------------------------
        public DateTime getMonth(String emplId)
        {
            return this._month;
        }

        // ---------------------------------------------設置薪水期別---------------------------------------------
        public void setSalaryT(String emplId, int salaryT)
        {
            this._salaryT = salaryT;
        }

        // ---------------------------------------------取得薪水期別---------------------------------------------
        public int getSalaryT(String emplId)
        {
            return this._salaryT;
        }

        // ---------------------------------------------設置員工帳戶資料---------------------------------------------
        public void setAccountData(String emplId, String accountData)
        {
            this._accountData = accountData;
        }

        // ---------------------------------------------取得員工帳戶資料---------------------------------------------
        public String getAccountData(String emplId)
        {
            return this._accountData;
        }

        // ---------------------------------------------設置支付方式---------------------------------------------
        public void setPayWay(String emplId, String payWay)
        {
            this._payWay = payWay;
        }

        // ---------------------------------------------取得支付方式---------------------------------------------
        public String getPayWay(String emplId)
        {
            return this._payWay;
        }

        // ---------------------------------------------計算所有員工薪水---------------------------------------------
        public void computeSalary()
        {

        }

        // ---------------------------------------------匯出所有員工薪水資料---------------------------------------------
        public void exportSalary()
        {

        }

    }
}
