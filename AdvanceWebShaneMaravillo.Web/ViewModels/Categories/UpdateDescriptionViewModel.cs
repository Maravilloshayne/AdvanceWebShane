using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebShaneMaravillo.Web.ViewModels.Categories
{
    public class UpdateDescriptionViewModel
    {
        public Guid? ParentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
