using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Models.Base.Interface
{
    public interface IBenefit
    {
         int Id { get; set; }
         string BenefitDescription { get; set; }
    }
}
