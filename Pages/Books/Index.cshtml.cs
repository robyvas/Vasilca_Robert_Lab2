using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vasilca_Robert_Lab2.Models;

namespace Vasilca_Robert_Lab2.Pages.BookPages;

public class IndexModel : PageModel
{
    private readonly Vasilca_Robert_Lab2Context _context;

    public IndexModel(Vasilca_Robert_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    [BindProperty(SupportsGet = true)]
    public int? AuthorID { get; set; }

    public async Task OnGetAsync()
    {
        ViewData["AuthorID"] = new SelectList(_context.Author, "ID", "FullName", AuthorID);

        var books = _context.Book
            .Include(b => b.Publisher)
            .Include(b => b.Author)
            .AsQueryable();

        if (AuthorID != null)
        {
            books = books.Where(b => b.AuthorID == AuthorID);
        }

        Book = await books.ToListAsync();
    }
}
