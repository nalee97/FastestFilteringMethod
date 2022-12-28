// See https://aka.ms/new-console-template for more information


using BenchmarkDotNet.Running;
using Bogus;
using FastestFilteringMethod;
using System.Diagnostics;

Console.WriteLine("Testing the fastest way to filter from the list");

BenchmarkRunner.Run<ConvertDateToString>();

/*
var listOfEmployees = new Faker<Employee>()
    .RuleFor(e => e.Id, f => f.Random.Guid())
    .RuleFor(e => e.Name, f => f.Name.FirstName())
    .RuleFor(e => e.Surname, f => f.Name.LastName())
    .RuleFor(e => e.Age, f => f.Random.Int(25, 40))
    .RuleFor(e => e.Email, f => f.Internet.Email())
    .RuleFor(e => e.Phone, f => f.Phone.PhoneNumber()
    ).Generate(1000);

*/


/*
 //run individually
//print last 10 employees from the list
Console.WriteLine("Print last 10 employees from the list");

foreach(var employee in listOfEmployees.Skip(listOfEmployees.Count-10))
{
    Console.WriteLine("First name : " + employee.Name + "Last name : " +employee.Surname);
}

Console.ReadLine();
*/


/*
 //run individually
//filter employee ages between 25-30

var FilteredEmployee =listOfEmployees.Where(e =>e.Age >=  25 && e.Age <= 30).ToList();

//print the count of filtered employee list
Console.WriteLine($"Count of filtered Employee list : {FilteredEmployee.Count}");

Console.ReadLine();
*/


/*
 //run individually
//filter employee ages between 25-30
var stopWatch = new Stopwatch();
stopWatch.Start();
var FilteredEmployee = listOfEmployees.Where(e => e.Age is >= 25 and <= 30).ToList();
stopWatch.Stop();
Console.WriteLine($"Time taken by Where method: {stopWatch.ElapsedTicks} ticks");


var newFilteredList = new List<Employee>();
stopWatch.Restart();
foreach (var employee in listOfEmployees)
{
    if (employee.Age >= 25 && employee.Age <= 30)
    {
        newFilteredList.Add(employee);
    }
}
 
stopWatch.Stop();
Console.WriteLine($"Time taken by Where method: {stopWatch.ElapsedTicks} ticks");

//print the count of filtered employee list
Console.WriteLine($"Count of filtered Employee list : {newFilteredList.Count}");
Console.ReadLine();

*/


/*
 //run individually
//Convert listOfStudent as ReadOnly list
var listOfEmployeesReadOnly = listOfEmployees.AsReadOnly();

//Filter students between age 13 to 18
var stopWatch = new Stopwatch();
stopWatch.Start();
var filteredEmployees = listOfEmployees.Where(e => e.Age is >= 25 and <= 30).ToList();
stopWatch.Stop();
Console.WriteLine($"Time taken by Where method: {stopWatch.ElapsedTicks} ticks");

stopWatch.Restart();
var filteredEmployeesFromReadOnlyList = listOfEmployeesReadOnly.Where(e =>e.Age is >= 25 and <= 30);
stopWatch.Stop();
Console.WriteLine($"Time taken by ReadOnly List: {stopWatch.ElapsedTicks} ticks");

var newFilteredList = new List<Employee>();
stopWatch.Restart();
foreach (var employee in listOfEmployees)
{
    if (employee.Age >= 25 && employee.Age <= 30)
    {
        newFilteredList.Add(employee);
    }
}
stopWatch.Stop();
Console.WriteLine($"Time taken by foreach method: {stopWatch.ElapsedTicks} ticks");

// Print the count of filtered students list
Console.WriteLine($"Count of filtered employees list: {newFilteredList.Count}");

Console.ReadLine(); 
*/