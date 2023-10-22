using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region Aktif-Kategori-Sayısı
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44347/api/Statistics/ActiveCategoryCount");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsonData;
            #endregion

            #region Aktif-Çalışan-Sayısı
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44347/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsonData2;
            #endregion

            #region Aktif-Apartman-Sayısı
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44347/api/Statistics/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.activeApartmenCount = jsonData3;
            #endregion

            #region Satılık-Apartmanların-Ortalama-Fiyatı
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44347/api/Statistics/AverageProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.Averagepriceofapartmentsforsale = jsonData4;
            #endregion

            #region Kiralık-Apartmanların-Ortalama-Fiyatı
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:44347/api/Statistics/AverageProductPriceBySale");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.AveragePriceofApartmentsforRent = jsonData5;
            #endregion

            #region Ortalama-Oda-Sayısı
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:44347/api/Statistics/AvveraRoomCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.AvgveraRoomCount = jsonData6;
            #endregion

            #region Kategori--Sayısı
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44347/api/Statistics/CategoryCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.CategoryyCount = jsonData7;
            #endregion

            #region EN-Fazla-Kategori-Sayısı
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:44347/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.CategoryNameByMaxxProductCount = jsonData7;
            #endregion

            #region En-Fazla-Şehir-Sayısı
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:44347/api/Statistics/CityNameByMaxProductCont");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.CityNameByMaxxProductCont = jsonData9;
            #endregion

            #region Kaç-Farklı-Şehir-Sayısı
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:44347/api/Statistics/DiffrentCountCount");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.DiffrentCountCount = jsonData10;
            #endregion

            #region Ürün-Bulunan-Personel
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:44347/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData11;
            #endregion

            #region Son-Ürün-Fiyatı
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:44347/api/Statistics/LastProductPrice");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.LastProductPrice = jsonData12;
            #endregion

            #region Yeni-Evlerin-Yapım-Yılı
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client13.GetAsync("https://localhost:44347/api/Statistics/NewestBuildngYear");
            var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.NewestBuildngYear = jsonData13;
            #endregion

            #region Eski-Evlerin-Yapım-Yılı
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client14.GetAsync("https://localhost:44347/api/Statistics/OldestBuildngYear");
            var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.OldestBuildngYear = jsonData14;
            #endregion

            #region Pasif-Kategorilerin-Sayısı
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client15.GetAsync("https://localhost:44347/api/Statistics/PassiveCategoryCount");
            var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.PassiveCategoryCount = jsonData15;
            #endregion

            #region Ürün Sayısı
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client16.GetAsync("https://localhost:44347/api/Statistics/ProductCount");
            var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData16;
            #endregion



            return View();
        }
    }
}
