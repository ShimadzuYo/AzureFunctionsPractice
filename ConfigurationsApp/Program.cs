// See https://aka.ms/new-console-template for more information

using System.Configuration;
using ConfigurationsApp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ConfigurationManager = System.Configuration.ConfigurationManager;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

// var hui = configuration.GetSection("Section1").GetSection("Section2").Get<HuiConfiguration>();
// Console.WriteLine(hui.Name + hui.Age);
// // var hui2 = configuration.GetRequiredSection("Section2").Value;
// var hui3 = configuration.GetSection("Section1:Section2").Get<HuiConfiguration>();
// Console.WriteLine(hui3.Name + hui3.Age);
// var hui4 = configuration.GetSection("SuperConfiguration:Ids").Get<List<int>>();
// foreach (int a in hui4)
// {
//     Console.WriteLine(a);
// }

var hui5 = configuration.GetSection("SuperConfiguration:People").Get<List<Person>>();
foreach (Person person in hui5)
{
    Console.WriteLine($"{person.Id} {person.Name} {person.IsDolboeb} ");
}

var myDick = new Dictionary<Person, AdditonalInfo>();











