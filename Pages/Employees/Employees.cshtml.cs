using BulkyAppRazor.Data;
using BulkyAppRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyAppRazor.Pages.Employees
{
    public class EmployeesModel : PageModel
    {
        private readonly ApplicationDbContext _context;
       public List<Employee> employees { get; set; }

        public EmployeesModel(ApplicationDbContext? context)
        {
            _context = context;     
        }
        public void OnGet()
        {
            employees=_context.Employees.ToList();
        }
    }
}
