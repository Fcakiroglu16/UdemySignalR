using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemySignalR.API.Models
{
    public class Team
    {
        public Team()
        {
            Users = new List<User>();
        }

        public int Id { get; set; }
        public String Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}