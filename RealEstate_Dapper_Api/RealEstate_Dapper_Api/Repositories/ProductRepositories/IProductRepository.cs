using RealEstate_Dapper_Api.Dto.ProductDto;

namespace RealEstate_Dapper_Api.Repositories.ProductRepositories
{
	public interface IProductRepository
	{
		Task<List<ResultProductDto>> GetAllProductAsync();
		Task<List<ResultProductWithCategory>> GetAllResultProductWithCategorytAsync();
	}
}
