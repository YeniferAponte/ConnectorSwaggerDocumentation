using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{
   

    public class IrsFieldsSelectFields
    {
        public string ContrLastYear { get; set; }
        public string ContrThisYear { get; set; }
        public string ContributionYear { get; set; }
        public string DistrLastYear { get; set; }
        public string DistrThisYear { get; set; }
        public string PayoffAmount { get; set; }
    }

    public class RequestGetIrsSelectFields
    {
        public AttributesACCT Attributes { get; set; }
        public string AccountNumber { get; set; }
        public string LoanId { get; set; }
        public Credentials Credentials { get; set; }
        public DeviceInformation DeviceInformation { get; set; }
        public SelectableFieldsGetIrsSelectFields SelectableFields { get; set; }
    }

    public class GetIrsSelectFields
    {
        public RequestGetIrsSelectFields Request { get; set; }
    }

    public class SelectableFieldsGetIrsSelectFields
    {
        public string IncludeAllIrsFields { get; set; }
        public IrsFieldsSelectFields IrsFields { get; set; }
    }



}
