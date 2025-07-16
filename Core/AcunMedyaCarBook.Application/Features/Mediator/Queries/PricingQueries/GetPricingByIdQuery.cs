using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Results.PricingResults;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public int Id { get; set; }
        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
