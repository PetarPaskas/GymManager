using GymManager.Models.Base.Class;
using GymManager.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GymManager.ViewModels
{
    public class FormMemberViewModel
    {
        public Member Member { get; set; }
        public IList<MembershipType> MembershipTypes { get; set; }
        public string FormTitle { get; set; }

        public int MembershipTypeId { get; set; }
    }
}