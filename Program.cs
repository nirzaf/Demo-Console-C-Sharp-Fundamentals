using static System.Console;
using static System.String;

//Create an Array of Students Marks with 10 elements 
int[] marks = { 45, 55, 65, 75, 56, 75, 79, 54, 59, 67 };

//find duplicated value in marks array and print it using for loop
for (int i = 0; i < marks.Length; i++)
{
    for (int j = i + 1; j < marks.Length; j++)
    {
        if (marks[i] == marks[j])
        {
            WriteLine($"{marks[i]} is duplicated");
        }
    }
}


var duplicates = marks.GroupBy(x => x)
    .Where(g => g.Count() > 1)
    .Select(y => new { Item = y.Key, Count = y.Count() })
    .ToList();

WriteLine(Join("\n", duplicates));

ReadLine();













