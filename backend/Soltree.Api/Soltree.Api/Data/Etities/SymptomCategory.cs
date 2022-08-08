using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Etities
{
    public class SymptomCategory : BaseEntity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public Guid? ModelId { get; set; }

        public Model? Model { get; set; }
    }
}
