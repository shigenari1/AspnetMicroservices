using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// 全ての商品を取得する
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProducts();
        
        /// <summary>
        /// 製品IDで商品を取得する
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetProduct(string id);
        
        /// <summary>
        /// 製品名で商品を取得する
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProductByName(string name);

        /// <summary>
        /// カテゴリ名で商品を取得する
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProductByCategory(string categoryName);

        /// <summary>
        /// 商品を作成する
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task CreateProduct(Product product);
        
        /// <summary>
        /// 商品を更新する
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<bool> UpdateProduct(Product product);
        
        /// <summary>
        /// 商品を削除する
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteProduct(string id);


    }
}
