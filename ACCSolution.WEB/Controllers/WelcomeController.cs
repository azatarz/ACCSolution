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

        //[HttpGet("{id}")] 
        public async Task<ActionResult> Subcategory(int id)
		{
            CustomWebClient client = new CustomWebClient();
            var response = await client.GetAsync($"https://localhost:44321/api/SubCategories/{id}");
            try
            {
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                if (responseString != string.Empty)
                {
                    var output = JsonConvert.DeserializeObject<List<SubCategory>>(responseString);

                    if (output != null || output.Count != 0)
                    {
                        return View(output);
                    }

                }
                return View(new List<SubCategory>() { });
            }
            catch (Exception ex)
            {
                return View("Error");
            }

        }
    }
}
