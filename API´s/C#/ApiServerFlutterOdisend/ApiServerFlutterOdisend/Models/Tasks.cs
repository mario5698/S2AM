using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServerFlutterOdisend.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Direction_Delivery { get; set; }
        public string Direction_Pickup { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
        public int RiderID { get; set; }
        public bool Asigned { get; set; }
        public string State { get; set; }
    }
}
