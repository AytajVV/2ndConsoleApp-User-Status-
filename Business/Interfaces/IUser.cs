using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUser
    {
        User Create(User user);
        User ShareStatus(Status status);
        User Delete(int? id);
        User Update(int? id, User user);
        User GetStatusById(int? id);
        List<User> GetAllStatuses();
        User FilterStatusByDate(int? id, DateTime date);
        
    }
}
