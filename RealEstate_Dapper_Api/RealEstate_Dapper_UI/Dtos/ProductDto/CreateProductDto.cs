﻿namespace RealEstate_Dapper_UI.Dtos.ProductDto
{
	public class CreateProductDto
	{
		public string title { get; set; }
		public decimal price { get; set; }
		public string city { get; set; }
		public string district { get; set; }
		public string categoryID { get; set; }
		public string CoverImage { get; set; }
		public string Type { get; set; }
		public string Adress { get; set; }
	}
}
