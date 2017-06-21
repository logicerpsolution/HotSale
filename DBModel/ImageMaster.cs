using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApplication.DBModel
{
    public class ImageMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        [ForeignKey("ProductMaster")]
        public int ProductId { get; set; }
        public string ImageURL { get; set; }
        public ProductMaster ProductMaster { get; set; }
    }
}
