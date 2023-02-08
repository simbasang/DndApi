using AutoMapper;
using DndApi.Contracts.Request;
using DndApi.Entitys;

namespace DndApi.MappingProfiles
{
    public class RequestToEntity:Profile
    {
        public RequestToEntity()
        {
            CreateMap<PlayerRequest,PlayerEntity>();
            CreateMap<SkillRequest, SkillEntity>();
            CreateMap<ArmorRequest, ArmorEntity>();
        }
    }
}
