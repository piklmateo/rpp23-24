using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Iznimke;
using Facebook;

namespace DataAccessLayer.Repositories
{
    public class FacebookRepository
    {
        public void ShareFacebook(string message, string image)
        {
            try
            {
                FacebookClient fb = new FacebookClient();
                fb.AppId = "596681999284443";
                fb.AppSecret = "812d3af8350a55ed52608e2427103ff7";
                fb.AccessToken = "EAAIerdqceNsBOymZCwpz2sN5gO5dkdSBrUkHTrgfD4T66iZCs4Pyv0ZAKVpU8bE9TZBf7gK01DKuVv2htZCmzSG2Ex7s6UYujGpO7ubhVtwvKirY7SA22sTmnOM2P9AlslgCDfhowzXu99AT3FlK0U2R7F5XG1eHFtpfOLzBR0At8kY88E6Vky56M4ZBhe5tgmOSYblZAsZD";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "message", message},
                    { "url", image}
                };

                fb.Post("/me/photos", parameters);
            }
            catch (FacebookException)
            {
            }
        }
    }
}
