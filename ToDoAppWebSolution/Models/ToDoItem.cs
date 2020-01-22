using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAppWebSolution.Models
{
	public class ToDoItem
	{
		[Required]
		public string Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Notes { get; set; }

		public bool Done { get; set; }
	}
}
