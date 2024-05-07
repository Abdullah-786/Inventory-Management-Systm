using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inventory_Management_System.DataBase;
using Inventory_Management_System.Models;

namespace Inventory_Management_System.Pages.SalesMaster
{
    public class EditModel : PageModel
    {
        private readonly Inventory_Management_System.DataBase.ImsDbContext _context;

        public EditModel(Inventory_Management_System.DataBase.ImsDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sales Sales { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sales =  await _context.Sales.FirstOrDefaultAsync(m => m.ID == id);
            if (sales == null)
            {
                return NotFound();
            }
            Sales = sales;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sales).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesExists(Sales.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SalesExists(int id)
        {
            return _context.Sales.Any(e => e.ID == id);
        }
    }
}
