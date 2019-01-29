using AdvanceWebShaneMaravillo.Web.Infrastructures.Data.Helpers;
using AdvanceWebShaneMaravillo.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebShaneMaravillo.Web.ViewModels.Products
{
    public class IndexViewModel
    {
        public Page<Product> Products { get; set; }
    }
}
