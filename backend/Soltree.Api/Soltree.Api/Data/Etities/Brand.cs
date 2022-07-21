using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Etities
{
    public class Brand : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public Brand(string name)
        {
            Name = name;
        }
    }
}
