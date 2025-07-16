using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Queries.ServiceQueries;
using AcunMedyaCarBook.Application.Features.Mediator.Results.ServiceResults;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Domain.Entities;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        private readonly IRepository<AcunMedyaCarBook.Domain.Entities.Services> _repository;

        public GetServiceQueryHandler(IRepository<Domain.Entities.Services> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(s => new GetServiceQueryResult
            {
                ServicesID = s.ServicesID,
                Title = s.Title,
                Description = s.Description,
                IconUrl = s.IconUrl
            }).ToList();
        }
    }
}
