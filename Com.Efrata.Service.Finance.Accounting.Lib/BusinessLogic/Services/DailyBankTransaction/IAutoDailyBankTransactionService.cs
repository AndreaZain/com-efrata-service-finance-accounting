using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.VBRequestDocument;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.GarmentInvoicePurchasingDisposition;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.OthersExpenditureProofDocument;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote;
using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;

namespace Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Services.DailyBankTransaction
{
    public interface IAutoDailyBankTransactionService
    {
        Task<int> AutoCreateFromGarmentInvoicePurchasingDisposition(GarmentInvoicePurchasingDispositionModel model);
        Task<int> AutoRevertFromGarmentInvoicePurchasingDisposition(GarmentInvoicePurchasingDispositionModel model);
        Task<int> AutoCreateFromPaymentDisposition(PaymentDispositionNoteModel model);
        Task<int> AutoRevertFromPaymentDisposition(PaymentDispositionNoteModel model);
        Task<int> AutoCreateFromOthersExpenditureProofDocument(OthersExpenditureProofDocumentModel model, List<OthersExpenditureProofDocumentItemModel> itemModels);
        Task<int> AutoRevertFromOthersExpenditureProofDocument(OthersExpenditureProofDocumentModel model, List<OthersExpenditureProofDocumentItemModel> itemModels);
        //Task<int> AutoCreateFromGarmentDPPVATExpenditureNote();
        Task<int> AutoCreateFromClearenceVB(List<int> vbRealizationIds, AccountBankViewModel bank, string referenceNo);
        Task<int> AutoCreateVbApproval(List<ApprovalVBAutoJournalDto> dtos);
    }
}