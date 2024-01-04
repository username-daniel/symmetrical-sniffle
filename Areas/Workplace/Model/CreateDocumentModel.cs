namespace DocGems.Areas.Workplace.Model;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DocGems.Data;
using System.IO;
using System.Threading.Tasks;

public class CreateDocumentModel : PageModel
{
    public CreateDocumentModel(MssqlCtx context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public IFormFile File { get; set; }
    private readonly MssqlCtx _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // Convert the uploaded file to a string
        using var reader = new StreamReader(File.OpenReadStream());
        var fileContent = await reader.ReadToEndAsync();

        // Create a new document
        var document = new Document
        {
            // Fill in the properties of the Document as needed
        };

        // Add the document to the database
        _context.Document.Add(document);
        await _context.SaveChangesAsync();

        // Create a new user document
        var userDocument = new UserDocument
        {
            UserId = _httpContextAccessor.HttpContext.User.Identity.Name,
            DocumentId = document.Id,
            Content = fileContent,
            // Fill in the other properties of the UserDocument as needed
        };

        // Add the user document to the database
        _context.UserDocuments.Add(userDocument);
        await _context.SaveChangesAsync();

        return Redirect("/li");
        //return Redirect .Redirect("/li");
    }
}