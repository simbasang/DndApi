﻿using DndApi.Entitys.Interfaces;
using DndApi.Enums;

namespace DndApi.Entitys
{
    public class WeaponEntity : IEntity
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public WeaponType WeaponType { get; set; }
        public int Range { get; set; }
        public bool IsTwoHanded { get; set; }

    }
}
