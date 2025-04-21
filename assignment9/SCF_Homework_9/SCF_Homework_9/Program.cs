
using Microsoft.EntityFrameworkCore;
using Myd;

namespace SCF_Homework_9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Configuration.AddJsonFile("appsettings.json");
            

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseDefaultFiles(); //启用缺省静态页面（index.html或index.htm）
            app.UseStaticFiles(); //启用静态文件（页面、js、图片等各种前端文件）

            app.UseHttpsRedirection(); //启动http到https的重定向
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
