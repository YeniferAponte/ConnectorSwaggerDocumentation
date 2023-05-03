using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
     
        public class GetAccountSelectFields002
      
        {
            [JsonPropertyName("Request")]
            public RequestAcct002 Request { get; set; }
        }
    public class RequestAcct002
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
        public SelectableFields002 SelectableFields { get; set; }
    }


    public class SelectableFields002
    {
        [JsonPropertyName("IncludeAllAccountFields")]
        public string IncludeAllAccountFields { get; set; }

        [JsonPropertyName("ShareSelectableFields")]
        public ShareSelectableFields002 ShareSelectableFields { get; set; }
    }


    public class ShareFields002
        {
            [JsonPropertyName("MicrAcctNumber")]
            public string MicrAcctNumber { get; set; }

            [JsonPropertyName("AvailableBalance")]
            public string AvailableBalance { get; set; }

            [JsonPropertyName("Balance")]
            public string Balance { get; set; }

            [JsonPropertyName("Description")]
            public string Description { get; set; }

            [JsonPropertyName("DivRate")]
            public string DivRate { get; set; }

            [JsonPropertyName("DivYtd")]
            public string DivYtd { get; set; }

            [JsonPropertyName("DividendDue")]
            public string DividendDue { get; set; }

            [JsonPropertyName("Id")]
            public string Id { get; set; }

            [JsonPropertyName("Type")]
            public string Type { get; set; }
        }

        public class ShareSelectableFields002
        {
            [JsonPropertyName("ShareFields")]
            public ShareFields002 ShareFields { get; set; }
        }


    
}
