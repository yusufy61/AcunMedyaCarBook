using AcunMedyaCarBook.Application.Features.CQRS.Commands.ContactCommands;
using AcunMedyaCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using AcunMedyaCarBook.Application.Features.CQRS.Queries.ContactQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AcunMedyaCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly GetContactQueryHandler _getContactQueryHandler;
        private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
        private readonly CreateContactCommandHandler _createContactCommandHandler;
        private readonly RemoveContactCommandHandler _removeContactCommandHandler;
        private readonly UpdateContactCommandHandler _updateContactCommandHandler;

        public ContactsController(GetContactQueryHandler getContactQueryHandler,
            GetContactByIdQueryHandler getContactByIdQueryHandler,
            CreateContactCommandHandler createContactCommandHandler,
            RemoveContactCommandHandler removeContactCommandHandler,
            UpdateContactCommandHandler updateContactCommandHandler)
        {
            _getContactQueryHandler = getContactQueryHandler;
            _getContactByIdQueryHandler = getContactByIdQueryHandler;
            _createContactCommandHandler = createContactCommandHandler;
            _removeContactCommandHandler = removeContactCommandHandler;
            _updateContactCommandHandler = updateContactCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var valıes = await _getContactQueryHandler.Handle();
            return Ok(valıes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ContactGetById(int id)
        {
            var value = await _getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await _createContactCommandHandler.Handle(command);
            return Ok("Contact bilgisi eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveContact(RemoveContactCommand command)
        {
            await _removeContactCommandHandler.Handle(command);
            return Ok("Contact Silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await _updateContactCommandHandler.Handle(command);
            return Ok("Contact Güncellendi.");
        }
    }
}
