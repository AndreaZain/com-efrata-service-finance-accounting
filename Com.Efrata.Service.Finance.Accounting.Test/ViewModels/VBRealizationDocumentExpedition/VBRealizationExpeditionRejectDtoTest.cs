﻿using Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.VBRealizationDocumentExpedition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Com.Efrata.Service.Finance.Accounting.Test.ViewModels.VBRealizationDocumentExpedition
{
    public class VBRealizationExpeditionRejectDtoTest
    {
        [Fact]
        public void validate_default()
        {
            VBRealizationExpeditionRejectDto dto = new VBRealizationExpeditionRejectDto();
            var result = dto.Validate(null);
            Assert.True(0 < result.Count());
        }
    }
}
