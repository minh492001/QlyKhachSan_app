using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_management_app.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string numberPhone { get; set; }
        public string citizenIdentification { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public int numberBooking { get; set; }
        public int customerType { get; set; }
    }
}
