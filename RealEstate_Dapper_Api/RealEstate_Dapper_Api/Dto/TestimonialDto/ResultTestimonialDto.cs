namespace RealEstate_Dapper_Api.Dto.TestimonialDto
{
	public class ResultTestimonialDto
	{
        public int TestimonialID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool  Status { get; set; }
    }
}
