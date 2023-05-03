using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{


   
    public class RequestShareSelectFields
    {
        public AttributesACCT Attributes { get; set; }
        public string ShareId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFieldsShareSelect SelectableFields { get; set; }
    }

    public class GetShareSelectFields
    {
        public RequestShareSelectFields Request { get; set; }
    }

    public class SelectableFieldsShareSelect
    {
        public string IncludeAllAccountFields { get; set; }
        public ShareFields01 ShareFields { get; set; }
    }

    public class ShareFields01
    {
        public string MicrAcctNumber { get; set; }
        public string MinimumBalance { get; set; }
    }




}
