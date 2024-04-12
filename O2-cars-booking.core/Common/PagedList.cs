
namespace O2.cars.booking.core.common;

public class PagedList<T> 
{
    public PagedList()
    {
        Data = new List<T>();
    }

    public IList<T> Data { get; set; }

    public int Index { get; set; }

    public int Size { get; set; }

    public long Total { get; set; }
}
