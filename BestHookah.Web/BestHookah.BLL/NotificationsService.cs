using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestHookah.DAL;

namespace BestHookah.BLL
{
    public class NotificationsService
    {
        static BestHookahEntities db = new BestHookahEntities();

        public static bool AddUser(Notifications user, out string message)
        {
            try
            {
                db.Notifications.Add(user);
                db.SaveChanges();

                message = "User was added successfully";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool EditUser(Notifications user, out string message)
        {
            try
            {
                Notifications u = db.Notifications.Find(user.UserId);

                if (u != null)
                {
                    u.UserName = user.UserName;
                    u.UserEmail = user.UserEmail;
                    u.UserPhone = user.UserPhone;
                    db.SaveChanges();

                    message = "User was edited successfully";
                    return true;
                }
                message = "Error";
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool DeleteUser(int UserId, out string message)
        {
            try
            {
                Notifications user = db.Notifications.Find(UserId);
                if (user != null)
                {
                    db.Notifications.Remove(user);
                    db.SaveChanges();

                    message = "User was deleted successfully";
                    return true;
                }
                message = "Error";
                return false;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}
