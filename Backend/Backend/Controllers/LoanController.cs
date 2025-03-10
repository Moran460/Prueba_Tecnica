using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Obtener todos los préstamos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loan>>> GetLoans()
        {
            return await _context.Loans.ToListAsync();
        }

        // Crear un nuevo préstamo
        [HttpPost]
        public async Task<ActionResult<Loan>> CreateLoan([FromBody] Loan loan)
        {
            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLoans), new { id = loan.Id }, loan);
        }
    }
}
