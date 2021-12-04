using GymManager.Models.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Models.Base.Class
{
    public class Benefit : IBenefit
    {
        public int Id { get; set; }
        public string BenefitDescription { get; set; }
    }
}
