﻿using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Etities
{
    public class Solution : BaseEntity
    {
        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}