using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Amqp.Framing;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SwaggerProxy.Models;

using System;
using System.Drawing;
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
    public class LoanController : Controller
    {
        ///  <summary>
        /// Get Loan Record example 1
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  
        ///  Method getLoan returns the Loan record 
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
        ///       "AccountNumber": "0001234560",
        ///       "LoanId":"0020",
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


        [HttpPost("~/getLoan")]

        public JsonResult getLoan([FromBody] GetLoan getLoan, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getLoan", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(getLoan);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }

        ///  <summary>
        /// Get Loan Select Fields example 1
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  
        ///  Method getLoan returns the Loan record 
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
        ///       "AccountNumber": "0001234560",
        ///       "LoanId":"0020",
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
        ///               "IncludeAllLoanFields":"false",
        ///               "LoanFields":{
        ///                    "AccrualStatus":"true",
        ///                    "GlAccrualStatusOption":"true",
        ///                    "LastAccrualReversal":"true",
        ///                   "LedgerAccrual":"true",
        ///                    "LedgerAccrualDate":"true",
        ///                   "MtdPriorRateAccrual":"true",
        ///                  "TotalAccrualReversal":"true"
        ///                }
        ///               }
        ///              }
        ///             }
        /// </remarks>


    [HttpPost("~/getLoanSelectFields01")]

        public JsonResult getLoanSelectFields01([FromBody] GetLoanSelectFields01 getLoanSelectFields01, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getLoanSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(getLoanSelectFields01);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Loan Select Fields example 2
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  
        ///  Method getLoan returns the Loan record 
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
        ///       "AccountNumber": "0001234560",
        ///       "LoanId":"0020",
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
        ///         "SelectableFields":{
        ///             "IncludeAllLoanFields":"false",
        ///             "LoanFields":{
        ///                 "InterestLastYear":"true",
        ///                  "InterestRate":"true",
        ///                  "InterestYtd":"true",
        ///                  "StatementDate":"true",
        ///                   "StatementOldBalance":"true",
        ///                   "StatementNewBalance":"true",
        ///                    "PayoffAmount":"true"
        ///                  }
        ///                 }
        ///                }
        ///               }
        /// </remarks>


        [HttpPost("~/getLoanSelectFields02")]

        public JsonResult getLoanSelectFields02([FromBody] GetLoanSelectFields02 getLoanSelectFields, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getLoanSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(getLoan);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Loan Select Fields example 3
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  
        ///  Method getLoan returns the Loan record  with the  selected fields
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
        ///       "AccountNumber": "0001234560",
        ///       "LoanId":"0020",
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
        ///         "SelectableFields":{
        ///               "IncludeAllLoanFields":"false",
        ///              "LoanFields":{
        ///                 "Balance":"true",
        ///                  "DueDate":"true",
        ///                  "PastDueAmount":"true",
        ///                  "Payment":"true",
        ///                  "PayoffAmount":"true"
        ///              }
        ///            }
        ///          }
        ///        }
        /// </remarks>


        [HttpPost("~/getLoanSelectFields03")]

        public JsonResult getLoanSelectFields03([FromBody] GetLoanSelectFields03 getLoanSelectFields03, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getLoanSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(getLoanSelectFields03);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Loan Select Fields example 3
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  
        ///  Method getLoan returns the Loan record  with the  selected fields
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
        ///       "AccountNumber": "0001234560",
        ///       "LoanId":"0020",
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
        ///        "PagingRequestContext":{
        ///        "NumberOfRecordsToReturn":"5",
        ///        "NumberOfRecordsToSkip":"0"
        ///         },
        ///         "SelectableFields":{
        ///               "IncludeAllLoanFields":"true",
        ///              "LoanTransactionFields":{
        ///
        ///              }
        ///            }
        ///          }
        ///        }
        /// </remarks>


        [HttpPost("~/getLoanTransactionPagedListSelectFields")]

        public JsonResult getLoanTransactionPagedListSelectFields([FromBody] GetLoanTransactionPagedListSelectFields getLoanTransactionPagedListSelectFields, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getLoanTransactionPagedListSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = JsonConvert.SerializeObject(getLoanTransactionPagedListSelectFields);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }


    }
}
