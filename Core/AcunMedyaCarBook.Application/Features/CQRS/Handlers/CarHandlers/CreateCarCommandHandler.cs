using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.CQRS.Commands.BrandCommands;
using AcunMedyaCarBook.Application.Features.CQRS.Commands.CarCommands;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Domain.Entities;

namespace AcunMedyaCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BrandID = command.BrandID,
                BigImageUrl = command.BigImageUrl,
                CoverImageUrl = command.CoverImageUrl,
                Fuel = command.Fuel,
                Transmission = command.Transmission,
                Km = command.Km,
                Model = command.Model,
                Seat = command.Seat,
                Luggage = command.Luggage,
            });
        }
    }
}
