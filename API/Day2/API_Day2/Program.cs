
using API_Day2.Data.Context;
using Day2.DAL.Repo;
using Microsoft.EntityFrameworkCore;

namespace API_Day2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt = "hi";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<AppDBContect>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("myConn")));

            builder.Services.AddScoped<IInstructorRepo, InstructorRepo>();
            builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();


            builder.Services.AddCors(o =>
            {
                o.AddPolicy(txt, builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });

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
        }
    }
}