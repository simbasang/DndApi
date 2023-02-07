using Azure.Core;
using DndApi.Entitys.Interfaces;
using DndApi.Services;
using DndApi.Services.EmptyServices;
using DndApi.Services.Generic;
using DndApi.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DndApi.Installers
{
    public static class ServicInstaller
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<ISkillService, SkillService>();


            return services;
        }
    }
}
