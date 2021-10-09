using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class PopEmail
    {
        public int MessageNumber { get; set; }
        public string From { get; set; }
        public string Address { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
        public DateTime DateSent { get; set; }
        public string Date { get; set; }
        public DateTime ReplyDate { get; set; }

        //  public List<Attachment> Attachments { get; set; }

        // [JsonProperty("prospectid")]
        public string ProspectId { get; set; }

        //[JsonProperty("userid")]
        public string UserId { get; set; }

        // [JsonProperty("eventpasscode")]
        public string EventPasscode { get; set; }

        // [JsonProperty("mmsimageurl")]
        public string MMSImageURL { get; set; }
        public Int32 Id { get; set; }

        public byte[] IMG { get; set; }

        public string ImgBase64Code { get; set; }
        public string ImgBase64Stream { get; set; }
        public string ImageName { get; set; }

    }
}
