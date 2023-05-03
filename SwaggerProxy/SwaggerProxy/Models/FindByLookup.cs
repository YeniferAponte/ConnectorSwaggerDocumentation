using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{

        public class RequestLookup
        {
            [JsonPropertyName("Attributes")]
            public AttributesRequest Attributes { get; set; }

            [JsonPropertyName("LookupType")]
            public string LookupType { get; set; }

            [JsonPropertyName("LookupNumber")]
            public string LookupNumber { get; set; }

            [JsonPropertyName("DeviceInformation")]
            public DeviceInformation DeviceInformation { get; set; }

            [JsonPropertyName("Credentials")]
            public Credentials Credentials { get; set; }
        }

        public class FindByLookUp
        {
            [JsonPropertyName("Request")]
            public RequestLookup Request { get; set; }
        }


    

}