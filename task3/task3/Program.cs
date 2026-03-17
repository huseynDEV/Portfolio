class Program
{
    static void Main()
    {
        Student s1 = new Student("Ali", "Aliyev", 20, "ali@mail.com", "1", "S001", "IT", 88.5, 2);
        Student s2 = new Student("Veli", "Veliyev", 21, "veli@mail.com", "2", "S002", "IT", 92.0, 3);
        Student s3 = new Student("Aysel", "Memmedova", 19, "aysel@mail.com", "3", "S003", "IT", 68.5, 1);

        Teacher t1 = new Teacher("Kamal", "Hesenov", 40, "k@mail.com", "4", "CS", "Programming", 800, 15);
        Teacher t2 = new Teacher("Leyla", "Quliyeva", 35, "l@mail.com", "5", "Math", "Algebra", 800, 8);

        Administrator admin = new Administrator("Resad", "Kerimov", 50, "r@mail.com", "6", "Dekan", "IT", 5);

        double totalScholarship = 0;
        decimal totalSalary = 0;

        Console.WriteLine("STUDENTS");
        s1.ShowStudentInfo();
        Console.WriteLine("Scholarship: " + s1.CalculateScholarship());
        totalScholarship += s1.CalculateScholarship();

        s2.ShowStudentInfo();
        Console.WriteLine("Scholarship: " + s2.CalculateScholarship());
        totalScholarship += s2.CalculateScholarship();

        s3.ShowStudentInfo();
        Console.WriteLine("Scholarship: " + s3.CalculateScholarship());
        totalScholarship += s3.CalculateScholarship();

        Console.WriteLine("\nTEACHERS");
        t1.ShowTeacherInfo();
        Console.WriteLine("Salary: " + t1.CalculateSalary());
        totalSalary += t1.CalculateSalary();

        t2.ShowTeacherInfo();
        Console.WriteLine("Salary: " + t2.CalculateSalary());
        totalSalary += t2.CalculateSalary();

        Console.WriteLine("\nADMIN");
        admin.ShowAdminInfo();

        admin.GrantAccess(s1);

        Console.WriteLine("\nTotal Scholarship: " + totalScholarship);
        Console.WriteLine("Total Salary: " + totalSalary);
    }
}