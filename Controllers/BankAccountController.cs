using Microsoft.AspNetCore.Mvc;
using BankAccountManagement.Data;
using BankAccountManagement.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BankAccountManagement.Controllers
{
    public class BankAccountController : Controller
    {
        private readonly BankAccountContext _context;

        public BankAccountController(BankAccountContext context)
        {
            _context = context;
        }

        // Acción para mostrar el formulario de creación de cuenta
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Acción para crear una nueva cuenta bancaria
        [HttpPost]
        public async Task<IActionResult> Create(BankAccount account)
        {
            if (ModelState.IsValid)
            {
                _context.BankAccounts.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(account);
        }

        // Acción para listar todas las cuentas bancarias
        public async Task<IActionResult> Index()
        {
            var accounts = await _context.BankAccounts.ToListAsync();
            return View(accounts);
        }
    }
}
