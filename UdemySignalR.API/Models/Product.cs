using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemySignalR.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }

        public double Price { get; set; }
    }
}