﻿using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Models.DapperContext;
using Dapper;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly Context _context;

		public CategoryRepository(Context context)
		{
			_context = context;
		}

		public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
		{
			string query = "Select * from Category";
			using (var connection = _context.CreateConnection())
			{
				var values=await connection.QueryAsync<ResultCategoryDto>(query);
				return values.ToList();
			}
		}
	}
}
