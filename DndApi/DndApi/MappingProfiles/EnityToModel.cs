using AutoMapper;
using DndApi.Contracts.Models;
using DndApi.Entitys;

namespace DndApi.MappingProfiles
{
    public class EnityToModel:Profile
    {
        public EnityToModel()
        {
            CreateMap<SkillEntity, SkillModel>();
            CreateMap<PlayerEntity, PlayerModel>();
            CreateMap<ArmorEntity, ArmorModel>();
            CreateMap<WeaponEntity, WeaponModel>();
            CreateMap<ClassEntity, ClassModel>();
        }
    }
}
