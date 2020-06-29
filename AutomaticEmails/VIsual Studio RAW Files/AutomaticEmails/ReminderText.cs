using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace AutomaticEmails
{
    static class ReminderText
    { 
        public static void SendText(decimal number, string msg)
        {
            TwilioClient.Init(Settings.Default.CellUsername, Settings.Default.CellPassword);

            var message = MessageResource.Create(
                new PhoneNumber("+" + number.ToString()), //Customer Phone Number
                from: new PhoneNumber(Settings.Default.VitualNo), //My Virtural Phone Number
                //Message Text
                body: String.Format(msg)
            ) ;
            Console.WriteLine(message.Sid);
        }

        public static void SendHoldText(string name, decimal number)
        {
            TwilioClient.Init(Settings.Default.CellUsername, Settings.Default.CellPassword); //Twiio Authentication

            var message = MessageResource.Create(
                new PhoneNumber("+" + number.ToString()), //The User's Cellphone Number
                from: new PhoneNumber(Settings.Default.VitualNo), //My Twilio Virtual Cellphone Number
                body: String.Format("Hi {0}! \nGreat News, you have a Book avaliable for pickup. \nSee your Email for more Info. \nRegards \nThe Library \n \n--DO NOT REPLY", name)
            );
            Console.WriteLine(message.Sid);
        }
    }
}
