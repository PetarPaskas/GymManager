using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymManager.ViewModels
{
    public class IndexShopViewModel
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsOnDiscount { get; set; }
    }
}