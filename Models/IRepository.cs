namespace Assignment3_Backend.Models
{
    public interface IRepository
    {
        Task<bool> SaveChangesAsync();
        Task<Product[]> GetProductsAsync();
        Task<ProductType[]> GetProductTypesAsync();
        Task<Brand[]> GetBrandsAsync();

        void Add<T>(T entity) where T : class;
    }
}
