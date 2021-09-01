using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MvcWebApp.Models;

namespace MvcWebApp.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly MvcWebApp.Models.AppDbContext _context;

        public IndexModel(MvcWebApp.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customers { get;set; }

        public async Task OnGetAsync()
        {
            Customers = await _context.Customers.ToListAsync();
        }
    }
}
