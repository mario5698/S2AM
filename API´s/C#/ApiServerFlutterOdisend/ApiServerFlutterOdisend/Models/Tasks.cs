using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServerFlutterOdisend.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string DirectionDelivery { get; set; }
        public string DirectionPickup { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
        public int RiderID { get; set; }
        public string TokenPickup { get; set; }
        public string TokenDelivery { get; set; }
        public string LngPickup { get; set; }
        public string LatPickup { get; set; }
        public string LngDelivery { get; set; }
        public string LatDelivery { get; set; }
        public double KM { get; set; }
        public double KG { get; set; }
        public string State { get; set; }
        
    }
}
