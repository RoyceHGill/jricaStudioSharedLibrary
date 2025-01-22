using JricaStudioSharedLibrary.Dtos.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JricaStudioSharedLibrary.Dtos.Admin
{
    public class AdminUserDetailsDto : AdminUserDto
    {
        public IEnumerable<AdminAppointmentDto> Appointments { get; set; }
        public DateTime Created { get; set; }
    }
}
