using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
  
   

    public class RequestSearchShareTransactionPagedList
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string ShareId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public PagingRequestContext PagingRequestContext { get; set; }
        public SelectableFieldsTransaction SelectableFields { get; set; }
        public string Query { get; set; }
    }

    public class searchShareTransactionPagedSelectFields
    {
        public RequestSearchShareTransactionPagedList Request { get; set; }
    }

    public class SelectableFieldsTransaction
    {
        public string IncludeAllShareTransactionFields { get; set; }
        public ShareTransactionFields ShareTransactionFields { get; set; }
    }

    public class ShareTransactionFields
    {
    }


}
