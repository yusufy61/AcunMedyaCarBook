﻿using AcunMedyaCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using AcunMedyaCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using AcunMedyaCarBook.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;

        public CategoriesController(GetCategoryQueryHandler getCategoryQueryHandler,
            GetCategoryByIdQueryHandler getCategoryByIdQueryHandler,
            CreateCategoryCommandHandler createCategoryCommandHandler,
            RemoveCategoryCommandHandler removeCategoryCommandHandler,
            UpdateCategoryCommandHandler updateCategoryCommandHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var valıes = await _getCategoryQueryHandler.Handle();
            return Ok(valıes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> CategoryGetById(int id)
        {
            var value = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _createCategoryCommandHandler.Handle(command);
            return Ok("Kategori bilgisi eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCategory(RemoveCategoryCommand command)
        {
            await _removeCategoryCommandHandler.Handle(command);
            return Ok("Kategori Silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return Ok("Kategori Güncellendi.");
        }
    }
}
