using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{ 
        

        public class RequestSSN
        {
            [JsonPropertyName("Attributes")]
            public AttributesRequest Attributes { get; set; }

            [JsonPropertyName("SSN")]
            public string SSN { get; set; }

            [JsonPropertyName("DeviceInformation")]
            public DeviceInformation DeviceInformation { get; set; }

            [JsonPropertyName("Credentials")]
            public Credentials Credentials { get; set; }
        }

        public class FindBySSN
    {
            [JsonPropertyName("Request")]
            public RequestSSN Request { get; set; }
        }


    

}