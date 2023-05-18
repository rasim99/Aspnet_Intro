using Microsoft.AspNetCore.Mvc;
using StudentGroupMVC.Models;
using StudentGroupMVC.ViewModels;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StudentGroupMVC.Controllers
{
	public class StudentController : Controller
	{
		public static List<Student> GetAllStudents()
		{
			Student stu1 = new Student()
			{
				Id = 1,
				Name = "Sabir",
				GroupId=1
			};
			Student stu2 = new Student()
			{
				Id = 2,
				Name = "Asif",
				GroupId = 1
			};

			Student stu3 = new Student()
			{
				Id = 3,
				Name = "Racif",
				GroupId = 2
			};
			Student stu4 = new Student()
			{
				Id = 4,
				Name = "Rafiq",
				GroupId = 2
			};
			Student stu5 = new Student()
			{
				Id = 5,
				Name = "Helena",
				GroupId = 3
			};
			Student stu6 = new Student()
			{
				Id = 6,
				Name = "Selena",
				GroupId = 3
			};
			Student stu7 = new Student()
			{
				Id = 7,
				Name = "Aksin",
				GroupId = 4
			};
			Student stu8 = new Student()
			{
				Id = 8,
				Name = "Taleh",
				GroupId = 4
			};
			Student stu9 = new Student()
			{
				Id = 9,
				Name = "Carolina",
				GroupId = 5
			};
			Student stu10 = new Student()
			{
				Id = 10,
				Name = "Linda",
				GroupId = 5
			};
			Student stu11 = new Student()
			{
				Id = 11,
				Name = "Mira",
				GroupId = 6
			};
			Student stu12 = new Student()
			{
				Id = 12,
				Name = "Mari",
				GroupId = 6
			};
			Student stu13 = new Student()
			{
				Id = 13,
				Name = "Victor",
				GroupId = 7
			};
			Student stu14 = new Student()
			{
				Id = 14,
				Name = "Khaby",
				GroupId = 7
			};

			List<Student> stuList = new List<Student>();
			stuList.Add(stu1);
			stuList.Add(stu2);
			stuList.Add(stu3);
			stuList.Add(stu4);
			stuList.Add(stu5);
			stuList.Add(stu6);
			stuList.Add(stu7);
			stuList.Add(stu8);
			stuList.Add(stu9);
			stuList.Add(stu10);
			stuList.Add(stu11);
			stuList.Add(stu12);
			stuList.Add(stu13);
			stuList.Add(stu14);
			return stuList;
		}

		
		public IActionResult Index()
		{
			GroupStudentsVM groupStudentsVM = new GroupStudentsVM()
			{
				students = GetAllStudents(),
			
			};
			return View(groupStudentsVM);
		}

		public IActionResult Detail(int id)
		{
			List<Student> students = new List<Student>();
			students = GetAllStudents();
			return View(students.FindAll(s => s.Id == id));
		}
		public IActionResult GetStudentWithGroupId(int id)
		{
			List<Student> students = new List<Student>();
			students = GetAllStudents();
			return View(students.FindAll(s => s.GroupId == id));
		}
	}
}
