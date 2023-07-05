using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_app.Models
{
    public class HotelRoomPlanDto : BaseModel
    {
        public int id { get; set; }
        public string noRoom { get; set; }
        public int floor { get; set; }
        public int roomType { get; set; }
        public int numberBed { get; set; }
        public int area { get; set; }
        public string size { get; set; }
        public double price { get; set; }
        public int roomStatus { get; set; }
        public string option { get; set; }
        public string image { get; set; }
        public string description { get; set; }

        // booking
        public int bookingId { get; set; }
        public int customerId { get; set; }
        public int userCreateId { get; set; }
        public DateTime reservationTime { get; set; }
        public DateTime checkinTime { get; set; } 
        public DateTime checkoutTime { get; set; }
        public int status { get; set; }

        // custom
        public string customerName { get; set; }
        public string citizenIdentification { get; set; }
        public string numberPhone { get; set; }
    }
}
