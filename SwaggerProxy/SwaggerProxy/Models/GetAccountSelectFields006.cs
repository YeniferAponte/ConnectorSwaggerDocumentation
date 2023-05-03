using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{


    
   


   

    public class RequestAcct006
    {
        [JsonPropertyName("Attributes")]
        public AttributesACCT Attributes { get; set; }

        [JsonPropertyName("AccountNumber")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("Credentials")]
        public Credentials Credentials { get; set; }

        [JsonPropertyName("DeviceInformation")]
        public DeviceInformation DeviceInformation { get; set; }

        [JsonPropertyName("SelectableFields")]
        public SelectableFields006 SelectableFields { get; set; }
    }

    public class GetAccountSelectFields006
    {
        [JsonPropertyName("Request")]
        public RequestAcct006 Request { get; set; }
    }

    public class SelectableFields006
    {
        [JsonPropertyName("IncludeAllAccountFields")]
        public string IncludeAllAccountFields { get; set; }

        [JsonPropertyName("LoanSelectableFields")]
        public LoanSelectableFields LoanSelectableFields { get; set; }
    }


}
