using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace calculador.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Num1 { get; set; }

    [BindProperty]
    public int Num2 { get; set; }

    [BindProperty]
    public string Operacion { get; set; }

    public string Resultado { get; set; }

    public void OnPost()
    {
        switch (Operacion)
        {
            case "sumar":
                Resultado = (Num1 + Num2).ToString();
                break;
            case "restar":
                Resultado = (Num1 - Num2).ToString();
                break;
            case "multiplicar":
                Resultado = (Num1 * Num2).ToString();
                break;
            case "dividir":                Resultado =  Num2 != 0 ? (Num1 / Num2).ToString() : "Error: división por 0";
                break;
            default:
                Resultado = "Operación no válida";
                break;        }
    }
// xd
    public void OnGet()
    {
    }
}}