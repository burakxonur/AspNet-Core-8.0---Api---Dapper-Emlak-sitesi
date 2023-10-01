using RealEstate_Dapper_Api.Dto.BottomGridDto;
using RealEstate_Dapper_Api.Dto.ServiceDto;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        void DeleteBottomGrid(int id);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
