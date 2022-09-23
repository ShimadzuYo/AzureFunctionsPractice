// See https://aka.ms/new-console-template for more information

using ConfigurationsApp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var services = new ServiceCollection();
services.AddOptions();

services.Configure<GrayLogOptions>(configuration.GetSection("Graylog"));
services.Configure<SqlServerOptions>(configuration.GetSection("SqlServerConfiguration"));
services.Configure<AzureOptions>(configuration.GetSection("AzureConfiguration"));
services.Configure<ProviderApiOptions>(configuration.GetSection("ProviderApiConfiguration"));
services.Configure<ResiliencePolicyOptions>(configuration.GetSection("ResiliencePolicy"));
services.AddScoped<SomeService>();



var buildServiceProvider = services.BuildServiceProvider();
var someService = buildServiceProvider.GetService<SomeService>();
someService.PrintConfigurations();
