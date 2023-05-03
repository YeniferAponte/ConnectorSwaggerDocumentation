using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
   


    public class PreferenceUpdateableFields
    {
        public string AudioAccess { get; set; }
    }

    public class RequestUpdateAccount
    {
        public AttributesUpdate Attributes { get; set; }
        public string PreferenceLocator { get; set; }
        public PreferenceUpdateableFields PreferenceUpdateableFields { get; set; }
        public string AccountNumber { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
    }

    public class UpdateAcct
    {
        public RequestUpdateAccount Request { get; set; }
    }
   
    public class AttributesUpdate
    {
        public string MessageId { get; set; }

        [JsonProperty("acc:BranchId")]
        public string accBranchId { get; set; }
      
    }

   



}
