using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Notes.Queries.GetNoteById;

public class GetNoteByIdInput : IRequest<ApplicationServiceResponse<GetNoteByIdOutput>>
{
    public int NoteId { get; set; }
}
