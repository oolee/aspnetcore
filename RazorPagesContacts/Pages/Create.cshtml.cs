﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesContacts.Data;
using System.Threading.Tasks;

namespace RazorPagesContacts.Pages {
    public class CreateModel : PageModel {
        private readonly AppDbContext _db;
        public CreateModel(AppDbContext db) => _db = db;
        [BindProperty]
        public Customer Customer { get; set; }
        public void OnGet() {

        }
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) return Page();

             _db.Customers.Add(Customer);
            await _db.SaveChangesAsync();
            return Redirect("/Index");
        }
    }
}