
using O2.cars.booking.core.common;

namespace O2.cars.booking.core.responses;

public class LoginResponse : BaseResponse
{
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Token { get; set; }
    public string RefreshToken { get; set; }
}