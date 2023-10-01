using Dapper;
using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Dto.WhoWeAreDetailDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.WheWeAreRepositories
{
	public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
	{
		private readonly Context _context;

		public WhoWeAreDetailRepository(Context context)
		{
			_context = context;
		}
		public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
		{
			string query = "insert into WhoWeAreDetail (Title,SubTitle,Description1,Description2) values (@title, @subTitle,@description1,@description2)";
			var paramerters = new DynamicParameters();
			paramerters.Add("@title", createWhoWeAreDetailDto.Title);
			paramerters.Add("@subTitle", createWhoWeAreDetailDto.SubTitle);
			paramerters.Add("@description1", createWhoWeAreDetailDto.Description1);
			paramerters.Add("@description2", createWhoWeAreDetailDto.Description2);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}

		public async void DeleteWhoWeAreDetail(int id)
		{
			string query = "Delete from WhoWeAreDetail where WhoWeAreDetailID=@WhowearedetailID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@WhowearedetailID", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}

		public async Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync()
		{
			string query = "Select * from WhoWeAreDetail";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultWhoWeAreDetailDto>(query);
				return values.ToList();
			}
		}

		public async Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id)
		{
			string query = "Select * from WhoWeAreDetail Where WhoWeAreDetailID=@WhowearedetailID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@WhowearedetailID", id);
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryFirstOrDefaultAsync<GetByIDWhoWeAreDetailDto>(query, paramerters);
				return values;
			}
		}

		public async void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
		{

			string query = "Update WhoWeAreDetail Set Title=@title,SubTitle=@subTitle,Description1=@description1,Description2=@description2 where WhoWeAreDetailID=@WhowearedetailID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@WhowearedetailID", updateWhoWeAreDetailDto.WhoWeAreDetailID);
			paramerters.Add("@title", updateWhoWeAreDetailDto.Title);
			paramerters.Add("@subTitle", updateWhoWeAreDetailDto.SubTitle);
			paramerters.Add("@description1", updateWhoWeAreDetailDto.Description1);
			paramerters.Add("@Description2", updateWhoWeAreDetailDto.Description2);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}
	}
}
