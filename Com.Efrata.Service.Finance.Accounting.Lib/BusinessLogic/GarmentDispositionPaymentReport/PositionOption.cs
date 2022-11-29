﻿using Com.Efrata.Service.Finance.Accounting.Lib.Enums.Expedition;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.GarmentDispositionPaymentReport
{
    public class PositionOption
    {
        public PositionOption(GarmentPurchasingExpeditionPosition position)
        {
            Value = position;
            Label = position.ToDescriptionString();
        }

        public GarmentPurchasingExpeditionPosition Value { get; private set; }
        public string Label { get; private set; }
    }
}