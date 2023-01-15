using MediatR;
using UsersManagement.DAL.Notes;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Notes.Commands.CreateNotes;
using UsersManagement.Model.Notes.Entities;

namespace UsersManagement.BLL.Notes.Commands;

public class CreateNoteAppService : IRequestHandler<CreateNoteInput, ApplicationServiceResponse<CreateNoteOutput>>
{
    private readonly INoteRepository _noteRepository;

    public CreateNoteAppService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }
    public async Task<ApplicationServiceResponse<CreateNoteOutput>> Handle(CreateNoteInput createNoteInput, CancellationToken cancellationToken)
    {
        Note newNote = new Note
        {
            Content = createNoteInput.NewContent,
            DateCreated = DateTime.Now,
            DateModified = DateTime.Now,
            Published = createNoteInput.Published,
            UserId = createNoteInput.UserId
        };

        _noteRepository.AddNote(newNote);

        return new ApplicationServiceResponse<CreateNoteOutput>
        {
            Result = new CreateNoteOutput() { NoteId = newNote.Id }
        };
    }
}
