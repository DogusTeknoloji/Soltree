using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soltree.Api.Data.Etities
{
    public class Model:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("BrandId")]
        public int BrandId { get; set; }
        [Required]
        [ForeignKey("TypeId")]
        public int TypeId   { get; set; }

        

        public Model(string name,int brandId, int typeId)
        {
            Name = name;
            BrandId = brandId;
            TypeId = typeId;
        }
    }
}
