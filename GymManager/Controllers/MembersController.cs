using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymManager.Models;
using GymManager.Models.Users;
using GymManager.ViewModels;
using GymManager.Models.Base.Class;

namespace GymManager.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members

        public ActionResult Index()
        {
            var viewModel = new IndexMoviesViewModel() 
            { 
                Members = UnitOfWork.Members
            };

            return View("MembersIndex", viewModel);
        }

        [Route("members/form/{id?}")]
        public ActionResult Form(int? id)
        {
            var viewModel = new FormMemberViewModel();
            viewModel.MembershipTypes = UnitOfWork.MembershipTypes;

            if (id.HasValue)
            {
                viewModel.FormTitle = "Edit Member";
                try
                {
                    var member = (Member)UnitOfWork.Members.Single(m => m.Id == id.Value);
                    viewModel.Member = member;
                }
                catch(Exception ex)
                {
                    return HttpNotFound(ex.Message);
                }
                return View("MemberForm", viewModel);
            }
            else
            {
                viewModel.Member = new Member()
                {
                    MembershipType = new MembershipType(),
                    DateJoined = DateTime.Now,
                    LastsUntil = DateTime.Now.AddDays(30)
                };

                viewModel.FormTitle = "New Member";
                return View("MemberForm", viewModel );
            }
        }

        public ActionResult ResolveForm(FormMemberViewModel vm)
        {
            Member newMember = null;
            if(vm.Member.Id == 0)
            {
                newMember = new Member();
                newMember.Id = new Random().Next(20,999999);
                newMember.IsActiveMember = vm.Member.IsActiveMember;
                newMember.Name = vm.Member.Name;
                newMember.Age = vm.Member.Age;
                newMember.IsLogged = false;
                newMember.IsActiveMember = vm.Member.IsActiveMember;
                newMember.DateJoined = DateTime.Now;
                newMember.LastsUntil = vm.Member.LastsUntil;
                newMember.MembershipType = UnitOfWork.MembershipTypes.SingleOrDefault(mt => mt.Id == vm.MembershipTypeId);
                UnitOfWork.Members.Add(newMember);
            }
            else
            {
                newMember = (Member)UnitOfWork.Members.SingleOrDefault(m => m.Id == vm.Member.Id);
                newMember.IsActiveMember = vm.Member.IsActiveMember;
                newMember.Name = vm.Member.Name;
                newMember.Age = vm.Member.Age;
                newMember.IsLogged = false;
                newMember.IsActiveMember = vm.Member.IsActiveMember;
                newMember.DateJoined = DateTime.Now;
                newMember.LastsUntil = vm.Member.LastsUntil;
                newMember.MembershipType = UnitOfWork.MembershipTypes.SingleOrDefault(mt => mt.Id == vm.MembershipTypeId);
            }


            return RedirectToAction("Index");
        }

        [Route("members/membershipTypes")]
        public ActionResult MembershipTypeIndex()
        {
            return View("MembershipTypeIndex", UnitOfWork.MembershipTypes);
        }

        [Route("members/membershipTypeForm/{id}")]
        public  ActionResult FormMembershipType(int id)
        {
            var memType = UnitOfWork.MembershipTypes.Single(mt => mt.Id == id);
            return View("FormMembershipType", memType);
        }

        public ActionResult ResolveMembershipType(MembershipType mt)
        {
            var selectedMT = UnitOfWork.MembershipTypes.SingleOrDefault(mtt => mtt.Id == mt.Id);
            selectedMT.Discount = mt.Discount;
            selectedMT.PricePerMonth = mt.PricePerMonth / 100;
            selectedMT.Name = mt.Name; 

            return RedirectToAction("MembershipTypeIndex");
        }
    }
}