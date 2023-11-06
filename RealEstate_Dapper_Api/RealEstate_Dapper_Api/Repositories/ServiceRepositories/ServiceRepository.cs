using Dapper;
using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Dto.EmployeeDto;
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
		public async void CreateService(CreareServiceDto creareServiceDto)
		{
			string query = "insert into Service (ServiceName,ServiceStatus) values (@servicename,@serviceStatus)";
			var paramerters = new DynamicParameters();
			paramerters.Add("@servicename", creareServiceDto.ServiceName);
			paramerters.Add("@serviceStatus", true);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}

		public async void DeleteService(int id)
		{
			string query = "Delete from Service where ServiceID=@serviceID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@serviceID", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
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

		public async Task<GetByIDServiceDto> GetService(int id)
		{
			string query = "Select * from Service Where ServiceID=@serviceID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@serviceID", id);
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryFirstOrDefaultAsync<GetByIDServiceDto>(query, paramerters);
				return values;
			}
		}

		public async void UpdateService(UpdateServiceDto updateServiceDto)
		{
			string query = "Update Service Set ServiceName=@servicename,ServiceStatus=@serviceStatus where ServiceID=@ServiceID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@ServiceID", updateServiceDto.ServiceID);
			paramerters.Add("@servicename", updateServiceDto.ServiceName);
			paramerters.Add("@serviceStatus", updateServiceDto.ServiceStatus);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);

			}
		}
	}
}
