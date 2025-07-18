﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class RemoveSocialMediaCommand : IRequest
    {
        public RemoveSocialMediaCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }
}
