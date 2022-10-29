using System;
var pr = new Person();
pr.Name = Console.ReadLine();
pr.Surname = Console.ReadLine();
pr.Age = Convert.ToInt32(Console.ReadLine());

var list = new List<object>();
list.Add(pr.Surname);
list.Add(pr.Name);
list.Add(pr.Age);
foreach (var item in  list)
{
    System.Console.Write($"{item} ");
}