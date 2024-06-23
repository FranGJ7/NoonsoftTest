using Microsoft.OpenApi.Models;
using TaskManager;


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:5173")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                      });
});



builder.Services.AddEndpointsApiExplorer();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "NoonSoft", Description = "To-Do List", Version = "v1" });
    });
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "To-Do List");
    });
}

app.UseCors(MyAllowSpecificOrigins);

app.MapGet("/", () => "NoonSoft API To-Do List");

app.MapGet("/task/{id}", (int id) => TaskRepository.GetTaskById(id));
app.MapGet("/tasks", () => TaskRepository.GetAllTasks());
app.MapPost("/task", (TaskManager.Task task) => TaskRepository.AddTask(task));
app.MapPut("/task", (TaskManager.Task task) => TaskRepository.UpdateTask(task));
app.MapDelete("/task/{id}", (int id) => TaskRepository.RemoveTask(id));

app.Run();
