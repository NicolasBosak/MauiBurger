using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBurger.Models
{
    internal class Burger
    {
        public int Id { get; set; }
        public string name { get; set; }
        public bool withCheese { get; set; }
        public double precio { get; set; }
        public List<object> promos { get; set; }
    }
}
