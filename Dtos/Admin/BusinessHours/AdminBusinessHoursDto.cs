
using JricaStudioSharedLibrary.Dtos.BusinessHours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JricaStudioSharedLibrary.Dtos.Admin.BusinessHours
{
    public class AdminBusinessHoursDto : BusinessHoursDto, IBusinessHoursDto
    {
        public Guid Id { get; set; }
    }
}
