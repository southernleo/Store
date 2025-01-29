using Services.Contracts;

namespace Services{


    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ServiceManager(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IProductService productService => _productService;

        public ICategoryService categoryService => _categoryService;
    }
}