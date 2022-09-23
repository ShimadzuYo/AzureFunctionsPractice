// See https://aka.ms/new-console-template for more information

using System.Configuration;
using ConfigurationsApp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ConfigurationManager = System.Configuration.ConfigurationManager;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettingsJson.json");

configuration.Build();
    








