using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    class AuthorizationClass
    {

        String _id;
        String _name;
        String _value;

        // ---------------------------------------------建構子---------------------------------------------
        AuthorizationClass()
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

        //  ---------------------------------------------設置數值---------------------------------------------
        void setValue(String value)
        {
            this._value = value;
        }

        // ---------------------------------------------取得數值---------------------------------------------
        String getValue()
        {
            return this._value;
        }

    }
}
