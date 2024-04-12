
using O2.cars.booking.core.common;
using O2.cars.booking.core.dto;
using O2.cars.booking.core.requests;
using O2.cars.booking.core.responses;

namespace O2.cars.booking.core.service.impl;

public class AuthService : IAuthService
{
    public async Task<LoginResponse> Login(LoginRequest login)
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse> Register(RegisterRequest auth)
    {
        throw new NotImplementedException();
    }
}