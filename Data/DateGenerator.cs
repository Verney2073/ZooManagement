
namespace ZooManagement.Data;

public class DateGenerator
{

    private static readonly Random random = new Random();

    public static DateTime GetDateofBirth()
    {
        DateTime startDate = DateTime.Now.AddYears(-30);
        int range = (DateTime.Today - startDate).Days;
        DateTime randomDate = startDate.AddDays(random.Next(range));
        return randomDate;

    }

    public static DateTime GetDateAcquiredByZoo(DateTime dateofbirth) 
    {
        DateTime startDate = dateofbirth;
        int range = (DateTime.Today - startDate).Days;
        DateTime randomDate = startDate.AddDays(random.Next(range));
        return randomDate;

    }

}