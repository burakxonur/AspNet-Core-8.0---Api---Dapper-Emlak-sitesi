using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Models.DapperContext;
using Dapper;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly Context _context;

		public CategoryRepository(Context context)
		{
			_context = context;
		}

		public async void CreateCategory(CreateCategoryDto categoryDto)
		{
			string query = "insert into Category (CategoryName,CategoryStatus) values (@categoryName, @categoryStatus)";
			var paramerters = new DynamicParameters();
			paramerters.Add("@categoryName", categoryDto.CategoryName);
			paramerters.Add("@@categoryStatus", true);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}

		public async void DeleteCategory(int id)
		{
			string query = "Delete from Category where CategoryID=@categoryID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@categoryID", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}

		public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
		{
			string query = "Select * from Category";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultCategoryDto>(query);
				return values.ToList();
			}
		}

		public async Task<GetByIDCategoryDto> GetCategory(int id)
		{
			string query = "Select * from Category Where CategoryID=@categoryID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@categoryID", id);
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDto>(query, paramerters);
				return values;
			}
		}

		public async void UpdateCategory(UpdateCategoryDto categoryDto)
		{
			string query = "Update Category Set CategoryName=@categoryName,CategoryStatus=@categoryStatus where CategoryID=@categoryID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@categoryID", categoryDto.CategoryID);
			paramerters.Add("@categoryName", categoryDto.CategoryName);
			paramerters.Add("@categoryStatus", categoryDto.CategoryStatus);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}
	}
}
