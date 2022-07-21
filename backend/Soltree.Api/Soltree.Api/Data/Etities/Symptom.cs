using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soltree.Api.Data.Etities
{
    public class Symptom:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Symptom(string name, int categoryId)
        {
            Name = name;
            CategoryId = categoryId;
        }
    }
}
