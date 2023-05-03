using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{

    public class PreferenceFields
    {
        public string AudioAccess { get; set; }
    }

    public class PreferenceSelectableFields
    {
        public string IncludeAllPreferenceFields { get; set; }
        public PreferenceFields PreferenceFields { get; set; }
    }

    public class Request011
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFields11 SelectableFields { get; set; }
    }

    public class GetAccountSelectFields011
    {
        public Request011 Request { get; set; }
    }

    public class SelectableFields11
    {
        public string IncludeAllAccountFields { get; set; }
        public PreferenceSelectableFields PreferenceSelectableFields { get; set; }
    }


}
