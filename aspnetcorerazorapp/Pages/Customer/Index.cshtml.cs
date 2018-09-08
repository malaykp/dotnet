using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcorerazorapp.Pages.Customer{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using aspnetcorerazorapp.Data;
    using Microsoft.EntityFrameworkCore;

    public class IndexModel : PageModel{
        private readonly AppDbContext _db;
        public  IList<Customer> Customers {
            get;
            private set;
        }
        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public async Task OnGetAsync(){
            Customers = await _db.Customers.AsNoTracking().ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id){
            var customer  = await _db.Customers.FindAsync(id);
            if(customer != null){
                _db.Customers.Remove(customer);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
        
    }
}
