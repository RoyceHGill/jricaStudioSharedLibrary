﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JricaStudioSharedLibrary.Dtos
{
    public class AppointmentAvailableDto
    {
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
