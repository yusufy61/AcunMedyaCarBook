using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.CQRS.Commands.CarCommands;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Domain.Entities;

namespace AcunMedyaCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarID);
            value.BigImageUrl = command.BigImageUrl;
            value.BrandID = command.BrandID;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Fuel = command.Fuel;
            value.Model = command.Model;
            value.Km = command.Km;
            value.Luggage = command.Luggage;
            value.Seat = command.Seat;
            value.Transmission = command.Transmission;
            await _repository.UpdateAsync(value);
        }
    }
}
