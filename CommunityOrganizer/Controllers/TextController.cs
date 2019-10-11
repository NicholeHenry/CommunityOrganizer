using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio;
using Twilio.AspNet.Core;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using CommunityOrganizer.Models;
using Microsoft.Extensions.Options;
using System.Configuration;

namespace CommunityOrganizer.Controllers
{
    public class TextController : TwilioController
    {
       

        public IActionResult BoilOrder()
        {

            var accountSid = "";
            var authToken = "";

            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("");
            var from = new PhoneNumber("");

            MessageResource message = MessageResource.Create(
                to: to,
                from: from,
                body: "Boil Order in place for 24 hours."
                );

            return Content(message.Sid);

        }
         public IActionResult FloodWarning()


        {
            var accountSid = "";
            var authToken = "";

            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("");
            var from = new PhoneNumber("");

            MessageResource message = MessageResource.Create(
                to: to,
                from: from,
                body: "Flash Flood Waring:Be aware of any signs of heavy rain.+" +
                "Move to higher ground if rapidly rising water is seen or heard." +
                "Do not attempt to cross any flowing water"
                );

            return Content(message.Sid);

        }

        public IActionResult TornadoWatch()
        {


            var accountSid = "";
            var authToken = "";

            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("");
            var from = new PhoneNumber("");

            MessageResource message = MessageResource.Create(
                to: to,
                from: from,
                body: "Tornado Watch: Keep alert and watch for changing weather conditions."+
                        "Listen to your local news reports and weather updates."+
                      "Review your family or business emergency preparedness plan."+
                        "Review your disaster kit."+
                        "Be ready to see shelter at a moment's notice"
                );

            return Content(message.Sid);


        }

        public IActionResult TornadoWarning()
        {


            var accountSid = "";
            var authToken = "";

            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("");
            var from = new PhoneNumber("");

            MessageResource message = MessageResource.Create(
                to: to,
                from: from,
                body: "Take shelter immediately; do not stay in a mobile home."+
                        "Listen to your local radio for updates."+
                        "Close the windows in your home or business."+
                        "If you are in a car or other mobile vehicle, get out immediately and go to a nearby sturdy building or storm structure."+
                        "Do not try to outrun a tornado in a car; do not park the car under a highway overpass or bridge(more flying debris and stronger winds there)."+
                        "If you are outside without nearby shelter, lie down in a ditch, ravine or depression and cover your head with your hands."
                );

            return Content(message.Sid);

        }

    }

}