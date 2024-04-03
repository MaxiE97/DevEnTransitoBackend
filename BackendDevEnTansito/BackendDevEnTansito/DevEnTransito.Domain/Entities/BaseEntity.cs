﻿using System.ComponentModel.DataAnnotations;

namespace BackendDevEnTansito.DevEnTransito.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set;} = DateTime.Now;
        public bool IsActive { get; set; } = true;

    }
}
