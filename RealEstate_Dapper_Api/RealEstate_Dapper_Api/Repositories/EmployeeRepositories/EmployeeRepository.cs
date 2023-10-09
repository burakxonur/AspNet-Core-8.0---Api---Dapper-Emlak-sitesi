using Dapper;
using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Dto.EmployeeDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly Context _context;

		public EmployeeRepository(Context context)
		{
			_context = context;
		}
		public async void CreateEmployee(CreateEmployeeDto createEmployeeDto)
		{
			string query = "insert into Employee (EmployeeName,Title,Mail,PhoneNumber,ImageUrl,Status) values (@name,@title,@mail,@phoneNumber,@imageUrl,@status)";
			var paramerters = new DynamicParameters();
			paramerters.Add("@name", createEmployeeDto.EmployeeName);
			paramerters.Add("@title", createEmployeeDto.Title);
			paramerters.Add("@mail", createEmployeeDto.Mail);
			paramerters.Add("@phoneNumber", createEmployeeDto.PhoneNumber);
			paramerters.Add("@imageUrl", createEmployeeDto.ImageUrl);
			paramerters.Add("@status", true);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}

		public async void DeleteEmployee(int id)
		{
			string query = "Delete from Employee where EmployeeID=@EmployeeiD";
			var paramerters = new DynamicParameters();
			paramerters.Add("@EmployeeiD", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}

		public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
		{
			string query = "Select * from Employee";
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultEmployeeDto>(query);
				return values.ToList();
			}
		}

		public async Task<GetByIDEmployeeDto> GetEmployee(int id)
		{
			string query = "Select * from Employee Where EmployeeID=@EmployeeiD";
			var paramerters = new DynamicParameters();
			paramerters.Add("@EmployeeiD", id);
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDto>(query, paramerters);
				return values;
			}
		}

		public async void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
		{
			string query = "Update Employee Set EmployeeName=@name,Title=@title,Mail=@mail,PhoneNumber=@phoneNumber,ImageUrl=@imageUrl,Status=@status where EmployeeID=@EmployeeiD";
			var paramerters = new DynamicParameters();
			paramerters.Add("@EmployeeiD", updateEmployeeDto.EmployeeID);
			paramerters.Add("@name", updateEmployeeDto.EmployeeName);
			paramerters.Add("@title", updateEmployeeDto.Title);
			paramerters.Add("@mail", updateEmployeeDto.Mail);
			paramerters.Add("@phoneNumber", updateEmployeeDto.PhoneNumber);
			paramerters.Add("@imageUrl", updateEmployeeDto.ImageUrl);
			paramerters.Add("@status", updateEmployeeDto.Status);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}
	}
}
