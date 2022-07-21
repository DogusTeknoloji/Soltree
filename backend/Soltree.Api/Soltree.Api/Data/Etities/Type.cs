using System.ComponentModel.DataAnnotations;

namespace Soltree.Api.Data.Etities
{
    public class Type:BaseEntity
    {   
        [Required]
        public string Name  { get; set; }

        public Type(string name)
        {
            Name = name;
        }
    }
}
