using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ServiceRepositories;

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
	}
}
