using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestHookah.DAL;

namespace BestHookah.BLL
{
    public class OffersService
    {
        static BestHookahEntities db = new BestHookahEntities();

        public static bool AddOffer(Offers offer, out string message)
        {
            try
            {
                db.Offers.Add(offer);
                db.SaveChanges();

                message = "Offer was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
