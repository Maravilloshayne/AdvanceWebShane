using AdvanceWebShaneMaravillo.Web.Infrastructures.Data.Helpers;
using AdvanceWebShaneMaravillo.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebShaneMaravillo.Web.ViewModels.Categories
{
    public class IndexViewModel
    {
        public Page<Category> Categories { get; set; }
    }
}
