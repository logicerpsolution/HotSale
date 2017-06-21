﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDApplication.DBModel
{
    public class ProductSaleJoin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("SaleMaster")]
        public int SaleId { get; set; }
        [ForeignKey("ProductMaster")]
        public int ProductId { get; set; }
        public  ProductMaster ProductMaster { get; set; }
        public SaleMaster SaleMaster { get; set; }
    }
}