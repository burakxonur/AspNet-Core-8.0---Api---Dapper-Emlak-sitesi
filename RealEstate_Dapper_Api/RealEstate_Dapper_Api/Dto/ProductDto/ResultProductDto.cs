namespace RealEstate_Dapper_Api.Dto.ProductDto
{
	public class ResultProductDto
	{
		public int ProductID { get; set; }
		public string Title { get; set; }
		public string Price { get; set; }
		public string City { get; set; }
		public string District { get; set; }
		public int ProductCategory { get; set; }
	}
}
