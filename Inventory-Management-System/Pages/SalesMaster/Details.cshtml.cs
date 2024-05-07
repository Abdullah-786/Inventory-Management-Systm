using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Inventory_Management_System.DataBase;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Pages.SalesMaster
{
    public class DetailsModel : PageModel
    {
        private readonly Inventory_Management_System.DataBase.ImsDbContext _context;

        public DetailsModel(Inventory_Management_System.DataBase.ImsDbContext context)
        {
            _context = context;
        }

        public Sales Sales { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sales = await _context.Sales.FirstOrDefaultAsync(m => m.ID == id);
            if (sales == null)
            {
                return NotFound();
            }
            else
            {
                Sales = sales;
            }
            return Page();
        }
    }
}
