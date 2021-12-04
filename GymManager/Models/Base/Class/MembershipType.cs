using GymManager.Models.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Models.Base.Class
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
        public double PricePerMonth { get; set; }
        public IEnumerable<IBenefit> Benefits { get; set; }
    }
}
