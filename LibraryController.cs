using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class LoansController : Controller
{
    private readonly LibraryContext _context;

    public LoansController(LibraryContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var loans = _context.Loans
            .Include(l => l.User)
            .Include(l => l.Book);

        return View(await loans.ToListAsync());
    }
}
