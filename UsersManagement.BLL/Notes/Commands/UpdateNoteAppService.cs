using MediatR;
using UsersManagement.DAL.Notes;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Notes.Commands.UpdateNotes;
using UsersManagement.Model.Notes.Entities;

namespace UsersManagement.BLL.Notes.Commands;

public class UpdateNoteAppService : IRequestHandler<UpdateNoteInput, ApplicationServiceResponse<UpdateNoteOutput>>
{
    private readonly INoteRepository _noteRepository;

    public UpdateNoteAppService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }
    public async Task<ApplicationServiceResponse<UpdateNoteOutput>> Handle(UpdateNoteInput updateNoteInput, CancellationToken cancellationToken)
    {
        ApplicationServiceResponse<Note> response = new();

        Note note = _noteRepository.GetNoteById(updateNoteInput.NoteId);

        if (updateNoteInput.NoteId == null)
        {
            response.AddError($"یادداشتی با شناسه {updateNoteInput.NoteId} یافت نشد!");
        }
        else
        {
            note.Content = updateNoteInput.NewContent;
            note.DateModified = DateTime.Now;
            note.Published = updateNoteInput.Published;

            response.Result = note;
        }
        return new ApplicationServiceResponse<UpdateNoteOutput>
        {
            Result = new UpdateNoteOutput() { NoteId = note.Id }
        };
    }
}
