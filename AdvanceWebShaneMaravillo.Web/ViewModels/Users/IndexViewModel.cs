using AdvanceWebShaneMaravillo.Web.Infrastructures.Data.Helpers;
using AdvanceWebShaneMaravillo.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebShaneMaravillo.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
