using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RoleAuth.Data;
using RoleAuth.Utility;

namespace RoleAuth.Pages.Users
{
    [Authorize(Roles = Who.AdminAndTeamLead)]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public List<IdentityUser> IdentityUserList { get; set; }


        public async Task<IActionResult> OnGet()
        {
            IdentityUserList = await _db.IdentityUser.ToListAsync();

            return Page();
        }
    }
}