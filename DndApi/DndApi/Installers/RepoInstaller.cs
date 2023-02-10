using DndApi.Repos;
using DndApi.Repos.Interfaces;

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
            services.AddScoped<IClassRepo, ClassRepo>();


            services.AddScoped<PlayerRepo>();
            services.AddScoped<ArmorRepo>();
            services.AddScoped<SkillRepo>();
            services.AddScoped<WeaponRepo>();
            services.AddScoped<ClassRepo>();


            return services;
        }
    }
}
