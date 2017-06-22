
namespace Sales.Data.Interfaces
{
     using System.Threading.Tasks;
     using SalesApp.Model;
    using System.Collections.Generic;

    public interface ISale
    {
        Task<int> AddAsync(SaleMaster vehicle);
        Task DeleteAsync(int SaleMasterId);
        Task<SaleMaster> GetSaleAsync(int SaleMasterId);
        Task<IEnumerable<SaleMaster>> GetSalesAsync();
    }
}
