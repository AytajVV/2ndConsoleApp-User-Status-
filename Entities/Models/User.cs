using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User:IEntity
    {
       
        public string Username { get; set; }
        public List<Status> Statuses { get; set; }
        public int Id { get; set; }
        

        public User(string username)
        {
           
        }
       


    }
}
