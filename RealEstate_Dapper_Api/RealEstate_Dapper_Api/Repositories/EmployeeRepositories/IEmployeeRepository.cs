using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Dto.EmployeeDto;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
	public interface IEmployeeRepository
	{
		Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
		void CreateEmployee(CreateEmployeeDto createEmployeeDto);
		void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
		void DeleteEmployee(int id);
		Task<GetByIDEmployeeDto> GetEmployee(int id);
	}
}
