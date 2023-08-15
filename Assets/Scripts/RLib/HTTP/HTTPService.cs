using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RLib.HTTP
{
    public class HTTPService
    {
        public async Task<string> PostJsonAsync(
	    HttpClient client, string requestJson, string uri) {
            using StringContent jsonContent = new(
		        requestJson,
                Encoding.UTF8,
		        "application/json");
            using var response = await client.PostAsync(uri, jsonContent);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
	    }
    }
}
