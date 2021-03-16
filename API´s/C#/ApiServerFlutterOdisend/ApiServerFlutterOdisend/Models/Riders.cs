using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiServerFlutterOdisend.Models
{
    public class Riders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Vehicle { get; set; }
        public string Token { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
