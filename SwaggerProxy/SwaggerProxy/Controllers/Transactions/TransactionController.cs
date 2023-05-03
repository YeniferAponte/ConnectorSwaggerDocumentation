using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Amqp.Framing;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using RestSharp;
using SwaggerProxy.Models;

using System;
using System.Drawing;
using System.Dynamic;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwaggerProxy.Controllers.Accounts
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TransactionController : Controller
    {
        ///  <summary>
        /// Get Share example 1
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        /// 
        ///  <remarks>
        ///  
        ///  The following getShare message returns the values of all fields in Share ID Number
        /// 
        /// Sample request:
        /// 
        ///     {
        ///       "Request": {
        ///       
        ///         "Attributes": {
        ///         "MessageId": "1",
        ///         "BranchId": "1"
        ///          },
        ///      
        ///       "ShareID":"0020",
        ///      "Credentials": {
        ///          "AdministrativeCredentials": {
        ///          "Password": "*******"
        ///          }
        ///        },
        ///      "DeviceInformation": {
        ///      "Attributes": {
        ///        "DeviceType": "Computacenter",
        ///        "DeviceNumber": "123456"
        ///         },
        ///        "ElementValue": ""
        ///        },
        ///       }
        ///      }
        /// </remarks>


        [HttpPost("~/getShare")]

        public JsonResult getShare([FromBody] GetShare getshare,  string URL)
        {
           
            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getShare", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(getshare);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Share Select Fields example 
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        /// 
        ///  <remarks>
        ///  
        ///  getShareSelectFields message returns the values of the selected fields in the Share record and all fields in
        /// all Share Transfer records encountered in the Share Record
            /// 
            /// Sample request:
            /// 
            ///     {
            ///       "Request": {
            ///       
            ///         "Attributes": {
            ///         "MessageId": "1",
            ///         "BranchId": "1"
            ///          },
            ///      
            ///       "ShareID":"0020",
            ///      "Credentials": {
            ///          "AdministrativeCredentials": {
            ///          "Password": "*******"
            ///          }
            ///        },
            ///      "DeviceInformation": {
            ///      "Attributes": {
            ///        "DeviceType": "Computacenter",
            ///        "DeviceNumber": "123456"
            ///         },
            ///        "ElementValue": ""
            ///        },
            ///        "SelectableFields":{
            ///            "IncludeAllAccountFields": "false",
            ///             "ShareFields":{
            ///                 "MicrAcctNumber":"true",
            ///                  "MinimumBalance":"true"
            ///            }
            ///          }
            ///        }
            ///      }
            /// </remarks>


        
            [HttpPost("~/getShareSelectFields")]

        public JsonResult getShareSelectFields([FromBody] GetShareSelectFields getShareSelectFields, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getShareSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(getShareSelectFields);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }

        ///  <summary>
        /// Seacrh Card Paged  Select Fields example 
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        /// 
        ///  <remarks>
        ///  When you use a search , you specify criteria for the desired record type within the Query property.
        ///  The following searchCardPagedSelectFields message returns the values of the specified fields .
        /// 
        /// Sample request:
        /// 
        ///       {
          ///      "Request":
          ///      {
         ///           "Attributes": 
         ///          {
          ///              "MessageId": "SearchforUnexpiredIssuedCards",
         ///               
         ///           },
         ///            
         ///             "AccountNumber": "0000643692",
         ///             "HomeBankingPassword": "1950",
         ///       
        ///            "Credentials": 
         ///           {
         ///               
         ///               "AdministrativeCredentials": 
         ///               {
         ///                   "Password":"s@ZYmxNvBeKNK$QgMCv3"
         ///               }
         ///           },
        ///            
        ///            "DeviceInformation": 
        ///            {
        ///                "Attributes": 
        ///                {
         ///                   "DeviceType": "CC",
        ///                    "DeviceNumber": "32101"
        ///                },
        ///                
         ///               "ElementValue": ""
        ///            },
        ///            
        ///            "PagingRequestContext": 
        ///                {
        ///                  "NumberOfRecordsToReturn": "2"
        ///                },
         ///           "SelectableFields": 
        ///            {
         ///               
         ///               "CardFields": 
         ///               {
        ///                "ChkId": "true",
        ///                "Description": "true",
         ///               "EffectiveDate": "true",
        ///                "IssueDate": "true",
         ///               "SavId": "true",
        ///                "UsageLimit": "true"
         ///               }
        ///            },
        ///            "Query": "Type=10 and\n (ExpirationDate&gt;{date:'2020-10-12'} or\n ExpirationDate&lt;{date:'1900-01-01'})"
        ///   
        ///        }
        ///
        ///        }
        /// </remarks>



    [HttpPost("~/searchCardPagedSelectFields")]

        public JsonResult searchCardPagedSelectFields([FromBody] searchCardPagedSelectFields searchCardPagedSelectFields, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/searchCardPagedSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(searchCardPagedSelectFields);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Name example 
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        /// 
        ///  <remarks>
        ///  
        /// Returns the values of all fields in a record selected by Name Locator.
        /// 
        /// Sample request:
        /// 
        ///     {
        ///       "Request": {
        ///       
        ///         "Attributes": {
        ///         "MessageId": "1",
        ///         "BranchId": "1"
        ///          },
        ///      
        ///       "AccountNumver":"1234567",
        ///       "NameLocator":"Abby Test",
        ///      "Credentials": {
        ///          "AdministrativeCredentials": {
        ///          "Password": "*******"
        ///          }
        ///        },
        ///      "DeviceInformation": {
        ///      "Attributes": {
        ///        "DeviceType": "Computacenter",
        ///        "DeviceNumber": "123456"
        ///         },
        ///        "ElementValue": ""
        ///         }
        ///        }
        ///      }
        /// </remarks>



        [HttpPost("~/getName")]

        public JsonResult getName([FromBody] GetName getName, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getName", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(getName);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
    }
}
