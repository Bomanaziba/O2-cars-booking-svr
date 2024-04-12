
using O2.cars.booking.core.common;
using O2.cars.booking.core.dto;
using O2.cars.booking.core.requests;
using O2.cars.booking.core.responses;

namespace O2.cars.booking.core.service;

public interface IAuthService
{
    Task<LoginResponse> Login(LoginRequest request);
    Task<BaseResponse> Register(RegisterRequest auth);
}