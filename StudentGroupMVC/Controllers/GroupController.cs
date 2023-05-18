using Microsoft.AspNetCore.Mvc;
using StudentGroupMVC.Models;
using System.Collections.Generic;

namespace StudentGroupMVC.Controllers
{
	public class GroupController : Controller
	{
		public static List<Group> GetAllGroups()
		{
			Group group1 = new Group()
			{
				Id=1,
				Name="AB101"
			};
			Group group2 = new Group()
			{
				Id = 2,
				Name = "AB102"
			};

			Group group3 = new Group()
			{
				Id = 3,
				Name = "AC101"
			}; 
			Group group4= new Group()
			{
				Id = 4,
				Name = "AC102"
			};
			Group group5 = new Group()
			{
				Id = 5,
				Name = "AD101"
			};
			Group group6 = new Group()
			{
				Id = 6,
				Name = "AD102"
			};
			Group group7= new Group()
			{
				Id = 7,
				Name = "AE101"
			};
			Group group8 = new Group()
			{
				Id = 8,
				Name = "AE102"
			};

			List<Group> groupList = new List<Group>();
			groupList.Add(group1);
			groupList.Add(group2);
			groupList.Add(group3);
			groupList.Add(group4);
			groupList.Add(group5);
			groupList.Add(group6);
			groupList.Add(group7);
			return groupList;
		}

		public IActionResult Index()
		{
			List<Group> grouplist = new List<Group>();
			grouplist = GetAllGroups();
			return View(grouplist);
		}
		public IActionResult Detail(int Id)
		{
			List<Group> grouplist = new List<Group>();
			grouplist = GetAllGroups();
			return View(grouplist.FindAll(g=>g.Id==Id) );
		}

	}
}
