﻿using System.Collections.Generic;

namespace Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.MemoDetailGarmentPurchasing
{
    public class DispositionDto
    {
        public int DispositionId { get; set; }
        public string DispositionNo { get; set; }
        public List<MemoDetail> MemoDetails { get; set; }
    }
}