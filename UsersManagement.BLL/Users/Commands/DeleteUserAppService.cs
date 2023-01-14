using MediatR;
using UsersManagement.DAL.Users;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Users.Commands.DeleteUsers;
using UsersManagement.Model.Users.Entities;

namespace UsersManagement.BLL.Users.Commands;

public class DeleteUserAppService : IRequestHandler<DeleteUserInput, ApplicationServiceResponse>
{
    private readonly IUserRepository _userRepository;

    public DeleteUserAppService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<ApplicationServiceResponse> Handle(DeleteUserInput deleteUserInput, CancellationToken cancellationToken)
    {
        ApplicationServiceResponse response = new();


        User user = _userRepository.GetUserById(deleteUserInput.UserId);

        if (deleteUserInput.UserId == null)
        {
            response.AddError($"کاربر با شناسه {deleteUserInput.UserId} یافت نشد!");
        }
        else
        {
            _userRepository.DeleteUser(deleteUserInput.UserId);
        }
        return response;
    }
}
