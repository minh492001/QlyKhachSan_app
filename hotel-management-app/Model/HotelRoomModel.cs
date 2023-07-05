using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_app.Model
{
    public class HotelRoomModel : BaseModel
    {
        public int Id { get; set; }
        public string NoRoom { get; set; }
        public int Floor { get; set; }
        public int RoomType { get; set; }
        public int NumberBed { get; set; }
        public int Area { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int RoomStatus { get; set; }
        public string Option { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
