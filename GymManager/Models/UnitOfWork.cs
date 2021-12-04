using GymManager.Models.Base.Class;
using GymManager.Models.Base.Interface;
using GymManager.Models.Products;
using GymManager.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymManager.Models
{
    public class UnitOfWork
    {
        public static IList<IMember> Members;

        public static IList<IProduct> Products;

        public static IList<MembershipType> MembershipTypes;

        public static IList<IBenefit> Benefits;
    }

    public static class PopulateUnitOfWork
    {
        public static IList<IMember> GetAllMembers()
        {
            return new List<IMember>
            {
                new Member()
                { 
                            Id = 1,
                            Age=18,
                            DateJoined=new DateTime(2021,12,1),
                            IsActiveMember = true,
                            IsLogged = false,
                            LastsUntil = new DateTime(2022,1,1),
                            Name = "John Smith",
                            ShoppingCart = new List<IProduct>(),
                            MembershipType =  new MembershipType{ Id=1,Name="Basic Membership",Discount=1,PricePerMonth=2000,Benefits=null}
                },
                new Member()
                {
                            Id=2,
                            Age=23,
                            DateJoined=new DateTime(2021,12,1),
                            IsActiveMember = true,
                            IsLogged = false,
                            LastsUntil = new DateTime(2022,1,1),
                            Name = "Johnny Bravo",
                            ShoppingCart = new List<IProduct>(),
                            MembershipType = new MembershipType{ Id=4,Name="Platinum Membership",Discount=0.7,PricePerMonth=4000,Benefits=GetPlatinumBenefits()}
                },
                new Member()
                {
                            Id=3,
                            Age=27,
                            DateJoined=new DateTime(2021,10,17),
                            IsActiveMember = false,
                            IsLogged = false,
                            LastsUntil = new DateTime(2021,11,17),
                            Name = "Nicolas Cage",
                            ShoppingCart = new List<IProduct>(),
                            MembershipType = new MembershipType{ Id=3,Name="Gold Membership",Discount=0.8,PricePerMonth=3200,Benefits=GetGoldBenefits()}
                }
            };
        }

        public static IList<MembershipType> GetAllMembershipTypes()
        {
            return new List<MembershipType>() 
            { 
                new MembershipType{ Id=1,Name="Basic Membership",Discount=1,PricePerMonth=2000,Benefits=null},
                new MembershipType{ Id=2,Name="Silver Membership",Discount=0.9,PricePerMonth=2500,Benefits=GetSilverBenefits()},
                new MembershipType{ Id=3,Name="Gold Membership",Discount=0.8,PricePerMonth=3200,Benefits=GetGoldBenefits()},
                new MembershipType{ Id=4,Name="Platinum Membership",Discount=0.7,PricePerMonth=4000,Benefits=GetPlatinumBenefits()}
            };
        }

        public static IList<IBenefit> GetSilverBenefits()
        {
            return new List<IBenefit>()
            {
                new Benefit(){Id=1,BenefitDescription="Free Shower in the gym"},
                new Benefit(){Id=2, BenefitDescription="10% discount on all products"}
            };
        }

        public static IList<IBenefit> GetGoldBenefits()
        {
            return new List<IBenefit>()
            {
                new Benefit(){Id=1,BenefitDescription="Free Shower in the gym"},
                new Benefit(){Id=3, BenefitDescription="20% discount on all products"},
                new Benefit(){Id=4, BenefitDescription="Sauna 2 times a week"}
            };
        }

        public static IList<IBenefit> GetPlatinumBenefits()
        {
            return new List<IBenefit>()
            {
                new Benefit(){Id=1,BenefitDescription="Free Shower in the gym"},
                new Benefit(){Id=5, BenefitDescription="30% discount on all products"},
                new Benefit(){Id=6, BenefitDescription="Sauna 4 times a week"}, 
                new Benefit(){Id=7, BenefitDescription="Free massage once a month"}
            };
        }

        public static IList<IProduct> GetAllProducts()
        {
            return new List<IProduct>()
            {
                new CandyBar()
                {
                    Id=1,
                    Description="Protein filled candy bar with peanuts, 20g of protein",
                    IsOnDiscount=false,
                    Name="ProteinBarzzz",
                    Price=150
                },
                    
                new CandyBar()
                {
                    Id=2,
                    Description="Protein filled candy bar with flax seed, 20g of protein",
                    IsOnDiscount=false,
                    Name="ProteinBarzzz",
                    Price=150
                },
                new ProteinPowder()
                {
                    Id=3,
                    Description="Vanilla protein powder, 35g per scoop",
                    IsOnDiscount=false,
                    Name="MyProtein",
                    Price=150
                },
                new ProteinPowder()
                {
                    Id=3,
                    Description="Vanilla protein powder, 35g per scoop",
                    IsOnDiscount=false,
                    Name="MyProtein",
                    Price=150
                }
            };
        }

        public  static void PopulateUOWBenefits()
        {
            var goldBenefits = GetGoldBenefits();
            var platinumBenefits = GetPlatinumBenefits();
            var silverBenefits = GetSilverBenefits();

            UnitOfWork.Benefits = new List<IBenefit>();

            foreach (var benefit in silverBenefits)
                UnitOfWork.Benefits.Add(benefit);

            foreach (var benefit in goldBenefits)
                UnitOfWork.Benefits.Add(benefit);

            foreach (var benefit in platinumBenefits)
                UnitOfWork.Benefits.Add(benefit);
        }

    }

                
}