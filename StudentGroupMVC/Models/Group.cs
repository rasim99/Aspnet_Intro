using System.Collections.Generic;

namespace StudentGroupMVC.Models
{
	public class Group
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Student>students{get; set;}
	}
}
