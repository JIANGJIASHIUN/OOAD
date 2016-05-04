﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System.Class
{
    class ReimburseClass
    {

        String _id = null;
        String _applicantId = null;         // 申請人員工編號
        String _reimDefId = null;
        DateTime _applicationDate;
        float _applicationaMount;

        // ---------------------------------------------建構子---------------------------------------------
        ReimburseClass()
        {

        }

        // 以下class的get set皆會與資料庫連接此部分先寫上基本的部份

        // ---------------------------------------------設置報帳id---------------------------------------------
        void setId(String reimId, String id)
        {
            this._id = id;
        }

        // ---------------------------------------------取得報帳id---------------------------------------------
        String getId()
        {
            return this._id;
        }

        // ---------------------------------------------設置申請人員工編號---------------------------------------------
        void setApplicantId(String reimburseId, String applicantId)
        {
            this._applicantId = applicantId;
        }

        // ---------------------------------------------取得申請人員工編號---------------------------------------------
        String getApplicantId(String reimId)
        {
            return this._applicantId;
        }

        // ---------------------------------------------設置報帳定義id---------------------------------------------
        void setReimDefId(String reimId, String reimDefId)
        {
            this._reimDefId = reimDefId;
        }

        // ---------------------------------------------取得報帳定義id---------------------------------------------
        String getReimDefId(String reimId)
        {
            return this._reimDefId;
        }

        // ---------------------------------------------設置報帳申請日期---------------------------------------------
        void setApplicationDate(String reimId, DateTime applicationDate)
        {
            this._applicationDate = applicationDate;
        }

        // ---------------------------------------------取得報帳申請日期---------------------------------------------
        DateTime getApplicationDate(String reimId)
        {
            return this._applicationDate;
        }

        // ---------------------------------------------設置報帳申請金額---------------------------------------------
        void setApplicationAmount(String reimId, float applicationAmount)
        {
            this._applicationaMount = applicationAmount;
        }

        // ---------------------------------------------取得報帳申請金額---------------------------------------------
        float getApplicationAmount(String reimId)
        {
            return this._applicationaMount;
        }

    }
}
