using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//using Vonage;
//using Vonage.Messaging;
//using Vonage.Request;

namespace DataAccessLayer.Repositories
{
    public class MessageRepository
    {
        //public int SendMessage(string bodyMessage, string toNumber, string fromNumber)
        //{
        //    try
        //    {
        //        var credentials = Credentials.FromApiKeyAndSecret("0e805da4", "uHaFdo0pX1MXZuoi");
        //        var vonageClient = new VonageClient(credentials);

        //        var smsRequest = new SendSmsRequest
        //        {
        //            To = toNumber,
        //            From = fromNumber,
        //            Text = bodyMessage,
        //        };

        //        var response = vonageClient.SmsClient.SendAnSms(smsRequest);

        //        return int.Parse(response.Messages[0].Status);
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        throw new ApplicationException("An error occurred while sending a message.", ex);
        //    }
        //}
    }
}
