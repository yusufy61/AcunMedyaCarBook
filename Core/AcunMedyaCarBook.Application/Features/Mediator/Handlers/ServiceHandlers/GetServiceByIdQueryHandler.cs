using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using AcunMedyaCarBook.Application.Features.Mediator.Results.ServiceResults;
using AcunMedyaCarBook.Application.Interfaces;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<AcunMedyaCarBook.Domain.Entities.Services> _repository;

        public GetServiceByIdQueryHandler(IRepository<Domain.Entities.Services> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                ServicesID = value.ServicesID,
                Description = value.Description,
                Title = value.Title,
                IconUrl = value.IconUrl
            };
        }
    }
}
