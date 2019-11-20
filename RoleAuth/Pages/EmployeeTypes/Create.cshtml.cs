using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoleAuth.Data;
using RoleAuth.Models;
using RoleAuth.Utility;

namespace RoleAuth.Pages.EmployeeTypes
{
    [Authorize(Roles = Who.AdminAndTeamLead)]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public EmployeeType EmployeeType{ get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.EmployeeType.Add(EmployeeType);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}