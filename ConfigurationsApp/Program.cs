// See https://aka.ms/new-console-template for more information

using System.Configuration;
using ConfigurationsApp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ConfigurationManager = System.Configuration.ConfigurationManager;

var configuration = new ConfigurationBuilder()
    .AddEnvironmentVariables()
    .Build();
var queueConfiguration = configuration.GetSection(QueueConfiguration.ConfigSectionName).Get<QueueConfiguration>();
Console.WriteLine(queueConfiguration.ConnectionString);
Console.WriteLine(queueConfiguration.QueueName);

var hui = configuration.GetSection("SuperConfiguration:People").Get<Person>();
Console.WriteLine("Result = {0},{1},{2}",hui.Id,hui.IsDolboeb, hui.Name);

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
//
// var hui5 = configuration.GetSection("SuperConfiguration:People").Get<List<Person>>();
// foreach (Person person in hui5)
// {
//     Console.WriteLine($"{person.Id} {person.Name} {person.IsDolboeb} ");
// }
//
// var hui6 = configuration.GetSection("SuperConfiguration:People").Get<List<Person>>();
//
// foreach (Person person in hui6)
// {
//     var info = person.AdditionalInfo;
//     Console.WriteLine($"{person.Id} {person.Name} {person.IsDolboeb} ");
//     foreach (var key in info)
//     {
//         Console.WriteLine("Key = {0} Value = {1}", key.Key, key.Value );
//     }
// }
//
//
//







