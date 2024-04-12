
using O2.cars.booking.core.common;

namespace O2.cars.booking.core.dao;

public class InsuranceDetail : BaseDao
{
    public string DrivingLicenseNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PostCode { get; set; }
    public string Address { get; set; }
    public string Occupation { get; set; }
    public long  DrivingTestDetailId { get; set; }
}