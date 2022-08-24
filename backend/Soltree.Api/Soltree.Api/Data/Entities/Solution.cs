using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Entities
{
    public class Solution : BaseEntity
    {
        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public Guid? SymptomId { get; set; }

        public Symptom? Symptom { get; set; }
    }
}
