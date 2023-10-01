using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Dto.ServiceDto;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepositories
{
	public interface IServiceRepository
	{
		Task<List<ResultServiceDto>> GetAlServiceAsync();
		void CreateService(CreareServiceDto creareServiceDto);
		void UpdateService(UpdateServiceDto updateServiceDto);
		void DeleteService(int id);
		Task<GetByIDServiceDto> GetService(int id);
	}
}
