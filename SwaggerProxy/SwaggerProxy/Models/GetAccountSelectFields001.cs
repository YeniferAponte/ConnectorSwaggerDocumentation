using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
       
        public class GetAccountSelectFields001
        {
            [JsonPropertyName("Request")]
            public RequestAcct001 Request { get; set; }
        }

    public class RequestAcct001
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
        public SelectableFields001 SelectableFields { get; set; }
    }


    public class SelectableFields001
    {
        [JsonPropertyName("IncludeAllAccountFields")]
        public string IncludeAllAccountFields { get; set; }

        [JsonPropertyName("ShareSelectableFields")]
        public ShareSelectableFields001 ShareSelectableFields { get; set; }
    }

    public class ShareFields001
        {
            [JsonPropertyName("Id")]
            public string Id { get; set; }

            [JsonPropertyName("Type")]
            public string Type { get; set; }
        }

        public class ShareSelectableFields001
        {
            [JsonPropertyName("ShareFields")]
            public ShareFields001 ShareFields { get; set; }
        }


    
}
