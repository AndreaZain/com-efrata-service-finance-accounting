﻿namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.PurchasingMemoDetailTextile
{
    public class SupplierDto
    {
        public SupplierDto(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}