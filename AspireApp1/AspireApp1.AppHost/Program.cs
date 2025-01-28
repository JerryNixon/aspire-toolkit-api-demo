var dabconfig = @"C:\Temp\demo\dab-config.json";
var dacpac = @"C:\Temp\demo\Database1\bin\Debug\Database1.dacpac";

var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
    .AddDatabase("db");

var sqlproj = builder.AddSqlProject("dacpac")
    .WithDacpac(dacpac)
    .WithReference(sql);

var api = builder.AddDataAPIBuilder("api", dabconfig)
    .WithReference(sql)
    .WaitFor(sqlproj);

builder.AddProject<Projects.ConsoleApp1>("console")
    .WithReference(api);

builder.Build().Run();
