﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.Mediator.Queries.FeatureQueries;
using AcunMedyaCarBook.Application.Features.Mediator.Results.FeatureResults;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Domain.Entities;
using MediatR;

namespace AcunMedyaCarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                FeatureID = value.FeatureID,
                Name = value.Name
            };
        }
    }
}
