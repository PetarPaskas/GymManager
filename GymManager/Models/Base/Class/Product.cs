using GymManager.Models.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymManager.Models.Base.Class
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsOnDiscount { get; set; }
        public string Description { get; set; }
    }
}