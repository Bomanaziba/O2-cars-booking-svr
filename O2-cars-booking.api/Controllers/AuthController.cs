using Microsoft.AspNetCore.Mvc;
using O2.cars.booking.api.helper;
using O2.cars.booking.core.requests;
using O2.cars.booking.core.service;

namespace O2.cars.booking.api.controllers;

[Route("api/v1/[controller]")]
[ApiController]

public class AuthController : CoreController
{
    private readonly IAuthService _authService;
    private readonly ILogger<AuthController> _logger;

    public AuthController(IAuthService authService, ILogger<AuthController> logger)
    {
        _authService = authService;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginRequest loginRequest)
    {
        var resp = await _authService.Login(loginRequest);

        return StatusCode(resp.HttpStatusCode, resp);
    }  
}