﻿namespace Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.Memo
{
    public class MemoItemViewModel
    {
        public Currency Currency { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? Interest { get; set; }
    }
}