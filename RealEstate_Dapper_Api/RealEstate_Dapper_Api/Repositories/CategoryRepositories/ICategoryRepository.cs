using RealEstate_Dapper_Api.Dto.CategoryDto;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepositories
{
	public interface ICategoryRepository
	{
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();

	}
}
