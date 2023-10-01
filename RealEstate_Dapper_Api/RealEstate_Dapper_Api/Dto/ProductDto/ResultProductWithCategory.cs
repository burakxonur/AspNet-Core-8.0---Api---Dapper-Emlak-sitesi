namespace RealEstate_Dapper_Api.Dto.ProductDto
{
	public class ResultProductWithCategory
	{
		public int ProductID { get; set; }
		public string Title { get; set; }
		public string Price { get; set; }
		public string City { get; set; }
		public string District { get; set; }
		public string CategoryName { get; set; }
		public string CoverImage { get; set; }
		public string type { get; set; }
		public string Adress { get; set; }
	}
}
