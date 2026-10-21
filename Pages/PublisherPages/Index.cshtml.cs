using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vasilca_Robert_Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Vasilca_Robert_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Vasilca_Robert_Lab2Context _context;

    public IndexModel(Vasilca_Robert_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
