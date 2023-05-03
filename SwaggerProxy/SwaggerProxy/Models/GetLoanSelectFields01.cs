using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{

    public class LoanFieldsSelect01
    {
        public string AccrualStatus { get; set; }
        public string GlAccrualStatusOption { get; set; }
        public string LastAccrualReversal { get; set; }
        public string LedgerAccrual { get; set; }
        public string LedgerAccrualDate { get; set; }
        public string MtdPriorRateAccrual { get; set; }
        public string TotalAccrualReversal { get; set; }
    }

    public class RequestGetLoanSelectFields01
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string LoanId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFieldsLoanFields01 SelectableFields { get; set; }
    }

    public class GetLoanSelectFields01
    {
        public RequestGetLoanSelectFields01 Request { get; set; }
    }

    public class SelectableFieldsLoanFields01
    {
        public string IncludeAllLoanFields { get; set; }
        public LoanFieldsSelect01  LoanFields { get; set; }
    }




}
