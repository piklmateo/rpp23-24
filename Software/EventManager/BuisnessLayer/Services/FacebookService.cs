using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BuisnessLayer.Services
{
    ///<author>Toni Leo Modrić Dragičević</author>
    public class FacebookService
    {
        FacebookRepository facebookRepository = new FacebookRepository();
        public void ShareFacebook(string message, string image)
        {
           facebookRepository.ShareFacebook(message, image);
        }
    }
}
