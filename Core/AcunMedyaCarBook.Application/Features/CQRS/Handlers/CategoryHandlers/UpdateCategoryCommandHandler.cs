﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Application.Features.CQRS.Commands.CategoryCommands;
using AcunMedyaCarBook.Application.Interfaces;
using AcunMedyaCarBook.Domain.Entities;

namespace AcunMedyaCarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CategoryID);
            value.Name = command.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
