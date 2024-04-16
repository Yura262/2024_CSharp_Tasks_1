public class MyAccessModifiers
{
    private int birthYear;
    protected string personalInfo;
    internal string IdNumber;

    public MyAccessModifiers(int birthYear, string idNumber, string personalInfo)
    {
        this.birthYear = birthYear;
        IdNumber = idNumber;
        this.personalInfo = personalInfo;
    }

    public int Age => DateTime.Now.Year - birthYear;

    public static byte averageMiddleAge = 50;

    internal string Name;

    public string NickName { get; internal set; }

    protected internal void HasLivedHalfOfLife()
    {
        Console.WriteLine("Half of life has been lived.");
    }

    public static bool operator ==(MyAccessModifiers obj1, MyAccessModifiers obj2)
    {
        if (obj1 is null || obj2 is null)
            return false;

        return obj1.Name == obj2.Name && obj1.Age == obj2.Age && obj1.personalInfo == obj2.personalInfo;
    }

    public static bool operator !=(MyAccessModifiers obj1, MyAccessModifiers obj2)
    {
        return !(obj1 == obj2);
    }
}