using APIListing.Data;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace APIListing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            var connectionString =
                builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<DataBaseContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

          

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
                
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = "APIListing", Version = "v1" });
                }

                
                );
            builder.Services.AddControllers();

            builder.Host.UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
            .ReadFrom.Configuration(hostingContext.Configuration)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
             );

            try
            {
                Log.Information("Application Starting up");
                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseSwagger();
                app.UseSwaggerUI(

                    options =>
                    {
                        options.SwaggerEndpoint("/swagger/v1/swagger.json", "APIListing v1");
                    });

                app.UseHttpsRedirection();

                app.UseCors("AllowAll");

                app.UseAuthorization();




                app.MapControllers();

                app.Run();
            }
            catch (Exception ex)
            {

                Log.Fatal(ex, "Application failed to start",new {methodName="Main"});
               
            }

            finally
            {
                Log.CloseAndFlush();
            }

            

           
        }
    }
}