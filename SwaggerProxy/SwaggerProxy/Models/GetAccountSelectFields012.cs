using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{


    public class LoanFields12
    {
    }

    public class LoanSelectableFields12
    {
        public string IncludeAllLoanFields { get; set; }
        public LoanFields12 LoanFields { get; set; }
    }

    public class Request012
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFields12 SelectableFields { get; set; }
    }

    public class GetAccountSelectFields012
    {
        public Request012 Request { get; set; }
    }

    public class SelectableFields12
    {
        public string IncludeAllAccountFields { get; set; }
        public LoanSelectableFields12 LoanSelectableFields { get; set; }
    }



}
