using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dto.CategoryDto;
using RealEstate_Dapper_Api.Dto.WhoWeAreDetailDto;
using RealEstate_Dapper_Api.Repositories.CategoryRepositories;
using RealEstate_Dapper_Api.Repositories.WheWeAreRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WhoWeAreDetailController : ControllerBase
	{
		private readonly IWhoWeAreDetailRepository _whoWeAreRepository;

		public WhoWeAreDetailController(IWhoWeAreDetailRepository whoWeAreRepository)
		{
			_whoWeAreRepository = whoWeAreRepository;
		}

		[HttpGet]
		public async Task<IActionResult> WhoWeAreDetailsList()
		{
			var values = await _whoWeAreRepository.GetAllWhoWeAreDetailAsync();
			return Ok(values);
		}
		[HttpPost]
		public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
		{
			_whoWeAreRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDto);
			return Ok("Hakkımızda Başarılı Bir Şekilde Eklendi.");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
		{
			_whoWeAreRepository.DeleteWhoWeAreDetail(id);
			return Ok("Hakkımızda Başarılı Bir Şekilde Silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
		{
			_whoWeAreRepository.UpdateWhoWeAreDetail(updateWhoWeAreDetailDto);
			return Ok("Hakkımızda Başarılı Bir Şekilde Güncellendi");
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetWhoWeAreDetailDto(int id)
		{
			var value = await _whoWeAreRepository.GetWhoWeAreDetail(id);
			return Ok(value);
		}
	}
}
