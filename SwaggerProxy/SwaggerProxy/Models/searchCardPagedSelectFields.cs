using System.Text;

namespace SwaggerProxy.Models
{
 

    public class CardFieldsSeacrh
    {
        public string ChkId { get; set; }
        public string Description { get; set; }
        public string EffectiveDate { get; set; }
        public string IssueDate { get; set; }
        public string SavId { get; set; }
        public string UsageLimit { get; set; }
    }


    public class PagingRequestContextCard
    {
        public string NumberOfRecordsToReturn { get; set; }
    }

    public class Request
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string HomeBankingPassword { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public PagingRequestContext PagingRequestContext { get; set; }
        public SelectableFields SelectableFields { get; set; }
        public string Query { get; set; }
    }

    public class searchCardPagedSelectFields
    {
        public Request Request { get; set; }
    }

    public class SelectableFieldsseacrhCard
    {
        public CardFieldsSeacrh CardFields { get; set; }
    }



}
