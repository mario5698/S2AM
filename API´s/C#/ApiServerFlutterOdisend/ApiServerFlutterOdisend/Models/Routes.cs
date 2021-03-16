using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServerFlutterOdisend.Models
{
    public class Routes
    {
        public int Id { get; set; }
        public string CodeRoute { get; set; }
        public string DescRoute { get; set; }
        public int idPlanetOr { get; set; }
        public int iPlanetDest { get; set; }
        public int idRouteType { get; set; }
    }
}
