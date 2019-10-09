using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio.Types;

namespace CommunityOrganizer.Models
{
    public class Text
    {

        public string AccountSid { get; set; }

        public string AuthToken { get; set; }

        public PhoneNumber ToNumber { get; set; }

        public PhoneNumber FromNumber { get; set; }
    }
}
