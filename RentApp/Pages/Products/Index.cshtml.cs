using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RentApp.Data;
using RentApp.Data.Identity;

namespace RentApp.Pages.Products
{
    [Authorize(Roles = "admin")]
    public class IndexModel : PageModel
    {
        private readonly RentApp.Data.ApplicationDbContext _context;

        public IndexModel(RentApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
