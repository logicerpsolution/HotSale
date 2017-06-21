using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApplication.DBModel
{
    public class SaleMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean IsActive { get; set; }
        public ICollection<ProductSaleJoin> ProductSaleJoins { get; set; }
    }
}
