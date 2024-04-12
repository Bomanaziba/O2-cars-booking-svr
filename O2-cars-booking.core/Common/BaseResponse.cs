namespace O2.cars.booking.core.common;

public class BaseResponse
{
    public int HttpStatusCode { get; set; }
    public string Code { get; set; }
    public string Message { get; set; }
}