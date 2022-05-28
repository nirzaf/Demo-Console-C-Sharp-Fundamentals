using static System.Console;

//List<string> names = new() { "John", "Paul", "George", "Ringo" };

//foreach (var name in names)
//{
//    WriteLine(name);
//}

//WriteLine("------------------");
//names.Add("Fazrin");
//names.ForEach(WriteLine);

//List<string> addedNames = new() { "Mohamed", "Abdul", "Ahmed" };
//names.AddRange(addedNames);

//names.ForEach(WriteLine);

List<Student> students = new()
{
    new() { Name = "John", Age = 18, City = "London", Grade = 10 },
    new() { Name = "Paul", Age = 20 , City = "Paris", Grade = 12 },
    new() { Name = "George", Age = 21, City = "Berlin", Grade = 11 },
    new() { Name = "Ringo", Age = 25, City = "Liverpool", Grade = 9 },
    new() { Name = "Fazrin", Age = 22, City = "Manchester", Grade = 8 }
};

//var filteredStudents = students.Where(c => c.Age >= 21);

//foreach (var stu in filteredStudents)
//{
//    WriteLine(" Name: " + stu.Name + " Age: " + stu.Age + " City: " + stu.City + " Grade: " + stu.Grade);
//}

//foreach (var stu in students)
//{
//    WriteLine(" Name: " + stu.Name +" Age: " +stu.Age + " City: " + stu.City + " Grade: "+ stu.Grade );
//}



Tuple<int, string, string> person1 = new(1, "Steve", "Jobs");
Tuple<int, string, string> person2 = new(2, "Bill", "Gates");
Tuple<int, string, string> person3 = new(3, "Satya", "Nadella");
Tuple<int, string, string> person4 = new(4, "Elon", "Musk");
Tuple<int, string, string> person5 = new(5, "Mohamed", "Fazrin");

WriteLine(person1.Item1);
WriteLine(person1.Item2);
WriteLine(person4.Item3);

ReadLine();
record Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public int Grade { get; set; }
}















