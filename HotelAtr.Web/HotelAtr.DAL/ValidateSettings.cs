using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAtr.DAL
{
    public class ValidateSettings : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return Convert.ToInt32(value) >= 0;
        }
    }

    public class AppointValidate : ValidationAttribute
    {
        public AppointValidate()
        {
            ErrorMessage = "Нельзя установить цену для VIP ниже 100 уе";
        }
        public override bool IsValid(object value)
        {
            Rooms rooms = value as Rooms;

            if (rooms.Floor >= 10 && rooms.Price <= 200)
                return false;
            else
                return true;
        }
    }
}
