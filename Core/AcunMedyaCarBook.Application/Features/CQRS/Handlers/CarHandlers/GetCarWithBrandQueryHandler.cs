using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.CQRS.Results.CarResults;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Application.Interfaces.CarInterfaces;
using AcunMedyaCarBook.Domain.Entities;

namespace AcunMedyaCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarWithBrandQueryResult>> Handle()
        {
            var values = await _repository.GerCarsListWithBrands();
            return values.Select(c => new GetCarWithBrandQueryResult
            {
                BrandName = c.Brand.Name,
                BrandID = c.BrandID,
                BigImageUrl = c.BigImageUrl,
                CarID = c.CarID,
                CoverImageUrl = c.CoverImageUrl,
                Fuel = c.Fuel,
                Km = c.Km,
                Luggage = c.Luggage,
                Model = c.Model,
                Seat = c.Seat,
                Transmission = c.Transmission
            }).ToList();
        }
    }
}
