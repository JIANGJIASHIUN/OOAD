using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class BonusDefClass
    {

        private String _id;
        private String _name;
        private DateTime _createDate;
        private String _effiTime;
        private float _amount;

        // ---------------------------------------------建構子---------------------------------------------
        public BonusDefClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置獎金id---------------------------------------------
        public void setId(String bonusDefId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得獎金id---------------------------------------------
        public String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置獎金名稱---------------------------------------------
        public void setName(String bonusDefId, String name)
        {
            this._name = name;
        }

        // ---------------------------------------------取得獎金名稱---------------------------------------------
        public String getName(String bonusDefId)
        {
            return this._name;
        }

        // ---------------------------------------------設置獎金建立日期---------------------------------------------
        public void setCreateDate(String bonusDefId, DateTime createDate)
        {
            this._createDate = createDate;
        }

        // ---------------------------------------------取得獎金建立日期---------------------------------------------
        public DateTime getCreateDate(String bonusDefId)
        {
            return this._createDate;
        }

        // ---------------------------------------------設置獎金有效期限---------------------------------------------
        public void setEffiTime(String bonusDefId, String effiTime)
        {
            this._effiTime = effiTime;
        }

        // ---------------------------------------------取得獎金有效期限---------------------------------------------
        public String getEffiTime(String bonusDefId)
        {
            return this._effiTime;
        }

        // ---------------------------------------------設置獎金金額---------------------------------------------
        public void setAmount(String bonusDefId, float amount)
        {
            this._amount = amount;
        }

        // ---------------------------------------------取得獎金金額---------------------------------------------
        public float getAmount(String bonusId)
        {
            return this._amount;
        }

    }
}
