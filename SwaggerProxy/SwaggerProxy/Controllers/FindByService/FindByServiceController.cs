using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Amqp.Framing;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SwaggerProxy.Models;

using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwaggerProxy.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class Find_By_ServiceController : Controller
    {



        ///  <summary>
        ///  Find By SSN
        /// </summary>
        /// <remarks>
        /// The FindBy Service  allow you to look up a member’s account
        /// number by  Social Security Number.
        ///IMPORTANT :must enable the FindBy Service on the instance
        /// </remarks>
        /// <param BaseURL="URLRequest">operation name</param>


        [HttpPost("~/FindBySSN")]
   
        public JsonResult FindBySSN([FromBody] FindBySSN findbyssn, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/FindByService/findBySSN", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(findbyssn);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }


        ///  <summary>
        /// Find By Lookup
        /// </summary>
        /// <param BaseURL="URLRequest">operation name</param>
        ///  <remarks>
        /// All  lookup types are custom to the Credit Union.
        /// 
        /// Note: Lookup records serve two general purposes: 
        /// 1- Some edit runs use Lookup records to locate the account to which
        /// an item should post.Many financial institutions assign checking
        /// account numbers that differ significantly from the member's 
        /// primary account number.If your financial institution follows this
        ///practice, your draft and ACH edit runs almost certainly require
        ///Lookup records to locate accounts. 
        ///2- You can use Lookup records to cross-reference any identifying
        ///number to the Account record.
        ///
        /// 
        ///IMPORTANT :must enable the FindBy Service on the instance
        /// </remarks>
        [HttpPost("~/FindByLookUp")]
       
        public JsonResult FindByLookUp([FromBody] FindByLookUp findbylookup, string URL)
        {

            var options = new RestClientOptions(URL)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(URL + "/SOAP/FindByService/findByLookup", Method.Post);
            request.AddHeader("Proxy-Authorization", "Pass1");
            request.AddHeader("Content-Type", "application/json");

            var body = Newtonsoft.Json.JsonConvert.SerializeObject(findbylookup);

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);


            return Json(response.Content);
        }


    }
}
