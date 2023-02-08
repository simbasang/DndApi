using AutoMapper;
using DndApi.Contracts.Models;
using DndApi.Entitys;

namespace DndApi.MappingProfiles
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<SkillModel, SkillEntity>();
            CreateMap<PlayerModel, PlayerEntity>();
            CreateMap<ArmorModel, ArmorEntity>();
            CreateMap<WeaponModel, WeaponEntity>();
        }
    }
}
