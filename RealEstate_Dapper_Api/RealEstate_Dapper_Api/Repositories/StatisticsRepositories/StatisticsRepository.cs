using Dapper;
using RealEstate_Dapper_Api.Dto.EmployeeDto;
using RealEstate_Dapper_Api.Models.DapperContext;
using System.Text.RegularExpressions;

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
			string query = "Select Count(*) from Product where Title Like '%Ev%'";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			} 
		}

		public decimal AverageProductPriceByRent()
		{
			string query = "Select Avg(Price) from Product where Title Like 'Satılık'";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<decimal>(query);
				return values;
			}
		}

		public decimal AverageProductPriceBySale()
		{
			string query = "Select Avg(Price) from Product where Title Like 'Kiralık'";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<decimal>(query);
				return values;
			}
		}

		public int AvveraRoomCount()
		{
			string query = "Select Avg(RoomCount) from ProductDetails";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			}
		}

		public int CategoryCount()
		{
			string query = "Select Count(*) from Category";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			}
		}

		public string CategoryNameByMaxProductCount()
		{

			string query = "Select top(1) CategoryName,Count(*) From Product inner join Category On Product.ProductCategory = Category.CategoryID Group By CategoryName order by Count(*) Desc";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<string>(query);
				return values;
			}
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
