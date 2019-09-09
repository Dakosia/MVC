using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelAtr.DAL;

namespace HotelAtr.BLL
{
    public class ServiceRoom
    {
        static HotelAtrEntities db = new HotelAtrEntities();

        public static bool AddRoom(Rooms room, out string message)
        {
            try
            {
                db.Rooms.Add(room);
                db.SaveChanges();

                message = "";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool RoomReserve(RoomReserve roomReserve, out string message)
        {
            try
            {
                roomReserve.StatusId = 0;
                db.RoomReserve.Add(roomReserve);
                db.SaveChanges();

                message = "Ok";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool EditRoomReserve(RoomReserve roomReserve, out string message)
        {
            try
            {
                RoomReserve roomR = db.RoomReserve.Find(roomReserve.RoomReserveId);
                if (roomR != null)
                {
                    roomR.Arrive = roomReserve.Arrive;
                    roomR.Departure = roomReserve.Departure;
                    db.SaveChanges();
                    message = "Ok";
                    return true;
                }
                message = "Room reserve not found";
                return false;
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool ApproveRoomReserve(int RoomReserveId, out string message)
        {
            try
            {
                RoomReserve roomR = db.RoomReserve.Find(RoomReserveId);
                if (roomR != null)
                {
                    roomR.StatusId = 1;
                    db.SaveChanges();
                    message = "Ok";
                    return true;
                }
                message = "Room reserve not found";
                return false;

            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool DeleteRoomReserve(int RoomReserveId, out string message)
        {
            try
            {
                RoomReserve roomR = db.RoomReserve.Find(RoomReserveId);
                if (roomR != null)
                {
                    db.RoomReserve.Remove(roomR);
                    db.SaveChanges();
                    message = "Ok";
                    return true;
                }
                message = "Room reserve not found";
                return false;

            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public static bool DeclineRoomReserve(int RoomReserveId, out string message)
        {
            try
            {
                RoomReserve roomR = db.RoomReserve.Find(RoomReserveId);
                if (roomR != null)
                {
                    roomR.StatusId = 2;
                    db.SaveChanges();
                    message = "Ok";
                    return true;
                }
                message = "Room reserve not found";
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
