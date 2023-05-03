using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
    

    public class LoanFields02
    {
        public string InterestLastYear { get; set; }
        public string InterestRate { get; set; }
        public string InterestYtd { get; set; }
        public string StatementDate { get; set; }
        public string StatementOldBalance { get; set; }
        public string StatementNewBalance { get; set; }
        public string PayoffAmount { get; set; }
    }

    public class RequestGetLoanSelectFields02
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string LoanId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFieldsGetLoanSelectFields02 SelectableFields { get; set; }
    }

    public class GetLoanSelectFields02
    {
        public RequestGetLoanSelectFields02 Request { get; set; }
    }

    public class SelectableFieldsGetLoanSelectFields02
    {
        public string IncludeAllLoanFields { get; set; }
        public LoanFields02 LoanFields { get; set; }
    }




}
