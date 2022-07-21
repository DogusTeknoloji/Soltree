using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Etities
{
    public class SymptomCategory:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public SymptomCategory(string name)
        {
            Name = name;
        }
    }
}
