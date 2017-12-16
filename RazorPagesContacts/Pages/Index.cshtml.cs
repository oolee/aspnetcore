using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesContacts.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesContacts.Pages {
    public class IndexModel : PageModel {
        private readonly AppDbContext _db;
        public IndexModel(AppDbContext db) => _db = db;
        public List<Customer> Customers { get; private set; }
        public async Task OnGetAsync() {
            Customers = await _db.Customers.AsNoTracking().ToListAsync();
        }
        public async Task<IActionResult>OnPostDeleteAsync(int id) {
            var customer = await _db.Customers.FindAsync(id);

            if (customer != null) {
                _db.Customers.Remove(customer);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
