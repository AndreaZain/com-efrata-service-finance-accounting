﻿using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.Rreports.ExportSalesDebtorReportController;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Reports
{
    public interface IExportSalesDebtorReportService
    {
        Task<List<ExportSalesDebtorReportViewModel>> GetMonitoring(int month, int year,string type, int offset);
        Task<MemoryStream> GenerateExcel(int month, int year,string type);
    }
}
