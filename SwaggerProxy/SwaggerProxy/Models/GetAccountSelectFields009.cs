using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
   
 
    public class GetAccountSelectFields009
    {
        public Request009 Request { get; set; }
    }
  

    public class Request009
    {
        public Attributes Attributes { get; set; }
        public string AccountNumber { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFields009 SelectableFields { get; set; }
    }

    

    public class SelectableFields009
    {
        public string IncludeAllAccountFields { get; set; }
        public LoanSelectableFields LoanSelectableFields { get; set; }
    }








}
