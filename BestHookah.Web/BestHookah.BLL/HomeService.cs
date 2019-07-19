using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestHookah.DAL;

namespace BestHookah.BLL
{
    public class HomeService
    {
        static BestHookahEntities db = new BestHookahEntities();

        public static List<Reviews> Review()
        {
            Random rnd = new Random();
            int rnd1 = 0, rnd2 = 0;
            while (rnd1 == rnd2)
            {
                rnd1 = rnd.Next(db.Reviews.Count());
                rnd2 = rnd.Next(db.Reviews.Count());
            }
            List<Reviews> reviews = new List<Reviews>();
            reviews.Add(db.Reviews.ToList().ElementAt(rnd1));
            reviews.Add(db.Reviews.ToList().ElementAt(rnd2));
            return reviews;
        }

        public static bool AddReview(Reviews review, out string message)
        {
            try
            {
                db.Reviews.Add(review);
                db.SaveChanges();

                message = "Review was added successfully";
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
