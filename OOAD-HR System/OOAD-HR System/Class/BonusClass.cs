using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class BonusClass
    {

        private DateTime _year;
        private DateTime _month;
        private int _bonusT;             // 期別
        private String _defId;

        // ---------------------------------------------建構子---------------------------------------------
        public BonusClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置員工獎金---------------------------------------------
        public void setBonus(String emplId, String bonusDefId)
        {
            this._defId = bonusDefId;
        }

        // ---------------------------------------------移除員工獎金---------------------------------------------
        public void removeBonus(String emplId, String bonusDefid)
        {

        }

        // ---------------------------------------------計算員工獎金---------------------------------------------
        public float computeBonus(String emplId)
        {
            float totalBonus = 0;
            return totalBonus;
        }

    }
}
