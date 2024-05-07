﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Inventory_Management_System.DataBase.ImsDbContext _context;

        public IndexModel(Inventory_Management_System.DataBase.ImsDbContext context)
        {
            _context = context;
        }

        public IList<Sales> Sale { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Sale = await _context.Sales.ToListAsync();
        }
    }
}
