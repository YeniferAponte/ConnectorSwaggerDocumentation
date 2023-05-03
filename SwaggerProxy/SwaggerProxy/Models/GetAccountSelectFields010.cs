using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{


    public class NameFields10
    {
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
    }

    public class NameSelectableFields10
    {
        public string IncludeAllNameFields { get; set; }
        public NameFields10 NameFields { get; set; }
    }

    public class RequestAcct10
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFields10 SelectableFields { get; set; }
    }

    public class GetAccountSelectFields010
    {
        public RequestAcct10 Request { get; set; }
    }

    public class SelectableFields10
    {
        public string IncludeAllAccountFields { get; set; }
        public NameSelectableFields10 NameSelectableFields { get; set; }
    }





}
