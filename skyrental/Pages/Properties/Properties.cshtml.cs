using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;


namespace skyrental.Pages.Properties
{
    public class PropertiesModel : PageModel
    {
        public List<Models.Properties>? PropertiesList { get; set; }
        public void OnGet()
        {
            var propertiesList = System.IO.File.ReadAllText("wwwroot/sampledatas/Properties.json");

            PropertiesList = JsonSerializer.Deserialize <List<Models.Properties>>(propertiesList);
        }
    }
}

