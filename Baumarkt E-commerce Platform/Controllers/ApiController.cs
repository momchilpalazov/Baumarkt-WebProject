using Microsoft.AspNetCore.Mvc;

namespace BaumarktSystem.Controllers
{
    public class ApiController : Controller
    {

        private readonly IHttpClientFactory clientFactory;


        public ApiController(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }



        [HttpGet]

        public async Task<IActionResult> SearchProduct()
        {
            var client = clientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://temu-com-shopping-api-realtime-api-scrapper-from-temu-com.p.rapidapi.com/search?keyword=tv"),
            };
            request.Headers.Add("X-RapidAPI-Key", "f2adbb0993msh9529924a0755463p1eb8f9jsne64f7382ffce");
            request.Headers.Add("X-RapidAPI-Host", "temu-com-shopping-api-realtime-api-scrapper-from-temu-com.p.rapidapi.com");

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                // Обработете данните и върнете ги към изгледа
                return View("Products", body);
            }


        }


        [HttpGet]

        public async Task<IActionResult> ProductDetails(string goodsId)
        {
            var client = clientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://temu-com-shopping-api-realtime-api-scrapper-from-temu-com.p.rapidapi.com/details?goodsId={goodsId}"),
            };
            request.Headers.Add("X-RapidAPI-Key", "f2adbb0993msh9529924a0755463p1eb8f9jsne64f7382ffce");
            request.Headers.Add("X-RapidAPI-Host", "temu-com-shopping-api-realtime-api-scrapper-from-temu-com.p.rapidapi.com");

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                // Обработете данните и върнете ги към изгледа
                return View("ProductDetails", body);
            }


        }






       
    }
}
