using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_app.Models
{
    public class HotelRoomModel
    {
        public int id { get; set; }
        public string noRoom { get; set; } = "";
        public int floor { get; set; }
        public int roomType { get; set; }
        public int numberBed { get; set; }
        public int area { get; set; }
        public string size { get; set; } = "";
        public double price { get; set; }
        public int roomStatus { get; set; }
        public string option { get; set; } = "";
        public string image { get; set; } = "";
        public string description { get; set; } = "";
        public DateTime createdDate { get; set; } = DateTime.UtcNow;
        public DateTime updatedDate { get; set; }
    }
}
