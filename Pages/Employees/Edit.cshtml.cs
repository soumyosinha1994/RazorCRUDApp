using BulkyAppRazor.Data;
using BulkyAppRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyAppRazor.Pages.Employees
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext? _context;
        public Employee? EmployeesList { get; set; }
        public EditModel(ApplicationDbContext? context)
        {
            _context = context;
        }
        public void OnGet(int? id)
        {
            if(id!=null && id != 0)
            {
                EmployeesList=_context?.Employees.Find(id);
            }
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid) {
                _context?.Employees.Update(EmployeesList);
                _context?.SaveChanges();
                TempData["success"] = "Employee Updated successfully";
                return RedirectToPage("Employees");
            }
            
            return Page();
        }
    }
}
