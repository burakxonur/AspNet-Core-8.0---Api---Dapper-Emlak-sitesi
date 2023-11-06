using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ServiceRepositories;
using RealEstate_Dapper_Api.Dto.ServiceDto;

namespace RealEstate_Dapper_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServiceController : ControllerBase
	{
		private readonly IServiceRepository _serviceRepository;

		public ServiceController(IServiceRepository serviceRepository)
		{
			_serviceRepository = serviceRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetServiceList()
		{
			var value = await _serviceRepository.GetAlServiceAsync();
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateService(CreareServiceDto createServiceDto)
		{
			_serviceRepository.CreateService(createServiceDto);
			return Ok("Hizmet Başarılı Bir Şekilde Eklendi.");
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteService(int id)
		{
			_serviceRepository.DeleteService(id);
			return Ok("Hizmet Başarılı Bir Şekilde Silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
		{
			_serviceRepository.UpdateService(updateServiceDto);
			return Ok("Hizmet Başarılı Bir Şekilde Güncellendi");
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetServiceDto(int id)
		{
			var value = await _serviceRepository.GetService(id);
			return Ok(value);
		}
	}
}
