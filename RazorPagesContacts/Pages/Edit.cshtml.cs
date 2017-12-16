using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesContacts.Data;
using System.Threading.Tasks;

namespace RazorPagesContacts.Pages {
    public class EditModel : PageModel {
        private readonly AppDbContext _db;
        public EditModel(AppDbContext db) => _db = db;
        [BindProperty]
        public Customer Customer { get; private set; }
        public async Task<IActionResult> OnGet(int id) {
            Customer = await _db.Customers.FindAsync(id);

            if (Customer == null) return RedirectToPage("/Index");

            return Page();
        }
    }
}