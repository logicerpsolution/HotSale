namespace Sales.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using SalesApp.Model;
    using System.Threading.Tasks;
    using Sales.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class Sale : ISale
    {

        private SaleDBContext context;

        public Sale(SaleDBContext context)
        {
            this.context = context;
        }

        public Task<int> AddAsync(SaleMaster vehicle)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int SaleMasterId)
        {
            throw new NotImplementedException();
        }

        public  Task<SaleMaster> GetSaleAsync(int SaleMasterId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SaleMaster>> GetSaleAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SaleMaster>> GetSalesAsync()
        {
            IQueryable<SaleMaster> _saleMaster = this.context.SaleMasters
                                                .Include(product => product.ProductSaleJoins.Select(p => p.ProductMaster))
                                                .Where(s => s.IsActive == true);


            return _saleMaster.ToList();
        }
    }
}
