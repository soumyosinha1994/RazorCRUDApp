using BulkyAppRazor.Data;
using BulkyAppRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyAppRazor.Pages.Employees
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext? _context;
        public Employee? EmployeesList { get; set; }
        public CreateModel(ApplicationDbContext? context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _context?.Employees.Add(EmployeesList);
            _context?.SaveChanges();
            TempData["success"] = "Employee created successfully";
            return RedirectToPage("Employees");
        }
    }
}
