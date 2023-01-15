using MediatR;
using UsersManagement.DAL.Notes;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Notes.Commands.DeleteNotes;
using UsersManagement.Model.Notes.Entities;

namespace UsersManagement.BLL.Notes.Commands;

public class DeleteNoteAppService : IRequestHandler<DeleteNoteInput, ApplicationServiceResponse>
{
    private readonly INoteRepository _noteRepository;

    public DeleteNoteAppService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }
    public async Task<ApplicationServiceResponse> Handle(DeleteNoteInput deleteNoteInput, CancellationToken cancellationToken)
    {
        ApplicationServiceResponse response = new();


        Note note = _noteRepository.GetNoteById(deleteNoteInput.NoteId);

        if (deleteNoteInput.NoteId == null)
        {
            response.AddError($"کاربر با شناسه {deleteNoteInput.NoteId} یافت نشد!");
        }
        else
        {

        }
        return response;
    }
}
