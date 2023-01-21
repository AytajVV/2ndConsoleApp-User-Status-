using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Status:IEntity
    {
        
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        
        public User User { get; set; }
        public int Id { get; set; }
        

        public Status(string title, string content)
        {
            Date = DateTime.Now;
           
          
        }
        

    }
}
