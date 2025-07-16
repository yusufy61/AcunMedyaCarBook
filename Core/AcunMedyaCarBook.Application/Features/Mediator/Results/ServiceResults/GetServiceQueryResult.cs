﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Application.Features.Mediator.Results.ServiceResults
{
    public class GetServiceQueryResult
    {
        public int ServicesID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
