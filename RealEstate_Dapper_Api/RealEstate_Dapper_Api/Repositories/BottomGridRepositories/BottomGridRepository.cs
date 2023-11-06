using Dapper;
using RealEstate_Dapper_Api.Dto.BottomGridDto;
using RealEstate_Dapper_Api.Dto.ServiceDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }
        public async void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
			string query = "insert into BottomGrid (Icon,Title,Description) values (@icon,@title,@description)";
			var paramerters = new DynamicParameters();
			paramerters.Add("@icon", createBottomGridDto.Icon);
			paramerters.Add("@title", createBottomGridDto.Title);
			paramerters.Add("@description", createBottomGridDto.Description);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}
        public async void DeleteBottomGrid(int id)
        {
			string query = "Delete from BottomGrid where BottomGridID=@BottomgridID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@BottomgridID", id);
			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);
			}
		}
        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "Select * from BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }
        public async Task<GetBottomGridDto> GetBottomGrid(int id)
        {
			string query = "Select * from BottomGrid Where BottomGridID=@BottomgridID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@BottomgridID", id);
			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, paramerters);
				return values;
			}
		}
        public async void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
			string query = "Update BottomGrid Set Icon=@icon,Title=@title,Description=@description where BottomGridID=@BottomgridID";
			var paramerters = new DynamicParameters();
			paramerters.Add("@BottomgridID", updateBottomGridDto.BottomGridID);
			paramerters.Add("@icon", updateBottomGridDto.Icon);
			paramerters.Add("@title", updateBottomGridDto.Title);
			paramerters.Add("@description", updateBottomGridDto.Description);

			using (var connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, paramerters);

			}
		}
    }
}
