﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.VBRequestDocument
{
    public class CancellationFormDto
    {
        public CancellationFormDto()
        {
            Ids = new HashSet<int>();
        }

        public IEnumerable<int> Ids { get; set; }
        public string Reason { get; set; }
    }
}