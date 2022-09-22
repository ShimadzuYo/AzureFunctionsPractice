// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Configuration;
using ConfigurationsApp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ConfigurationManager = System.Configuration.ConfigurationManager;


var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var grayLog = configuration.GetSection("GrayLog").Get<jobOptionsGrayLog>();
var sqlConnectionString = configuration.GetSection("SqlServerConfiguration").Get<jobOptionsSqlServerOptions>();

Console.WriteLine("Info: {0} {1} {2} {3} {4}", grayLog.Enabled, grayLog.Facility, grayLog.Port, grayLog.Server, grayLog.LogLevel);











