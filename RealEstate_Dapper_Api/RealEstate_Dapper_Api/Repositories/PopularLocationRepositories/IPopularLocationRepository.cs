using RealEstate_Dapper_Api.Dto.PopularLocationDto;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
	public interface IPopularLocationRepository
	{
		Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
		
	}
}
