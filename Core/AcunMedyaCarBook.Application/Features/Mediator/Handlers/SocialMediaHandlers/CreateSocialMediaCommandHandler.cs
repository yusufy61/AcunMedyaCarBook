using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Domain.Entities;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
                Name = request.Name,
                Url = request.Url,
                Icon = request.Icon
            });
        }
    }
}
