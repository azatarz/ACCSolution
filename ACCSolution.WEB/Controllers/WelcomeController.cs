using ACCSolution.Entities.Models.Menus;
using ACCSolution.Libraries;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ACCSolution.WEB.Controllers
{
    public class WelcomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            CustomWebClient client = new CustomWebClient();
            var response = await client.GetAsync("https://localhost:44321/api/categories");
            try
            {
                response.EnsureSuccessStatusCode();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    var output = JsonConvert.DeserializeObject<List<Category>>(responseString);
                    return View(output);
                }
                else
                {
                    return View(new List<Category>() { });
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
            
        }
    }
}
