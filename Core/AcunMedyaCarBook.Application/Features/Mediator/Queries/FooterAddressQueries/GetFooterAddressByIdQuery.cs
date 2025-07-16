using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
    {
        public int Id { get; set; }
        public GetFooterAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}
