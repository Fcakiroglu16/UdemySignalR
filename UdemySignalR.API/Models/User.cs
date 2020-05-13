using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemySignalR.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Team Team { get; set; }
    }
}