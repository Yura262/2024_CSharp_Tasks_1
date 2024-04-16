public class Employee
{
    internal string name;
    private DateTime hiringDate;

    public Employee(string name, DateTime hiringDate)
    {
        this.name = name;
        this.hiringDate = hiringDate;
    }

    public int Experience()
    {
        TimeSpan experienceTimeSpan = DateTime.Now - hiringDate;
        int fullYears = (int)(experienceTimeSpan.TotalDays / 365.25);
        return fullYears;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{name} has {Experience()} years of experience");
    }
}

public class Developer : Employee
{
    private string programmingLanguage;

    public Developer(string name, DateTime hiringDate, string programmingLanguage)
        : base(name, hiringDate)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"{name} is {programmingLanguage} programmer");
    }
}

public class Tester : Employee
{
    private bool isAutomation;

    public Tester(string name, DateTime hiringDate, bool isAutomation)
        : base(name, hiringDate)
    {
        this.isAutomation = isAutomation;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        if (isAutomation)
            Console.WriteLine($"{name} is automated tester and has {Experience()} year(s) of experience");
        else
            Console.WriteLine($"{name} is manual tester and has {Experience()} year(s) of experience");
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Developer dev = new Developer("John", new DateTime(2018, 3, 15), "C#");
//        Tester tester1 = new Tester("Alice", new DateTime(2019, 5, 20), true);
//        Tester tester2 = new Tester("Bob", new DateTime(2017, 8, 10), false);

//        dev.ShowInfo();
//        tester1.ShowInfo();
//        tester2.ShowInfo();
//    }
//}