using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Users.Queries.GetUsersById;

public class GetUserByIdInput : IRequest<ApplicationServiceResponse<GetUserByIdOutput>>
{
    public int UserId { get; set; }

}
