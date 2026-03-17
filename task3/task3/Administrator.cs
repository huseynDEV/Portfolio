class Administrator : Person
{
    public string Position;
    public string Department;
    public int AccessLevel;

    public Administrator(string firstName, string lastName, int age, string email, string id,
        string position, string department, int access)
        : base(firstName, lastName, age, email, id)
    {
        Position = position;
        Department = department;
        AccessLevel = access;
    }

    public void ShowAdminInfo()
    {
        ShowBasicInfo();
        Console.WriteLine("Position: " + Position);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Access Level: " + AccessLevel);
    }

    public void GrantAccess(Student s)
    {
        Console.WriteLine(s.GetFullName() + " sistemə giriş icazəsi aldı.");
    }
}