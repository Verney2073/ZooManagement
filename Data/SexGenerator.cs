namespace ZooManagement.Data;

public class SexGenerator
{
    private static readonly Random random = new Random();
    public static string GetRandomSex()
    {
        string[] genders = { "M", "F" };
        string randomGender = genders[random.Next(genders.Length)];
        return randomGender;

    }
}