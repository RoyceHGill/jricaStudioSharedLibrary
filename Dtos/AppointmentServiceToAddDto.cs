﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JricaStudioSharedLibrary.Dtos
{
    public class AppointmentServiceToAddDto
    {

        public Guid AppointmentId { get; set; }
        public Guid ServiceId { get; set; }
    }
}
