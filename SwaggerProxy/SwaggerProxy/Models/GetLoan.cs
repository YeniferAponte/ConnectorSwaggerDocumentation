using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{


    public class RequestGetLoan
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string LoanId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
    }

    public class GetLoan
    {
        public RequestGetLoan Request { get; set; }
    }


}
