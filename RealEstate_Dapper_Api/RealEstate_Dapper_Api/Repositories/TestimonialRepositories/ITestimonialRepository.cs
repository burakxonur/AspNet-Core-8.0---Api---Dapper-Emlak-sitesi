using RealEstate_Dapper_Api.Dto.TestimonialDto;

namespace RealEstate_Dapper_Api.Repositories.TestimonialRepositories
{
	public interface ITestimonialRepository
	{
		Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
		
	}
}
