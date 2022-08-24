using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Entities
{
    public class Brand : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
    }
}
