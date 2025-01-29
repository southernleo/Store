using Entities;

namespace Repositories.Contracts{
    public interface IProductRepository: IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
    }
}