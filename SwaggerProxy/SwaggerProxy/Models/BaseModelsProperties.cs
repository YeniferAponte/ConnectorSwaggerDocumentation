using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace SwaggerProxy.Models
{ 
         public  class AdministrativeCredentials
        {
            [JsonPropertyName("Password")]
            public string Password { get; set; }
        }


        public class AttributesRequest
        {
            [JsonPropertyName("common:MessageId")]
            [JsonProperty("common:MessageId")]
            public string commonMessageId { get; set; }
           

    }
        public class Attributes
        {

            [JsonPropertyName("DeviceType")]
            public string? DeviceType { get; set; }

            [JsonPropertyName("DeviceNumber")]
            public string? DeviceNumber { get; set; }

        }

        public class Credentials
        {
            [JsonPropertyName("AdministrativeCredentials")]
            public AdministrativeCredentials AdministrativeCredentials { get; set; }
        }

        public class DeviceInformation
        {
            [JsonPropertyName("Attributes")]
            public Attributes Attributes { get; set; }

            [JsonPropertyName("ElementValue")]
            public string ElementValue { get; set; }
        }


    //  base Models for Account

    public class AttributesACCT
    {
        [JsonPropertyName("MessageId")]
        public string MessageId { get; set; }

        [JsonPropertyName("BranchId")]
        public string BranchId { get; set; }


    }
    public class LoanFields
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }
    }

    public class LoanSelectableFields
    {
        [JsonPropertyName("IncludeAllLoanFields")]
        public string IncludeAllLoanFields { get; set; }

        [JsonPropertyName("LoanFields")]
        public LoanFields LoanFields { get; set; }
    }






}