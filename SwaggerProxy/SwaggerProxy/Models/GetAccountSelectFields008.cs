using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{


   
    public class CardFields
    {
        public string ActiveDate { get; set; }
        public string CloseDate { get; set; }
        public string IssueDate { get; set; }
        public string Number { get; set; }
    }

    public class CardSelectableFields
    {
        public string IncludeAllCardFields { get; set; }
        public CardFields CardFields { get; set; }
    }

   

    public class RequestAcct008
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFieldsAcct8 SelectableFields { get; set; }
    }

    public class GetAccountSelectFields008
    {
        public RequestAcct008 Request { get; set; }
    }

    public class SelectableFieldsAcct8
    {
        public string IncludeAllAccountFields { get; set; }
        public CardSelectableFields CardSelectableFields { get; set; }
    }



}
