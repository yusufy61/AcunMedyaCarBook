using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery : IRequest<List<GetSocialMediaQueryResult>>
    {
        
    }
}
