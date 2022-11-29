﻿namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.BudgetCashflow
{
    public class BudgetCashflowByCategoryDto
    {
        public int CurrencyId { get; private set; }
        public double CurrencyNominal { get; private set; }
        public double ActualNominal { get; private set; }
        public double Nominal { get; private set; }
        public int UnitId { get; private set; }
        public int DivisionId { get; private set; }
    }
}