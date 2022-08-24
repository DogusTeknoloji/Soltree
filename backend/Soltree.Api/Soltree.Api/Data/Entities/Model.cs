using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soltree.Api.Data.Entities
{
    public class Model : BaseEntity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public Guid? BrandId { get; set; }

        public Brand? Brand { get; set; }
        [IsProjected(true)]
        [Required]
        public Guid? DeviceTypeId { get; set; }

        public DeviceType? DeviceType { get; set; }
    }
}
