using RealEstate_Dapper_Api.Dto.CategoryDto;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepositories
{
	public interface ICategoryRepository
	{
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();
		void CreateCategory(CreateCategoryDto categoryDto);
		void UpdateCategory(UpdateCategoryDto updateCategoryDto);
		void DeleteCategory(int id);
		Task<GetByIDCategoryDto> GetCategory(int id);

	}
}
