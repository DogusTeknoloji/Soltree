using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Entities
{
    public class DeviceType : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public string? Image { get; set; }
    }
}
