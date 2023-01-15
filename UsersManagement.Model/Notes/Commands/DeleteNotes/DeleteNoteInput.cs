using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Notes.Commands.DeleteNotes;

public class DeleteNoteInput : IRequest<ApplicationServiceResponse>
{
    public int NoteId { get; set; }
}
