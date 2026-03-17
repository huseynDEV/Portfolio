class Student : Person
{
    public string StudentNumber;
    public string Faculty;
    public double GPA;
    public int Year;

    public Student(string firstName, string lastName, int age, string email, string id,
        string studentNumber, string faculty, double gpa, int year)
        : base(firstName, lastName, age, email, id)
    {
        StudentNumber = studentNumber;
        Faculty = faculty;
        GPA = gpa;
        Year = year;
    }

    public void ShowStudentInfo()
    {
        ShowBasicInfo();
        Console.WriteLine("Student No: " + StudentNumber);
        Console.WriteLine("Faculty: " + Faculty);
        Console.WriteLine("GPA: " + GPA);
        Console.WriteLine("Year: " + Year);
    }

    public double CalculateScholarship()
    {
        if (GPA >= 90) return 500;
        if (GPA >= 80) return 350;
        if (GPA >= 70) return 200;
        return 0;
    }
}