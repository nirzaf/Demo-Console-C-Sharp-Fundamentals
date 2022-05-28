using static System.Console;
using static System.String;

//Create an Array of Students Marks with 10 elements 
int[] marks = {45, 55, 65, 75, 56, 75, 79, 54, 59, 67};

//find all duplicated values in marks array and assigned to a new array using for loop

var duplicates = marks.GroupBy(x => x)
    .Where(g => g.Count() > 1)
    .Select(y => new { Item = y.Key, Count = y.Count() })
    .ToList();

WriteLine(Join("\n", duplicates));

// foreach (var items in duplicates)
// {
//     WriteLine(items);
// }

ReadLine();













