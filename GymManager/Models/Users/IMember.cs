using GymManager.Models.Base.Class;
using GymManager.Models.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Models.Users
{
        public interface IMember : IUser
        {
            bool IsActiveMember { get; set; }
            DateTime DateJoined { get; set; }
            DateTime LastsUntil { get; set; }
            MembershipType MembershipType { get; set; }
            IList<IProduct> ShoppingCart { get; set; }
        }
}
