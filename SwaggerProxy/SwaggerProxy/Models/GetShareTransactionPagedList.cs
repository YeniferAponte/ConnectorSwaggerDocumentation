using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
  

    public class PagingRequestContext
    {
        public string NumberOfRecordsToReturn { get; set; }
        public string NumberOfRecordsToSkip { get; set; }
    }

    public class RequestShareTransactionPagedList
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string ShareId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public PagingRequestContext PagingRequestContext { get; set; }
    }

    public class GetShareTransactionPagedList
    {
        public RequestShareTransactionPagedList Request { get; set; }
    }



}
