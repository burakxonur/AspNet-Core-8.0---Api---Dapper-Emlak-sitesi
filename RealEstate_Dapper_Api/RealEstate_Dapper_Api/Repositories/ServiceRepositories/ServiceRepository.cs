using Dapper;
using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Dto.ServiceDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepositories
{
	public class ServiceRepository : IServiceRepository
	{
		private readonly Context _context;
		public ServiceRepository(Context context)
		{
			_context = context;
		}
		public void CreateService(CreareServiceDto creareServiceDto)
		{
			throw new NotImplementedException();
		}

		public void DeleteService(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<ResultServiceDto>> GetAlServiceAsync()
		{
			string query = "Select * from Service";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultServiceDto>(query);
				return values.ToList();
			}
		}

		public Task<GetByIDServiceDto> GetService(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateService(UpdateServiceDto updateServiceDto)
		{
			throw new NotImplementedException();
		}
	}
}
