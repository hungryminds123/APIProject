using APIProject.Core.Concrete;
using APIProject.Core.Interfaces;
using Domain;
using Domain.Repository.Concrete;
using Domain.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace APIProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<SampleDatabaseDbContext>(
                options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("SampleDatabaseConnectionString"));
                });



            builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();


            builder.Services.AddTransient<IEmployeeService, EmployeeService>();  // this is important to register depepdencies.
            builder.Services.AddTransient<IDepartmentService, DepartmentService>();
            

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
