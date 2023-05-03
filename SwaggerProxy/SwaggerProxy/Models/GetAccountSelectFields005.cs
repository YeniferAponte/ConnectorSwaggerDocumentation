using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{


    public class NameFields
    {
        [JsonPropertyName("BirthDate")]
        public string BirthDate { get; set; }
    }

    public class NameSelectableFields
    {
        [JsonPropertyName("IncludeAllNameFields")]
        public string IncludeAllNameFields { get; set; }

        [JsonPropertyName("NameFields")]
        public NameFields NameFields { get; set; }
    }

    public class RequestACCT005
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
        public SelectableFields SelectableFields { get; set; }
    }

    public class GetAccountSelectFields005
    {
        [JsonPropertyName("Request")]
        public RequestACCT005 Request { get; set; }
    }

    public class SelectableFields
    {
        [JsonPropertyName("IncludeAllAccountFields")]
        public string IncludeAllAccountFields { get; set; }

        [JsonPropertyName("NameSelectableFields")]
        public NameSelectableFields NameSelectableFields { get; set; }
    }



}
