using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JricaStudioSharedLibrary.Dtos.Admin
{
    public class ProductFilterDto
    {
        public Guid ProductCategoryId { get; set; }
        public string SearchString { get; set; } = "";
    }
}
