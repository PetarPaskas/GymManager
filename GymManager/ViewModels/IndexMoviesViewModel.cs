using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GymManager.Models.Users;

namespace GymManager.ViewModels
{
    public class IndexMoviesViewModel
    {
        public IList<IMember> Members { get; set; }
    }
}