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
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public IdentityUser IdentityUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id.Trim().Length == 0)
            {
                return NotFound();
            }

            IdentityUser = await _db.IdentityUser.FirstOrDefaultAsync(m => m.Id == id);

            if (IdentityUser == null)
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
            else
            {
                var userInDb = await _db.IdentityUser.SingleOrDefaultAsync(u => u.Id == IdentityUser.Id);
                if (userInDb == null)
                {
                    return NotFound();
                }
                else
                {
                    userInDb.Email = IdentityUser.Email;                    

                    await _db.SaveChangesAsync();
                    return RedirectToPage("Index");
                }
            }
        }
    }
}