using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace hotel_management_app.Models
{
    public class UserModel : BaseModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string citizenIdentification { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string address { get; set; }
        public string numberPhone { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }
}
