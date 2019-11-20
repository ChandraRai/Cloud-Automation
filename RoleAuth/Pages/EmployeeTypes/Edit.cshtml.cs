using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoleAuth.Data;
using RoleAuth.Models;
using RoleAuth.Utility;

namespace RoleAuth.Pages.EmployeeTypes
{
    [Authorize(Roles = Who.AdminAndTeamLead)]
    public class EditModel : PageModel
    {
        //private readonly RoleAuth.Data.ApplicationDbContext _context;

        //public EditModel(RoleAuth.Data.ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //[BindProperty]
        //public EmployeeType EmployeeType { get; set; }

        //public async Task<IActionResult> OnGetAsync(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    EmployeeType = await _context.EmployeeType.FirstOrDefaultAsync(m => m.Id == id);

        //    if (EmployeeType == null)
        //    {
        //        return NotFound();
        //    }
        //    return Page();
        //}

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Attach(EmployeeType).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmployeeTypeExists(EmployeeType.Id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return RedirectToPage("./Index");
        //}

        //private bool EmployeeTypeExists(int id)
        //{
        //    return _context.EmployeeType.Any(e => e.Id == id);
        //}

        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public EmployeeType EmployeeType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeType = await _db.EmployeeType.FirstOrDefaultAsync(m => m.Id == id);

            if (EmployeeType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var serviceFromDb = await _db.EmployeeType.FirstOrDefaultAsync(s => s.Id == EmployeeType.Id);
            serviceFromDb.Name = EmployeeType.Name;
            serviceFromDb.PayType = EmployeeType.PayType;
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
