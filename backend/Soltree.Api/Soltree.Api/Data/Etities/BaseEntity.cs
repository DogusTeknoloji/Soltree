using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Etities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
