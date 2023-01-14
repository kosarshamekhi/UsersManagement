﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace UsersManagement.WebAPI.Framework;


[Route("api/[controller]")]
[ApiController]
public abstract class BaseController : ControllerBase
{
    protected readonly IMediator _mediator;

    public BaseController(IMediator mediator)
    {
        _mediator = mediator;
    }
}