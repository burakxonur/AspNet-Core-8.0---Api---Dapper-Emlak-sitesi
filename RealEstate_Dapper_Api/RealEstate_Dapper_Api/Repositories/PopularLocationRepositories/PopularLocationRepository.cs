using Dapper;
using RealEstate_Dapper_Api.Dto.BottomGridDto;
using RealEstate_Dapper_Api.Dto.PopularLocationDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
	public class PopularLocationRepository : IPopularLocationRepository
	{
		private readonly Context _context;

		public PopularLocationRepository(Context context)
		{
			_context = context;
		}
		public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
		{
			string query = "Select * from PopularLocation";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
				return values.ToList();
			}
		}
	}
}
