﻿using Com.Efrata.Service.Finance.Accounting.Lib.Models.JournalTransaction;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.MemoGarmentPurchasing;
using Com.Efrata.Service.Finance.Accounting.Lib.Utilities;
using Com.Efrata.Service.Finance.Accounting.Lib.Utilities.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.MemoGarmentPurchasing
{
    public interface IMemoGarmentPurchasingService : IBaseService<MemoGarmentPurchasingModel>
    {
        Task<int> Posting(List<JournalTransactionModel> model);
    }
}
