﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaCarBook.Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
        public RemoveAboutCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
