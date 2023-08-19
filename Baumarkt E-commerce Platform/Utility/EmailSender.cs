using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;

namespace Baumarkt_E_commerce_Platform.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration configuration;

        public MailJetSettings mailJetSettings { get; set; }


        public EmailSender(IConfiguration configuration, MailJetSettings mailJetSettings)
        {
            this.configuration = configuration;
            this.mailJetSettings = mailJetSettings;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }


        public async Task Execute(string subject, string email, string body)
        {

            mailJetSettings= configuration.GetSection("MailJet").Get<MailJetSettings>();


            MailjetClient client = new MailjetClient(mailJetSettings.AppKey,mailJetSettings.AppSecret)
            {
                //Version = ApiVersion.V3_1,



            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.Messages, new JArray {
                new JObject {
                 {"From", new JObject {
                  {"Email", "momchil.palazov@gmail.com"},
                  {"Name", "SenderProton"}
                  }},
                 {"To", new JArray {
                  new JObject {
                   {"Email", email},
                   {"Name", "passenger 1"}
                   }
                  }},
                 {"Subject", subject},
                 {"TextPart", "Dear passenger 1, welcome to Mailjet! May the delivery force be with you!"},
                 {"HTMLPart", body}
                 }
                   });
            MailjetResponse response = await client.PostAsync(request);

        }
    }
}


