using MediatR;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Users.Entities;

namespace UsersManagement.Model.Notes.Commands.CreateNotes;

public class CreateNoteInput : IRequest<ApplicationServiceResponse<CreateNoteOutput>>
{
    public string NewContent { get; set; }
    public bool Published { get; set; }
    public User User { get; set; }
    public int UserId { get; set; }
}
