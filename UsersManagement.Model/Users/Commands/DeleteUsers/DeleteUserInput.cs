using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Users.Commands.DeleteUsers;

public class DeleteUserInput : IRequest <ApplicationServiceResponse>
{
    public int UserId { get; set; }

}
