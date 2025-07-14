using AcunMedyaCarBook.Application.Features.CQRS.Commands.CarCommands;
using AcunMedyaCarBook.Application.Features.CQRS.Handlers.CarHandlers;
using AcunMedyaCarBook.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;

        public CarsController(GetCarQueryHandler getCarQueryHandler,
            GetCarByIdQueryHandler getCarByIdQueryHandler,
            CreateCarCommandHandler createCarCommandHandler,
            RemoveCarCommandHandler removeCarCommandHandler,
            UpdateCarCommandHandler updateCarCommandHandler)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var valıes = await _getCarQueryHandler.Handle();
            return Ok(valıes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> CarGetById(int id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok("Araba bilgisi eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCar(RemoveCarCommand command)
        {
            await _removeCarCommandHandler.Handle(command);
            return Ok("Araba Bilgisi Silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Araba Bilgisi Güncellendi.");
        }
    }
}
