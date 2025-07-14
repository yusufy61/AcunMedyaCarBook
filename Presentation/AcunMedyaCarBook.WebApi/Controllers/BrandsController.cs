using AcunMedyaCarBook.Application.Features.CQRS.Commands.BrandCommands;
using AcunMedyaCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using AcunMedyaCarBook.Application.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;

        public BrandsController(GetBrandQueryHandler getBrandQueryHandler,
            GetBrandByIdQueryHandler getBrandByIdQueryHandler,
            CreateBrandCommandHandler createBrandCommandHandler,
            RemoveBrandCommandHandler removeBrandCommandHandler,
            UpdateBrandCommandHandler updateBrandCommandHandler)
        {
            _getBrandQueryHandler = getBrandQueryHandler;
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var valıes = await _getBrandQueryHandler.Handle();
            return Ok(valıes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BrandGetById(int id)
        {
            var value = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _createBrandCommandHandler.Handle(command);
            return Ok("Brand bilgisi eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(RemoveBrandCommand command)
        {
            await _removeBrandCommandHandler.Handle(command);
            return Ok("Brand Silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _updateBrandCommandHandler.Handle(command);
            return Ok("Brand Güncellendi.");
        }
    }
}
