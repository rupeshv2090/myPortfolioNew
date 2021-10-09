using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPortfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtraController : ControllerBase
    {
        // GET: api/<ExtraController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ExtraController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExtraController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExtraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExtraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("ReadXML")]
        public string ReadXML()
        {
            var userName = "leads@nsightlive.com";

            var password = "21%_Nsevents*";
            PopEmail emailModel = new PopEmail();
            var newText = "";
            using (var client = new ImapClient())
            {
                try
                {

                    client.Connect("imap.gmail.com", Convert.ToInt32("993"), true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(userName, password);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadWrite);
                    var results = inbox.Search(SearchOptions.All, (SearchQuery.NotSeen));
                    foreach (var uniqueId in results.UniqueIds)
                    {
                        var message = inbox.GetMessage(uniqueId);
                        #region Message Value Asign into Model
                        emailModel.From = Convert.ToString(message.From);
                        emailModel.To = Convert.ToString(message.To);
                        //emailModel.Cc = Convert.ToString(message.Cc);
                        emailModel.Subject = Convert.ToString(message.Subject);
                        emailModel.Body = Convert.ToString(message.HtmlBody.Replace("&lt;","<").Replace("&gt;",">").Replace("&quot;", "\"")
                            .Replace("<div dir=\"ltr\">", "").Replace("<br></div>", "").Replace("<br>", "").Replace(System.Environment.NewLine, ""));
                        #endregion
                        
                        
                        // Replace new line with <br/> tag    
                        newText = Regex.Replace(emailModel.Body,@"\s+", " ");
                        newText = Regex.Replace(newText,"> <", "><");
                        // #region Save in Database
                        ParseHelpers parseHelpers = new ParseHelpers();
                        adf adfXml = parseHelpers.FromXml<adf>(newText);
                        NewLead newLead = new NewLead();
                        newLead.FirstName = adfXml.prospect.customer.contact.name[0].Value;
                        newLead.LastName = adfXml.prospect.customer.contact.name[1].Value;
                        newLead.PhoneNumber = adfXml.prospect.customer.contact.phone.ToString();
                        newLead.Email = adfXml.prospect.customer.contact.email.a.Value;
                        newLead.EventPassCode = adfXml.prospect.customer.Event.eventpasscode;
                        #region Mark email as read
                        // ServiceLog.WriteErrorLog(TurnKeyServiceTestResource.Error + "Test Error Log string" + activityHistoryId);
                        //if (activityHistoryId > 0)
                        //{
                        //    client.Inbox.AddFlags(uniqueId, MessageFlags.Seen, true); // mark as read
                        //    client.Disconnect(true);
                        //}
                        #endregion
                    }

                }
                catch (Exception ex)
                {
                    client.Disconnect(true);
                }
                return newText;
            }

        }

        [HttpGet("{sAddress}/{dAddress}")]
        public int GetDistance(string sAddress, string dAddress)
        {
            //var locationService = new GoogleLocationService();
            //var point = locationService.GetLatLongFromAddress(address);

            //var latitude = point.Latitude;
            //var longitude = point.Longitude;

            //var sCoord = new GeoCoordinate(sLatitude, sLongitude);
            //var eCoord = new GeoCoordinate(eLatitude, eLongitude);

            //return sCoord.GetDistanceTo(eCoord);

            return 10;
        }
    }
}
