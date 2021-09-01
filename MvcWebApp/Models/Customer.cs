
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebApp.Models
{
	[Table("Customers")]
	public class Customer
	{
		public int Id { get; set; }
		[Required]
		[StringLength(30)]
		public string Code { get; set; }
		[Required]
		[StringLength(30)]
		public string Name { get; set; }
	}
}
