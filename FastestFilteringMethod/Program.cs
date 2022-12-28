﻿// See https://aka.ms/new-console-template for more information

using Bogus;
using FastestFilteringMethod;

Console.WriteLine("Testing the fastest way to filter from the list");

var listOfStudents = new Faker<Employee>()
    .RuleFor(e => e.Id, f => f.Random.Guid())
    .RuleFor(e => e.Name, f => f.Name.FirstName())
    .RuleFor(e => e.Surname, f => f.Name.LastName())
    .RuleFor(e => e.Age, f => f.Random.Int(5, 18))
    .RuleFor(e => e.Email, f => f.Internet.Email())
    .RuleFor(e => e.Phone, f => f.Phone.PhoneNumber()
    ).Generate(1000);

//print last 10 students from the list
Console.WriteLine("Print last 10 students from the list");

foreach(var employee in listOfStudents.Skip(listOfStudents.Count-10))
{
    Console.WriteLine("First name : " + employee.Name + "Last name : " +employee.Surname);
}

Console.ReadLine();