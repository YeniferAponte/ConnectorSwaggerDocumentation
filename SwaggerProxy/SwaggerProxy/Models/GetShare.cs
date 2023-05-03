using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{

    public class RequestGetShare
    {
        public AttributesACCT Attributes { get; set; }
        public string ShareId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
    }

    public class GetShare
    {
        public RequestGetShare Request { get; set; }
    }

    


}
