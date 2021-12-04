using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Models.Base.Interface
{
    public interface IProduct
    {
         int Id { get; set; }
         string Name { get; set; }
         double Price { get; set; }
         bool IsOnDiscount { get; set; }
         string Description { get; set; }
    }
}
