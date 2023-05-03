using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
   

 


    public class RequestAcct007
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
        public SelectableFields007 SelectableFields { get; set; }
    }

    public class GetAccountSelectFields007
    {
        [JsonPropertyName("Request")]
        public RequestAcct007 Request { get; set; }
    }

    public class SelectableFields007
    {
        [JsonPropertyName("IncludeAllAccountFields")]
        public string IncludeAllAccountFields { get; set; }

        [JsonPropertyName("LoanSelectableFields")]
        public LoanSelectableFields LoanSelectableFields { get; set; }

        [JsonPropertyName("ShareSelectableFields")]
        public ShareSelectableFields ShareSelectableFields { get; set; }
    }
    public class ShareFields
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }
    }

    public class ShareSelectableFields
    {
        [JsonPropertyName("IncludeAllShareFields")]
        public string IncludeAllShareFields { get; set; }

        [JsonPropertyName("ShareFields")]
        public ShareFields ShareFields { get; set; }
    }



}
