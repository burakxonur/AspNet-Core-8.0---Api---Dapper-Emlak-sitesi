using RealEstate_Dapper_Api.Dto.WhoWeAreDetailDto;

namespace RealEstate_Dapper_Api.Repositories.WheWeAreRepositories
{
	public interface IWhoWeAreDetailRepository
	{
		Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
		void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
		void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
		void DeleteWhoWeAreDetail(int id);
		Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
	}
}
