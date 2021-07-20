using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ACCSolution.Entities.Models.Menus
{
    public class subcategory : MenuBase
    {
        public List<SubCategory> SubCategories { get; set; }
    }
}
