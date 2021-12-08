using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Models.Base.Interface
{
    public interface IUser
    {
         int Id { get; set; }
         string Name { get; set; }
         int Age { get; set; }
         bool IsLogged { get; set; }
    }
}
