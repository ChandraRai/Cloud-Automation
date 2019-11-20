using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RoleAuth.Data;
using RoleAuth.Models;
using RoleAuth.Utility;

namespace RoleAuth.Pages.EmployeeTypes
{

    [Authorize(Roles = Who.Admin)]
    public class DeleteModel : PageModel
    {
        private readonly RoleAuth.Data.ApplicationDbContext _context;

        public DeleteModel(RoleAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EmployeeType EmployeeType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeType = await _context.EmployeeType.FirstOrDefaultAsync(m => m.Id == id);

            if (EmployeeType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeType = await _context.EmployeeType.FindAsync(id);

            if (EmployeeType != null)
            {
                _context.EmployeeType.Remove(EmployeeType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
