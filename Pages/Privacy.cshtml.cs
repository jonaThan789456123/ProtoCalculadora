using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

<<<<<<< HEAD
namespace calculador.Pages;
=======
namespace Proyecto1.Pages;
>>>>>>> 3160f5f (Hola dennis)

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

