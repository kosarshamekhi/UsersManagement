﻿using MediatR;
using UsersManagement.Model.Framework;

namespace UsersManagement.Model.Users.Commands.CreateUsers;

public class CreateUserInput : IRequest<ApplicationServiceResponse<CreateUserOutput>>
{
    public string NewFirstName { get; set; }
    public string? NewLastName { get; set; }
    public string NewEmail { get; set; }
    public int NewAge { get; set; }
    public string? NewWebsite { get; set; }
}
