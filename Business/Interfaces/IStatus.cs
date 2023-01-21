using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IStatus
    {
        Status Create(Status status);
        Status Delete(int id);
        Status Update(int id, Status status);
        Status GetStatusInfo(int? id);

    }
}
