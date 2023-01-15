using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsersManagement.Model.Notes.Commands.CreateNotes;
using UsersManagement.Model.Notes.Commands.DeleteNotes;
using UsersManagement.Model.Notes.Commands.UpdateNotes;
using UsersManagement.Model.Notes.Queries.GetNoteById;
using UsersManagement.Model.Notes.Queries.GetUsersAllNotes;
using UsersManagement.Model.Users.Commands.DeleteUsers;
using UsersManagement.Model.Users.Queries.GetAllUsers;
using UsersManagement.Model.Users.Queries.GetUsersById;
using UsersManagement.WebAPI.Framework;

namespace UsersManagement.WebAPI.Notes;

public class NoteController : BaseController
{
    public NoteController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("CreateNote")]
    public async Task<IActionResult> CreateNote(CreateNoteInput createNoteInput)
    {
        var response = await _mediator.Send(createNoteInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpPut("UpdateNote")]
    public async Task<IActionResult> UpdateNote(UpdateNoteInput updateNoteInput)
    {
        var response = await _mediator.Send(updateNoteInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpDelete("DeleteNote")]
    public async Task<IActionResult> DeleteNote(DeleteNoteInput deleteNoteInput)
    {
        var response = await _mediator.Send(deleteNoteInput);

        return response.IsSuccess ? Ok(response) : BadRequest(response.Errors);
    }

    [HttpGet("GetUsersAllNotes")]
    public async Task<IActionResult> GetUsersAllNotes([FromQuery] GetUsersAllNotesInput getUsersAllNotesInput)
    {
        var response = await _mediator.Send(getUsersAllNotesInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpGet("GetNoteById")]
    public async Task<IActionResult> GetNoteById([FromQuery] GetNoteByIdInput getNoteByIdInput)
    {
        var response = await _mediator.Send(getNoteByIdInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }
}
