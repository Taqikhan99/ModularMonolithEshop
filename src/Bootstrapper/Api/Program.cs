var builder = WebApplication.CreateBuilder(args);

//services will be added here


var app = builder.Build();

//Request pipeline will be configured here using middleware calls

app.Run();
