using MediatR;
using UsersManagement.DAL.Users;
using UsersManagement.Model.Framework;
using UsersManagement.Model.Users.Entities;
using UsersManagement.Model.Users.Queries.GetUsersById;

namespace UsersManagement.BLL.Users.Queries;

public class GetUserByIdAppService : IRequestHandler<GetUserByIdInput, ApplicationServiceResponse<GetUserByIdOutput>>
{
    private readonly IUserRepository _userRepository;

    public GetUserByIdAppService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<ApplicationServiceResponse<GetUserByIdOutput>> Handle(GetUserByIdInput getUserByIdInput, CancellationToken cancellationToken)
    {
        ApplicationServiceResponse<User> response = new();

        User user = _userRepository.GetUserById(getUserByIdInput.UserId);

        if (getUserByIdInput.UserId != null)
        {
            response.AddError($"کاربر با شناسه {getUserByIdInput.UserId} یافت نشد!");
        }

        User result = await user.(c => new GetUserByIdOutput
        {
            UserId = c.Id,
            UserName = c.FirstName,
            UserEmail = c.Email,
            UserAge = c.Age
        }).ToListAsync();

        return new ApplicationServiceResponse<GetUserByIdOutput>
        {
            Result = new GetUserByIdOutput.(result) { }
        };
    }
}
