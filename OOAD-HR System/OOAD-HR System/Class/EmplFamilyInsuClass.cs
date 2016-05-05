﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    public class EmplFamilyInsuClass
    {

        private String _emplID;                 // 員工編號(用於確認該家屬為哪個員工之家屬)
        private String _eFName;
        private String _eFInsuranceId;
        private DateTime _eFInsuranceBegin;
        private String _eFInsuranceAging;

        // ---------------------------------------------建構子---------------------------------------------
        public EmplFamilyInsuClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置員工編號---------------------------------------------
        public void setEmplId(String emplID)
        {
            this._emplID = emplID;
        }

        // ---------------------------------------------取得員工編號---------------------------------------------
        public String getEmplId()
        {
            return this._emplID;
        }

        // ---------------------------------------------設置家屬性名---------------------------------------------
        public void setEFName(String emplId, String eFName)
        {
            this._eFName = eFName;
        }

        // ---------------------------------------------取得家屬姓名---------------------------------------------
        public String getEFName(String emplId)
        {
            return this._eFName;
        }

        // ---------------------------------------------設置家屬保險id---------------------------------------------
        public void setEFInsuranceId(String emplId, String eFInsuranceId)
        {
            this._eFInsuranceId = eFInsuranceId;
        }

        // ---------------------------------------------取得家屬保險id---------------------------------------------
        public String getEFInsurance(String emplId)
        {
            return this._eFInsuranceId;
        }

        // ---------------------------------------------設置家屬保險開始日期---------------------------------------------
        public void setEFInsuranceBegin(String emplId, DateTime eFInsuranceBegin)
        {
            this._eFInsuranceBegin = eFInsuranceBegin;
        }

        // ---------------------------------------------取得家屬保險開始日期---------------------------------------------
        public DateTime getEFInsuranceBegin(String emplId)
        {
            return this._eFInsuranceBegin;
        }

        // ---------------------------------------------設置家屬保險年限---------------------------------------------
        public void setEFInsuranceAging(String emplId, String eFInsuranceAging)
        {
            this._eFInsuranceAging = eFInsuranceAging;
        }

        // ---------------------------------------------取得家屬保險年限---------------------------------------------
        public String getEFInsuranceAging(String emplId)
        {
            return this._eFInsuranceAging;
        }

    }
}
