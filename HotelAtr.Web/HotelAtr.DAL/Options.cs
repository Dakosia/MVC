//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelAtr.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Options
    {
        public int OptionId { get; set; }
        public Nullable<int> RoomOptionsId { get; set; }
        public Nullable<int> RoomId { get; set; }
    
        public virtual RoomOptions RoomOptions { get; set; }
        public virtual Rooms Rooms { get; set; }
    }
}
