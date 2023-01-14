using MediatR;
using UsersManagement.DAL.Users;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Users.Commands.UpdateUsers;
using UsersManagement.Model.Users.Entities;

namespace UsersManagement.BLL.Users.Commands;

public class UpdateUserAppService : IRequestHandler<UpdateUserInput, ApplicationServiceResponse<UpdateUserOutput>>
{
    private readonly IUserRepository _userRepository;

    public UpdateUserAppService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ApplicationServiceResponse<UpdateUserOutput>> Handle(UpdateUserInput updateUserInput, CancellationToken cancellationToken)
    {
        ApplicationServiceResponse<User> response = new();


        User user = _userRepository.GetUserById(updateUserInput.UserId);

        if (updateUserInput.UserId == null)
        {
            response.AddError($"کاربر با شناسه {updateUserInput.UserId} یافت نشد!");
        }
        else
        {
            user.FirstName = updateUserInput.NewFirstName;
            user.Email = updateUserInput.NewEmail;
            user.Age = updateUserInput.NewAge;

            response.Result = user;
        }
        return new ApplicationServiceResponse<UpdateUserOutput>
        {
            Result = new UpdateUserOutput() { UserId = user.Id }
        };
    }
}
