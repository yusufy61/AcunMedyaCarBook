using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using AcunMedyaCarBook.Application.Features.Mediator.Results.FooterAddressResults;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Domain.Entities;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;
        public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(f => new GetFooterAddressQueryResult
            {
                FooterAddressID = f.FooterAddressID,
                Description = f.Description,
                Address = f.Address,
                Phone = f.Phone,
                Email = f.Email
            }).ToList();
        }
    }
}
