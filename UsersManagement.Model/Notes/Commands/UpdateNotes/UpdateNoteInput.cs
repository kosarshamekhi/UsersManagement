using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Notes.Commands.UpdateNotes;

public class UpdateNoteInput : IRequest<ApplicationServiceResponse<UpdateNoteOutput>>
{
    public int NoteId { get; set; }
    public string NewContent { get; set; }
    public bool Published { get; set; }
}
