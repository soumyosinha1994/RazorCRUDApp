using BulkyAppRazor.Data;
using BulkyAppRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyAppRazor.Pages.Employees
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext? _context;
        public Employee? EmployeesList { get; set; }
        public DeleteModel(ApplicationDbContext? context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            if (id != null && id != 0)
            {
                EmployeesList = _context?.Employees.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            Employee? obj = _context?.Employees.Find(EmployeesList?.Id);
            if (obj == null)
            {
                return NotFound();
            }
            _context?.Employees.Remove(obj);
            _context?.SaveChanges();
            TempData["delete"] = "Employee deleted successfully";
            return RedirectToPage("Employees");
        }
    }
}
