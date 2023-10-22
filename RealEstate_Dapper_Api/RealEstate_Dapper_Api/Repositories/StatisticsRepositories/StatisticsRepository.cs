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
			string query = "Select Avg(Price) From Product where Type='Satılık'";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<decimal>(query);
				return values;
			}
		}

		public decimal AverageProductPriceBySale()
		{
			string query = "Select Avg(Price) From Product where Type='Kiralik'";
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
			string query = "Select Top(1) City,COUNT(*) as 'ilan_Sayisi' from Product Group By City Order By ilan_Sayisi Desc";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<string>(query);
				return values;
			}
		}

		public int DiffrentCountCount()
		{
			string query = "Select COUNT(Distinct(City)) from Product";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			}
		}

		public string EmployeeNameByMaxProductCount()
		{
			string query = "Select EmployeeName,Count(*) 'product_cpunt' from Product Inner Join Employee \r\nOn\r\nProduct.EmployeeId=Employee.EmployeeID Group By EmployeeName Order by product_cpunt desc";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<string>(query);
				return values;
			}
		}

		public decimal LastProductPrice()
		{
			string query = "Select Top(1) Price from Product Order By ProductID Desc";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			}
		}

		public string NewestBuildngYear()
		{
			string query = "Select Top(1) BuildYear from ProductDetails order by BuildYear desc";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<string>(query);
				return values;
			}
		}

		public string OldestBuildngYear()
		{
			string query = "Select Top(1) BuildYear from ProductDetails order by BuildYear asc";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<string>(query);
				return values;
			}
		}

		public int PassiveCategoryCount()
		{
			string query = "Select count(*) from Category where CategoryStatus=0";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			}
		}

		public int ProductCount()
		{
			string query = "Select Count(*) from Product";
			using (var connection = _context.CreateConnection())
			{
				var values = connection.QueryFirstOrDefault<int>(query);
				return values;
			}
		}
	}
}
