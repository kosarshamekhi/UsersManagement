using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Users.Commands.UpdateUsers;

public class UpdateUserInput : IRequest<ApplicationServiceResponse<UpdateUserOutput>
{
    public int UserId { get; set; }
    public string NewFirstName { get; set; }
    public string? NewLastName { get; set; }
    public string NewEmail { get; set; }
    public int NewAge { get; set; }
    public string? NewWebsite { get; set; }
}
