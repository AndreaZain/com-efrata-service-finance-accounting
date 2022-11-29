﻿using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.VBRequestDocument
{
    public class ApprovalVBFormDto
    {
        public ApprovalVBFormDto()
        {
            Ids = new HashSet<int>();
        }
        public bool IsApproved { get; set; }
        public IEnumerable<int> Ids { get; set; }
        public AccountBankViewModel Bank { get; set; }
    }
}
