using StudentGroupMVC.Models;
using System.Collections.Generic;

namespace StudentGroupMVC.ViewModels
{
	public class GroupStudentsVM
	{
		public List<Student> students { get; set; }
		public List<Group> groups { get; set; }
		
	}
}
