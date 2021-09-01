using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebApp.Models
{
	public class Order
	{
		public int Id { get; set; }
		[Required]
		[StringLength(80)]
		public string Description { get; set; }
		[Column(TypeName = "decimal(11,2)")]
		[Range(0, double.MaxValue, ErrorMessage = "Total must be non-negative.")]
		public decimal Total { get; set; }

		public int CustomerId { get; set; }
		public virtual Customer Customer {  get; set; }
	}
}
