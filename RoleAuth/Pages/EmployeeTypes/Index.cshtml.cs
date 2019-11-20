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
    [Authorize(Roles = Who.All)]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<EmployeeType> EmployeeType { get; set; }
        public async Task<IActionResult> OnGet()
        {
            EmployeeType = await _db.EmployeeType.ToListAsync();
            return Page();
        }
    }
}