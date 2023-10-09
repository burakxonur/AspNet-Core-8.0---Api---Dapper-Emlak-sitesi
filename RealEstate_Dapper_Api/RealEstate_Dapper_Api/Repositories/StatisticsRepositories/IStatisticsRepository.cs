using RealEstate_Dapper_Api.Dto.EmployeeDto;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
	public interface IStatisticsRepository
	{
		int CategoryCount();
		int ActiveCategoryCount();
		int PassiveCategoryCount();
		int ProductCount();
		int ApartmentCount();
		string EmployeeNameByMaxProductCount();
		string CategoryNameByMaxProductCount();
		decimal AverageProductByRent();
		decimal AverageProductBySale();
		string CityNameByMaxProductCont();
		int DiffrentCountCount();
		decimal LastProductPrice();
		string NewestBuildngYear();
		string OldestBuildngYear();
		int AvveraRoomCount();
		int ActiveEmployeeCount();

	}
}
