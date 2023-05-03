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

namespace SwaggerProxy.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AccountController : Controller
    {
        ///  <summary>
        /// Get Account Select Fields example 1
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  
        ///  Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned. 
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
        ///    "Credentials": {
        ///     "AdministrativeCredentials": {
        ///      "Password": "*******"
        ///              }
        ///         },
            ///      "DeviceInformation": {
            ///      "Attributes": {
            ///        "DeviceType": "Computacenter",
            ///        "DeviceNumber": "123456"
            ///      },
            ///        "ElementValue": ""
            ///     },
        ///     "SelectableFields": {
        ///      "IncludeAllAccountFields": "false",
        ///      "ShareSelectableFields":{
        ///        "ShareFields":{
        ///        "Id":"true",
        ///        "Type":"true"
        ///          }
        ///         }
        ///        }
        ///       }
       ///      }
        /// </remarks>


        [HttpPost("~/getAccountSelectFields01")]
      
        public JsonResult getAccountSelectFields([FromBody] GetAccountSelectFields001 getAccountSelectFields001, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields001);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }


        ///  <summary>
        /// Get Account Select Fields Example 2
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///   <remarks>
        ///   Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///
        ///Sample request:
        /// 
        ///    {
        ///    "Request": {
        ///    "Attributes": {
        ///    "MessageId": "1",
        ///    "BranchId": "1"
        ///    },
        ///    "AccountNumber": "0001234560",
        ///    "Credentials": {
        ///     "AdministrativeCredentials": {
        ///      "Password": "*******"
        ///      }
        ///    },
        ///    "DeviceInformation": {
        ///      "Attributes": {
        ///      "DeviceType": "Computacenter",
        ///      "DeviceNumber": "123456"
        ///    },
        ///    "ElementValue": ""
        ///    },
        ///    "SelectableFields": {
        ///       "IncludeAllAccountFields": "false",
        ///       "ShareSelectableFields":{
        ///       "MicrAcctNumber":"true",
        ///       "AvailableBalance":"true",
        ///       "Balance":"true",
        ///       "Description":"true",
        ///       "DivRate":"true",
        ///       "DivYtd":"true",
        ///       "DividendDue":"true",
        ///       "Id":"true",
        ///       "Type":"true"
        ///         }
        ///        }
        ///       }
        ///      }
        ///     }
        /// </remarks>


        [HttpPost("~/getAccountSelectFields02")]

        public JsonResult GetAccountSelectFields002([FromBody] GetAccountSelectFields002 getAccountSelectFields002, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields002);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }


        ///  <summary>
        /// Get Account Select Fields Example 3
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///   <remarks>
        ///   Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///
        ///Sample request:
        /// 
        ///    {
        ///    "Request": {
        ///    "Attributes": {
        ///    "MessageId": "1",
        ///    "BranchId": "1"
        ///    },
        ///    "AccountNumber": "0001234560",
        ///    "Credentials": {
        ///     "AdministrativeCredentials": {
        ///      "Password": "*******"
        ///      }
        ///    },
        ///    "DeviceInformation": {
        ///      "Attributes": {
        ///      "DeviceType": "Computacenter",
        ///      "DeviceNumber": "123456"
        ///    },
        ///    "ElementValue": ""
        ///    },
        ///    "SelectableFields": {
        ///       "IncludeAllAccountFields": "false",
        ///       "ShareSelectableFields":{
        ///       "AvailableBalance":"true",
        ///       "Balance":"true",
        ///       "DivRate":"true",
        ///       "DivYtd":"true",
        ///       "DividendDue":"true
        ///       "Type":"true"
        ///         }
        ///        }
        ///       }
        ///      }
        ///     }
        /// </remarks>


        [HttpPost("~/getAccountSelectFields03")]

        public JsonResult GetAccountSelectFields003([FromBody] GetAccountSelectFields003 getAccountSelectFields003, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields003);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }

        ///  <summary>
        /// Get Account Select Fields Example 5
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///   Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///  
        /// Sample request:
        /// 
        ///      {
        ///        "Request": 
        ///       {
        ///        "Attributes":  
        ///        {
        ///         "MessageId": "1",
        ///         "BranchId": "1"
        ///        },
        ///       "AccountNumber": "0001234560",
        ///       "Credentials": 
        ///       {
        ///       "AdministrativeCredentials": 
        ///       {
        ///       "Password": "*******"
        ///       }
        ///       },
        ///     "DeviceInformation": 
        ///     {
        ///       "Attributes": 
        ///       {
        ///       "DeviceType": "Computacenter",
        ///       "DeviceNumber": "123456"
        ///       },
        ///       "ElementValue": ""
        ///       },
        ///      "SelectableFields":
        ///      {
        ///        "IncludeAllAccountFields": "false",
        ///        "NameSelectableFields":{
        ///        "IncludeAllNameFields":"false",
        ///        "NameFields":
        ///        {
        ///         "BirthDate":"true"
        ///         }
        ///        }
        ///       }
        ///      }
        ///     }
        ///</remarks>
        [HttpPost("~/getAccountSelectFields05")]

        public JsonResult GetAccountSelectFields005([FromBody] GetAccountSelectFields005 getAccountSelectFields005, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields005);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }


        ///  <summary>
        /// Get Account Select Fields Example 6
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///   Method getAccountSelectFields returns field 
        ///   values from a record specified by ID or locator, but it also allows you to
        ///   specify which field values you want returned from that record and which
        ///   child records and fields you want returned.
        /// 
        /// 
        /// Sample request:
        /// 
        ///     {
        ///       "Request": {
        ///        "Attributes": {
        ///         "MessageId": "1",
        ///         "BranchId": "1"
        ///          },
        ///         "AccountNumber": "0001234560",
        ///         "Credentials": {
        ///          "AdministrativeCredentials": {
        ///          "Password": "*******"
        ///       }
        ///     },
        ///        "DeviceInformation": {
        ///        "Attributes": {
        ///            "DeviceType": "Computacenter",
        ///            "DeviceNumber": "123456"
        ///      },
        ///        "ElementValue": ""
        ///      },
        ///        "SelectableFields": {
        ///          "IncludeAllAccountFields": "false",
        ///          "NameSelectableFields":{
        ///             "IncludeAllNameFields":"false",
        ///             "NameFields":{
        ///               "BirthDate":"true"
        ///          }
        ///         }
        ///        }
        ///       }
        ///      }
        ///</remarks>
        [HttpPost("~/getAccountSelectFields06")]

        public JsonResult GetAccountSelectFields006([FromBody] GetAccountSelectFields006 getAccountSelectFields006, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields006);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Account Select Fields example 7
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///
        /// 
        /// Sample request:
        /// 
        ///     {
        ///          "Request":
        ///          {
        ///            "Attributes":
        ///             {
        ///               "MessageId": "1",
        ///               "BranchId": "1"
        ///              },
        ///           "AccountNumber": "0001234560",
        ///          "Credentials": 
        ///           {
        ///             "AdministrativeCredentials":
        ///             {
        ///                "Password": "*******"
        ///              }
        ///            },
        ///          "DeviceInformation": 
        ///          {
        ///             "Attributes": 
        ///             {
        ///              "DeviceType": "Computacenter",
        ///              "DeviceNumber": "123456"
        ///             },
        ///           "ElementValue": ""
        ///          },
        ///           "IncludeAllAccountFields": "false",
        ///           "LoanSelectableFields":
        ///          {
        ///              "IncludeAllLoanFields":"false",
        ///              "LoanFields":
        ///              {
        ///                   "Id":"true"
        ///               }
        ///        	 },
        ///           "ShareSelectableFields":
        ///           {
        ///              "IncludeAllShareFields":"false",
        ///               "ShareFields":
        ///               {
        ///                   "Id":"true"
        ///                }
        ///            }
        ///          }
        ///        }
        ///      }
        ///</remarks>
        [HttpPost("~/getAccountSelectFields07")]

        public JsonResult GetAccountSelectFields007([FromBody] GetAccountSelectFields007 getAccountSelectFields007, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields007);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Account Select Fields example 8
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///
        /// 
        /// Sample request:
        /// 
        ///      {
        ///       "Request": {
        ///         "Attributes": {
        ///         "MessageId": "1",
        ///         "BranchId": "1"
        ///          },
        ///       "AccountNumber": "0001234560",
        ///       "Credentials": {
        ///       "AdministrativeCredentials": {
        ///       "Password": "*******"
        ///        }
        ///      },
        ///       "DeviceInformation": {
        ///       "Attributes": {
        ///       "DeviceType": "Computacenter",
        ///       "DeviceNumber": "123456"
        ///       },
        ///       "ElementValue": ""
        ///      },
        ///      "SelectableFields": {
        ///      "IncludeAllAccountFields": "false",
        ///	     "CardSelectableFields":{
        ///         "IncludeAllCardFields":"false",
        ///         "CardFields":{
        ///             "ActiveDate":"true",
        ///             "CloseDate":"true",
        ///             "IssueDate":"true",
        ///             "Number":"true"
        ///              }
        ///		       }
        ///        }
        ///       }
        ///     }
        ///</remarks>
    [HttpPost("~/getAccountSelectFields08")]

        public JsonResult GetAccountSelectFields008([FromBody] GetAccountSelectFields008 getAccountSelectFields008, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields008);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }



        ///  <summary>
        /// Get Account Select Fields example 9
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///
        /// 
        /// Sample request:
        /// 
        ///       {
        ///          "Request": {
        ///          "Attributes": {
        ///          "MessageId": "1",
        ///          "BranchId": "1"
        ///          },
        ///         "AccountNumber": "0001234560",
        ///         "Credentials": {
        ///            "AdministrativeCredentials": {
        ///            "Password": "*******"
        ///            }
        ///         },
        ///          "DeviceInformation": {
        ///         "Attributes": {
        ///              "DeviceType": "Computacenter",
        ///              "DeviceNumber": "123456"
        ///               },
        ///         "ElementValue": ""
        ///          },
        ///          "IncludeAllAccountFields": "false",
        ///          "LoanSelectableFields":{
        ///          "IncludeAllLoanFields":"false",
        ///          "LoanFields":{
        ///               "Id":"true"
        ///             }
        ///            }
        ///           }
        ///          }
        ///         }
        ///</remarks>
        [HttpPost("~/getAccountSelectFields09")]

        public JsonResult GetAccountSelectFields009([FromBody] GetAccountSelectFields009 getAccountSelectFields009, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields009);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }


        ///  <summary>
        /// Get Account Select Fields example 10
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///
        /// 
        /// Sample request:
        /// 
        ///       {
        ///       "Request": {
        ///            "Attributes": {
        ///             "MessageId": "1",
        ///             "BranchId": "1"
        ///             },
        ///           "AccountNumber": "0001234560",
        ///            "Credentials": {
        ///                 "AdministrativeCredentials": {
        ///                  "Password": "*******"
        ///                }
        ///            },
        ///            "DeviceInformation": {
        ///            "Attributes": {
        ///                "DeviceType": "Computacenter",
        ///                "DeviceNumber": "123456"
        ///             },
        ///           "ElementValue": ""
        ///           },
        ///           "SelectableFields": {
        ///            "IncludeAllAccountFields": "false",
        ///            "NameSelectableFields":{
        ///            "IncludeAllNameFields":"false",
        ///            "NameFields":{
        ///                 "HomePhone":"true",
        ///                "WorkPhone":"true"
        ///           }
        ///          }
        ///         }
        ///        }
        ///       }
        ///</remarks>
        [HttpPost("~/getAccountSelectFields010")]

        public JsonResult GetAccountSelectFields010([FromBody] GetAccountSelectFields010 getAccountSelectFields010, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields010);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }

        ///  <summary>
        /// Get Account Select Fields example 11
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///
        /// 
        /// Sample request:
        /// 
        ///       {
        ///          "Request": {
        ///            "Attributes": {
        ///            "MessageId": "1",
        ///            "BranchId": "1"
        ///          },
        ///          "AccountNumber": "0001234560",
        ///          "Credentials": {
        ///               "AdministrativeCredentials": {
        ///               "Password": "*******"
        ///           }
        ///          },
        ///         "DeviceInformation": {
        ///         "Attributes": {
        ///         "DeviceType": "Computacenter",
        ///         "DeviceNumber": "123456"
        ///          },
        ///         "ElementValue": ""
        ///         },
        ///        "SelectableFields": {
        ///           "IncludeAllAccountFields": "false",
        ///	          "PreferenceSelectableFields":{
        ///               "IncludeAllPreferenceFields":"false",
        ///               "PreferenceFields":{
        ///                    "AudioAccess":"true"
        ///             }
        ///		       }
        ///           }
        ///          }
        ///         }
        ///</remarks>
        [HttpPost("~/getAccountSelectFields011")]

        public JsonResult GetAccountSelectFields011([FromBody] GetAccountSelectFields011 getAccountSelectFields011, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields011);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Account Select Fields example 12
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  Method getAccountSelectFields returns field 
        /// values from a record specified by ID or locator, but it also allows you to
        ///specify which field values you want returned from that record and which
        ///child records and fields you want returned.
        ///
        /// 
        /// Sample request:
        /// 
        ///      {
        ///          "Request": {
        ///            "Attributes": {
        ///            "MessageId": "1",
        ///            "BranchId": "1"
        ///             },
        ///          "AccountNumber": "0001234560",
        ///          "Credentials": {
        ///             "AdministrativeCredentials": {
        ///             "Password": "*******"
        ///              }
        ///            },
        ///          "DeviceInformation": {
        ///          "Attributes": {
        ///            "DeviceType": "Computacenter",
        ///            "DeviceNumber": "123456"
        ///             },
        ///           "ElementValue": ""
        ///            },
        ///           "SelectableFields": {
        ///              "IncludeAllAccountFields": "false",
		///		         "LoanSelectableFields":{
        ///             "IncludeAllLoanFields":"true",
        ///             "LoanFields":{}
	    ///               }
        ///              }
        ///             }
        ///            }
        ///</remarks>
        [HttpPost("~/getAccountSelectFields012")]

        public JsonResult GetAccountSelectFields012([FromBody] GetAccountSelectFields012 getAccountSelectFields012, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getAccountSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getAccountSelectFields012);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Share Transaction Paged List Sample
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  Method  returns the values of all fields in 
        /// multiple records of the specified type.You can limit the number of records
        /// to return and provide a number of records to skip.
        /// 
        /// For example, the following getShare message returns the 
       /// values of the specified fields in Share ID 20 (the checking account)
                ///
                /// 
                /// Sample request:
                /// 
                ///       {
                ///          "Request": {
                ///          "Attributes": {
                ///            "MessageId": "1",
                ///             "BranchId": "1"
                ///          },
                ///          "AccountNumber": "0001234560",
                ///          "ShareId":"0020",
                ///          "Credentials": {
                ///          "AdministrativeCredentials": {
                ///         "Password": "*******"
                ///          }
                ///         },
                ///        "DeviceInformation": {
                ///          "Attributes": {
                ///             "DeviceType": "Computacenter",
                ///             "DeviceNumber": "123456"
                ///             },
                ///            "ElementValue": ""
                ///          },
                ///        "PagingRequestContext":{
                ///          "NumberOfRecordsToReturn":"5",
                ///          "NumberOfRecordsToSkip":"0"
                ///        }
                ///       }
                ///      }
                ///</remarks>
                [HttpPost("~/getShareTransactionPagedList")]

        public JsonResult GetShareTransactionPagedList([FromBody] GetShareTransactionPagedList getShareTransactionPagedList, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getShareTransactionPagedList", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getShareTransactionPagedList);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get Share Transaction Paged with selected fields Sample
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        /// returns field values from all the selected child records of each record. 
        ///For example, the following searchShareTransactionPagedSelectFields message returns
        ///the values of the specified fields in all shares, all fields in all Share Hold
        ///records of each share, and the specified fields of all Share Name records
        ///under each share
        ///
        ///
        /// 
        /// Sample request:
        /// 
        ///       {
        ///           "Request": {
        ///            "Attributes": {
        ///              "MessageId": "1",
        ///              "BranchId": "1"
        ///            },
        ///          "AccountNumber": "0001234560",
        ///          "ShareId":"0020",
        ///          "Credentials": {
        ///              "AdministrativeCredentials": {
        ///              "Password": "*******"
        ///            }
        ///           },
        ///         "DeviceInformation": {
        ///            "Attributes": {
        ///              "DeviceType": "Computacenter",
        ///              "DeviceNumber": "123456"
        ///               },
        ///           "ElementValue": ""
        ///             },
        ///         "PagingRequestContext":{
        ///              "NumberOfRecordsToReturn":"5",
        ///              "NumberOfRecordsToSkip":"0"
        ///             }
        ///         "SelectableFields":{
        ///          "IncludeAllShareTransactionFields":"true",
        ///          "ShareTransactionFields":{}
        ///           },
        ///           "Query":"Comment='VISA PAYMENT'"
        ///          }
        ///         }
        ///</remarks>
        [HttpPost("~/searchShareTransactionPagedSelectFields")]

        public JsonResult SearchShareTransactionPagedSelectFields([FromBody] searchShareTransactionPagedSelectFields searchShareTransactionPagedSelectFields, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/searchShareTransactionPagedSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(searchShareTransactionPagedSelectFields);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
        ///  <summary>
        /// Get IRS Fields  Sample
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  return the values of selected fields in records of the selected type that match 
        ///  the search criteria you specify.You can limit the number of records and provide a
        /// number of records to skip.
        ///
        ///
        /// 
        /// Sample request:
        /// 
        ///      {
        ///          "Request": {
        ///            "Attributes": {
        ///             "MessageId": "1",
        ///             "BranchId": "1"
        ///            },
        ///          "AccountNumber": "0001234560",
        ///           "Credentials": {
        ///                "AdministrativeCredentials": {
        ///                "Password": "*******"
        ///                 }
        ///             },
        ///           "DeviceInformation": {
        ///           "Attributes": {
        ///              "DeviceType": "Computacenter",
        ///              "DeviceNumber": "123456"
        ///             },
        ///           "ElementValue": ""
        ///          },
        ///          "PagingRequestContext":{
        ///              "NumberOfRecordsToReturn":"5",
        ///              "NumberOfRecordsToSkip":"0"
        ///            }
        ///          "SelectableFields": {
        ///          "IncludeAllAccountFields": "false",
        ///          "IrsSelectableFields":{
       ///                "IncludeAllIrsFields":"false",
      ///                 "IrsFields":{
      ///                    "ActualMaxContribution":"true",
     ///                     "IrsHolderBirthDate":"true",
     ///                     "IrsPlan":"true",
     ///                     "OpenDate":"true"
    ///                }
     ///              }
    ///              }
    ///             }
    ///            }
    ///</remarks>
        [HttpPost("~/getAccountSelectFields")]

        public JsonResult GetAccountSelectFields([FromBody] GetIRSSelectableFields getIRSSelectFields, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/searchShareTransactionPagedSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getIRSSelectFields);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }

        ///  <summary>
        /// Get IRS  Selected Fields  Sample
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  return the values of selected  IRS fields in records of the selected type that match 
        ///  the search criteria you specify.You can limit the number of records and provide a
        /// number of records to skip.
        ///
        ///
        /// 
        /// Sample request:
        /// 
        ///      {
        ///          "Request": {
        ///            "Attributes": {
        ///             "MessageId": "1",
        ///             "BranchId": "1"
        ///            },
        ///          "AccountNumber": "0001234560",
        ///           "Credentials": {
        ///                "AdministrativeCredentials": {
        ///                "Password": "*******"
        ///                 }
        ///             },
        ///           "DeviceInformation": {
        ///           "Attributes": {
        ///              "DeviceType": "Computacenter",
        ///              "DeviceNumber": "123456"
        ///             },
        ///           "ElementValue": ""
        ///          },
        ///         "SelectableFields":{
        ///               "IncludeAllIrsFields":"false",
        ///                "IrsFields":{
        ///                    "ContrLastYear":"true",
        ///                    "ContrThisYear":"true",
        ///                    "ContributionYear":"true",
        ///                    "DistrLastYear":"true",
        ///                    "DistrThisYear":"true",
        ///                    "PayoffAmount":"true"
        ///                }
        ///               }
        ///              }
        ///             }
        ///</remarks>
        [HttpPost("~/getIrsSelectFields")]

        public JsonResult GetIrsSelectFields([FromBody] GetIrsSelectFields getIRSSelectFields, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/getIrsSelectFields", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(getIRSSelectFields);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }

        ///  <summary>
        /// Update Account Sample
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        ///  The updatePreferenceByID  allow you to modify fields in a 
        ///  specified record on the Episys host.You can modify only those fields that
        ///  are normally accessible to a front-end user.
        ///
        /// 
        /// Sample request:
        /// 
        /// 
        ///      {
        ///         "Request": {
        ///        "Attributes": {
        ///         "MessageId": "1",
        ///        "acc:BranchId": "1"
        /// 
        ///          },
        ///          "PreferenceLocator":"2",
        ///          "PreferenceUpdateableFields":{
        ///          "AudioAccess":"1234"
        ///         },
        ///           "AccountNumber": "0001234560",
        ///           "Credentials": {
        ///                 "AdministrativeCredentials": {
        ///           }
        ///         },
        ///       "DeviceInformation": {
        ///       "Attributes": {
        ///       "DeviceType": "Computacenter",
        ///       "DeviceNumber": "123456"
        ///         },
        ///           "ElementValue": ""
        ///         }
        ///        }
        ///      }
        /// </remarks>

        [HttpPost("~/updatePreferenceByID")]

        public JsonResult UpdatePreferenceByID([FromBody] UpdateAcct updateAccount, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/AccountService/UpdatePreferenceByID", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(updateAccount);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }
    }
}
