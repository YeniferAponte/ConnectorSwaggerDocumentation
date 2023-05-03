using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
   


    public class RequestGetAccountSelectFields003
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFields003 SelectableFields { get; set; }
    }

    public class GetAccountSelectFields003
    {
        public RequestGetAccountSelectFields003 Request { get; set; }
    }

    public class SelectableFields003
    {
        public string IncludeAllAccountFields { get; set; }
        public ShareSelectableFields ShareSelectableFields { get; set; }
    }

    public class ShareFields003
    {
        public string AvailableBalance { get; set; }
        public string Balance { get; set; }
        public string DivRate { get; set; }
        public string DivYtd { get; set; }
        public string DividendDue { get; set; }
        public string Type { get; set; }
    }

    public class ShareSelectableFields003
    {
        public ShareFields003 ShareFields { get; set; }
    }



}
