using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{



    public class LoanFields03
    {
        public string Balance { get; set; }
        public string DueDate { get; set; }
        public string PastDueAmount { get; set; }
        public string Payment { get; set; }
        public string PayoffAmount { get; set; }
    }

    public class RequestGetLoanSelectFields03
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string LoanId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFields03 SelectableFields { get; set; }
    }

    public class GetLoanSelectFields03
    {
        public RequestGetLoanSelectFields03 Request { get; set; }
    }

    public class SelectableFields03
    {
        public string IncludeAllLoanFields { get; set; }
        public LoanFields03 LoanFields { get; set; }
    }



}
