using DndApi.Entitys;

namespace DndApi.Contracts.Models
{
    public class ClassModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<SkillModel> Skills { get; set; } = new();
        public string Description { get; set; }
    }
}
