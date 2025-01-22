﻿using JricaStudioSharedLibrary.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JricaStudioSharedLibrary.Dtos.Admin
{
    public class AdminAppointmentSearchFilterDto
    {
        public string? SearchString { get; set; }
        public AppointmentStatus? Status { get; set; }

    }
}
