using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{


    public class LoanTransactionFields
    {
    }

   

    public class RequestLoanTransaction
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string LoanId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public PagingRequestContext PagingRequestContext { get; set; }
        public SelectableFieldsLoanTransaction SelectableFields { get; set; }
    }

    public class GetLoanTransactionPagedListSelectFields
    {
        public RequestLoanTransaction Request { get; set; }
    }

    public class SelectableFieldsLoanTransaction
    {
        public string IncludeAllLoanTransactionFields { get; set; }
        public LoanTransactionFields LoanTransactionFields { get; set; }
    }




}
