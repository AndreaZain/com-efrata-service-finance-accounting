﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.GarmentFinance.Report.LocalDebtorCard
{
    public class GarmentLocalSalesNoteViewModel
    {
        public int SalesNoteId { get; set; }
        public string BuyerCode { get; set; }
        public string BuyerName { get; set; }
        public double Amount { get; set; }
        public DateTimeOffset Date { get; set; }
        public string SalesNoteNo { get; set; }
    }
}
