using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.CQRS.Results.BrandResults;
using AcunMedyaCarBook.Application.Features.CQRS.Results.CarResults;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Domain.Entities;

namespace AcunMedyaCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(b => new GetCarQueryResult
            {
                BrandID = b.BrandID,
                BigImageUrl = b.BigImageUrl,
                CarID = b.CarID,
                CoverImageUrl = b.CoverImageUrl,
                Fuel = b.Fuel,
                Km = b.Km,
                Luggage = b.Luggage,
                Model = b.Model,
                Seat = b.Seat,
                Transmission = b.Transmission
            }).ToList();
        }
    }
}
