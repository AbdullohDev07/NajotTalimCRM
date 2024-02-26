using FileAPILesson.Application.Services.GroupServices;
using FileAPILesson.Application.Services.StudentServices;
using FileAPILesson.Application.Services.TeacherServices;
using Microsoft.Extensions.DependencyInjection;

namespace FileAPILesson.Application
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddServicees(this IServiceCollection services)
        {
            services.AddScoped<Services.StudentServices.IStudentService, StudentService>();
            services.AddScoped<Services.GroupServices.IGroupService, GroupService>();
            services.AddScoped<ITeacherService, TeacherService>();
            return services;
        }
    }
}