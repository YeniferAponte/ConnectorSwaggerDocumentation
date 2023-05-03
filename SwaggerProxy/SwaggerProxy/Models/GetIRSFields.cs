using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
  
   
    public class IrsFields
    {
        public string ActualMaxContribution { get; set; }
        public string IrsHolderBirthDate { get; set; }
        public string IrsPlan { get; set; }
        public string OpenDate { get; set; }
    }

    public class IrsSelectableFields
    {
        public string IncludeAllIrsFields { get; set; }
        public IrsFields IrsFields { get; set; }
    }

    public class RequestIRSSelectableFields
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFieldsIRS SelectableFields { get; set; }
    }

    public class GetIRSSelectableFields
    {
        public RequestIRSSelectableFields Request { get; set; }
    }

    public class SelectableFieldsIRS
    {
        public string IncludeAllAccountFields { get; set; }
        public IrsSelectableFields IrsSelectableFields { get; set; }
    }


}
