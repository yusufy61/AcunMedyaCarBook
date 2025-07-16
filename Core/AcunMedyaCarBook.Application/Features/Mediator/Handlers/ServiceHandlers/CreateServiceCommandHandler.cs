using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Commands.ServiceCommands;
using AcunMedyaCarBook.Application.Interfaces;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<AcunMedyaCarBook.Domain.Entities.Services> _repository;

        public CreateServiceCommandHandler(IRepository<Domain.Entities.Services> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.Services
            {
                Description = request.Description,
                Title = request.Title,
                IconUrl = request.IconUrl
            });
        }
    }
}
