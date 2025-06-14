﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BffMicrosoftEntraExternalID.Server.Controllers;

[ValidateAntiForgeryToken]
[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
[ApiController]
[Route("api/[controller]")]
public class DirectApiController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return ["some data", "more data", "loads of data"];
    }
}
