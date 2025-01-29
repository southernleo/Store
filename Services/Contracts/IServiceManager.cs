namespace Services.Contracts{
    public interface IServiceManager{
        IProductService productService{ get; }
        ICategoryService categoryService{ get; }
    }
}