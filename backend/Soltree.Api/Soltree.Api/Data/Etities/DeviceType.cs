using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Etities
{
    public class DeviceType : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
    }
}
