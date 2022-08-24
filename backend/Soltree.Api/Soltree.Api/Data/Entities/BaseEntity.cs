using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
