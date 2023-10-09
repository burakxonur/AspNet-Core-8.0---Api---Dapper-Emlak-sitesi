using Dapper;
using RealEstate_Dapper_Api.Dto.EmployeeDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
	public class StatisticsRepository : IStatisticsRepository
	{
		private readonly Context _context;

		public StatisticsRepository(Context context)
		{
			_context = context;
		}
		public int ActiveCategoryCount()
		{
			string query = "Select Count(*) from Category where CategoryStatus=1";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			}
		}

		public int ActiveEmployeeCount()
		{
			string query = "Select Count(*) from Employee where Status=1";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			}
		}

		public int ApartmentCount()
		{
			throw new NotImplementedException();
		}

		public decimal AverageProductByRent()
		{
			throw new NotImplementedException();
		}

		public decimal AverageProductBySale()
		{
			throw new NotImplementedException();
		}

		public int AvveraRoomCount()
		{
			throw new NotImplementedException();
		}

		public int CategoryCount()
		{
			throw new NotImplementedException();
		}

		public string CategoryNameByMaxProductCount()
		{
			throw new NotImplementedException();
		}

		public string CityNameByMaxProductCont()
		{
			throw new NotImplementedException();
		}

		public int DiffrentCountCount()
		{
			throw new NotImplementedException();
		}

		public string EmployeeNameByMaxProductCount()
		{
			throw new NotImplementedException();
		}

		public decimal LastProductPrice()
		{
			throw new NotImplementedException();
		}

		public string NewestBuildngYear()
		{
			throw new NotImplementedException();
		}

		public string OldestBuildngYear()
		{
			throw new NotImplementedException();
		}

		public int PassiveCategoryCount()
		{
			throw new NotImplementedException();
		}

		public int ProductCount()
		{
			throw new NotImplementedException();
		}
	}
}
