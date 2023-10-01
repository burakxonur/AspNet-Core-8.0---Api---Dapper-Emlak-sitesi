using Dapper;
using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Dto.ProductDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ProductRepositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly Context _context;

		public ProductRepository(Context context)
		{
			_context = context;
		}
		public async Task<List<ResultProductDto>> GetAllProductAsync()
		{
			string query = "Select * from Product";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultProductDto>(query);
				return values.ToList();
			}
		}

		public async Task<List<ResultProductWithCategory>> GetAllResultProductWithCategorytAsync()
		{
			string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Adress from Product inner join Category on Product.ProductCategory=Category.CategoryID";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultProductWithCategory>(query);
				return values.ToList();
			}
		}
	}
}
