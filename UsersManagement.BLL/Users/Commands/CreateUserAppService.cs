using MediatR;
using UsersManagement.DAL.Users;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Users.Commands.CreateUsers;
using UsersManagement.Model.Users.Entities;

namespace UsersManagement.BLL.Users.Commands;

public class CreateUserAppService : IRequestHandler<CreateUserInput, ApplicationServiceResponse<CreateUserOutput>>
{
    private readonly IUserRepository _userRepository;

    public CreateUserAppService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<ApplicationServiceResponse<CreateUserOutput>> Handle(CreateUserInput createUserInput,CancellationToken cancellationToken)
    {
        User newUser = new User
        {
            FirstName = createUserInput.NewFirstName,
            Email = createUserInput.NewEmail,
            Age = createUserInput.NewAge,
        };

        _userRepository.AddUser(newUser);

        return new ApplicationServiceResponse<CreateUserOutput>
        {
            Result = new CreateUserOutput() { UserId = newUser.Id }
        };
    }
}
