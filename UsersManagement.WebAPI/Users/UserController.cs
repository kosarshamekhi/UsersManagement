using MediatR;
using Microsoft.AspNetCore.Mvc;
using UsersManagement.Model.Users.Commands.CreateUsers;
using UsersManagement.Model.Users.Commands.DeleteUsers;
using UsersManagement.Model.Users.Commands.UpdateUsers;
using UsersManagement.Model.Users.Queries.GetAllUsers;
using UsersManagement.Model.Users.Queries.GetUsersById;
using UsersManagement.WebAPI.Framework;

namespace UsersManagement.WebAPI.Users;

public class UserController : BaseController
{
    public UserController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("CreateUser")]
    public async Task<IActionResult> CreateUser(CreateUserInput createUserInput)
    {
        var response = await _mediator.Send(createUserInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpPut("UpdateUser")]
    public async Task<IActionResult> UpdateUser(UpdateUserInput updateUserInput)
    {
        var response = await _mediator.Send(updateUserInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpDelete("DeleteUser")]
    public async Task<IActionResult> DeleteUser(DeleteUserInput deleteUserInput)
    {
        var response = await _mediator.Send(deleteUserInput);

        return response.IsSuccess ? Ok(response) : BadRequest(response.Errors);
    }

    [HttpGet("GetAllUsers")]
    public async Task<IActionResult> GetAllUsers([FromQuery] GetAllUsersInput getAllUsersInput)
    {
        var response = await _mediator.Send(getAllUsersInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }

    [HttpGet("GetUserById")]
    public async Task<IActionResult> GetUserById([FromQuery] GetUserByIdInput getUserByIdInput)
    {
        var response = await _mediator.Send(getUserByIdInput);

        return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
    }
}
