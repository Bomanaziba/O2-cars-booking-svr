using O2.cars.booking.core.common;

namespace O2.cars.booking.core.dao;

public class DrivingDetail : BaseDao
{
    public string Firstname { get; set; }
    public string Surname { get; set; }
    public string TestReferenceNumber { get; set; }
    public DateTime TestDateTime { get; set; }
    public string TestLocation { get; set; }
    public string PickUpLocation { get; set; }
    public string DrivingTestLocation { get; set; }
    public string EmailAddress { get; set; }
    public string MobileNumber { get; set; }
}