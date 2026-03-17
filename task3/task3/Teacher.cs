class Teacher : Person
{
    public string Department;
    public string MainSubject;
    public decimal BaseSalary;
    public int ExperienceYears;

    public Teacher(string firstName, string lastName, int age, string email, string id,
        string department, string subject, decimal baseSalary, int exp)
        : base(firstName, lastName, age, email, id)
    {
        Department = department;
        MainSubject = subject;
        BaseSalary = baseSalary;
        ExperienceYears = exp;
    }

    public void ShowTeacherInfo()
    {
        ShowBasicInfo();
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Subject: " + MainSubject);
        Console.WriteLine("Experience: " + ExperienceYears);
    }

    public decimal CalculateSalary()
    {
        return BaseSalary + ExperienceYears * 50;
    }
}