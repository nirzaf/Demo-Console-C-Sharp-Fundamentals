public static class Student
{
    public static int Id;
    public string Name { get; set; }
    public int Age { get; set; }

    public Student()
    {
        
    }
    public Student(int id, string name,  int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}