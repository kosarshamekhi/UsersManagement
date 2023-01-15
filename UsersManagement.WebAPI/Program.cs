using MediatR;
using Microsoft.EntityFrameworkCore;
using UsersManagement.BLL.Notes.Commands;
using UsersManagement.BLL.Notes.Queries;
using UsersManagement.BLL.Users.Commands;
using UsersManagement.BLL.Users.Queries;
using UsersManagement.DAL.DbContexts;
using UsersManagement.DAL.Notes;
using UsersManagement.DAL.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<UserDbContext>(c => c.UseInMemoryDatabase("Server=.; Initial Catalog=UserMamagement; Integrated Security = SSPI; TrustServerCertificate=True"));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<INoteRepository, NoteRepository>();

builder.Services.AddMediatR(
    typeof(CreateUserAppService).Assembly,
    typeof(UpdateUserAppService).Assembly,
    typeof(DeleteUserAppService).Assembly,
    typeof(GetAllUserAppService).Assembly,
    typeof(GetUserByIdAppService).Assembly);

builder.Services.AddMediatR(
    typeof(CreateNoteAppService).Assembly,
    typeof(UpdateNoteAppService).Assembly,
    typeof(DeleteNoteAppService).Assembly,
    typeof(GetNoteByIdAppService).Assembly,
    typeof(GetUsersAllNotesAppService).Assembly);
    


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
