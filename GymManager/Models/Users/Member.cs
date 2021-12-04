using GymManager.Models.Base.Class;
using GymManager.Models.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymManager.Models.Users
{

    public class Member : User, IMember
    {
        public bool IsActiveMember { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime LastsUntil { get; set; }
        public MembershipType MembershipType { get; set; }
        public IList<IProduct> ShoppingCart { get; set; }


    }
}