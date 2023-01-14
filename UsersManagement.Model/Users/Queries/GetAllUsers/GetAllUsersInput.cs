using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Users.Queries.GetAllUsers;

public class GetAllUsersInput : IRequest <ApplicationServiceResponse<GetAllUserOutput>>
{

}
