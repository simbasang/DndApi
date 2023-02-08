using DndApi.Repos;
using DndApi.Repos.EmptyRepos;
using DndApi.Repos.Interfaces;
using DndApi.Services.EmptyServices;
using DndApi.Services.Interfaces;

namespace DndApi.Installers
{
    public static class RepoInstaller
    {
        public static IServiceCollection AddRepos(this IServiceCollection services)
        {
            services.AddScoped<IPlayerRepo, PlayerRepo>();
            services.AddScoped<ISkillRepo, SkillRepo>();
            services.AddScoped<IArmorRepo, ArmorRepo>();
            services.AddScoped<IWeaponRepo, WeaponRepo>();


            services.AddScoped<ArmorRepo>();
            services.AddScoped<SkillRepo>();
            services.AddScoped<WeaponRepo>();


            return services;
        }
    }
}
