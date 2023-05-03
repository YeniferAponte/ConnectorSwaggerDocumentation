namespace SwaggerProxy.Models
{
  

    public class RequestName
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string NameLocator { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
    }

    public class GetName
    {
        public RequestName Request { get; set; }
    }


  
}
