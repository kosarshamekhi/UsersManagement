using MediatR;
using UsersManagement.DAL.Users;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Users.Entities;
using UsersManagement.Model.Users.Queries.GetAllUsers;

namespace UsersManagement.BLL.Users.Queries;

public class GetAllUserAppService : IRequestHandler<GetAllUsersInput, ApplicationServiceResponse<GetAllUserOutput>>
{
    private readonly IUserRepository _userRepository;

    public GetAllUserAppService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<ApplicationServiceResponse<GetAllUserOutput>> Handle(GetAllUsersInput getAllUsersInput, CancellationToken cancellationToken)
    {
        ApplicationServiceResponse<User> response = new();

        IEnumerable<User> UserList = _userRepository.GetAllUsers();

        throw new NotImplementedException();
    }
}
