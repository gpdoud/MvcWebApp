using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebApp.Models
{
	public class AppDbContext : DbContext
	{
		public DbSet<Customer> Customers {  get; set; }
		public DbSet<Order> Orders { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder) {
			builder.Entity<Customer>(e =>
			{
				e.HasIndex(x => x.Code).IsUnique();
			});
		}
	}
}
