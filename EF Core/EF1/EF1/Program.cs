using EF1.Data.Context;

using AcademyContext context = new();

var allTeachers = context.Teachers.ToList();

foreach (var item in allTeachers)
{
    Console.WriteLine(item.Name);
}


