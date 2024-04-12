
using O2.cars.booking.core.dto;

namespace O2.cars.booking.core.service;

public interface IAuthService
{
    public AuthDto Login(AuthDto auth);
    public AuthDto Register(AuthDto auth);
}