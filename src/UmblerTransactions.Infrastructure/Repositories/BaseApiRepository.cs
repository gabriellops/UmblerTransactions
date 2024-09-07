using Newtonsoft.Json;
using System;
using System.Net.Http.Json;
using System.Text;
using System.Transactions;
using UmblerTransactions.Domain.Utils;

namespace UmblerTransactions.Infrastructure.Repositories
{
    public class BaseApiRepository
    {
        public readonly HttpClient _httpClient;

        public BaseApiRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "request");
            _httpClient.DefaultRequestHeaders.Add("MerchantId", ConstantUtil.MerchantId);
            _httpClient.DefaultRequestHeaders.Add("MerchantKey", ConstantUtil.MerchantKey);
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            var response = await _httpClient.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Erro na requisição (Status Code: {response.StatusCode}): {errorMessage}");
            }

            return await ReadAsync<T>(response);
        }


        public async Task<T> PostAsJsonAsync<T>(string uri, object objeto)
        {
            var response = await _httpClient.PostAsJsonAsync(uri, objeto);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Erro na requisição (Status Code: {response.StatusCode}): {errorMessage}");
            }

            return await ReadAsync<T>(response);
        }

        public async Task<T> PutAsync<T>(string uri)
        {
            var response = await _httpClient.PutAsync(uri, null);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Erro na requisição (Status Code: {response.StatusCode}): {errorMessage}");
            }

            return await ReadAsync<T>(response);
        }

        private async Task<T> ReadAsync<T>(HttpResponseMessage response)
        {
            var jsonObject = await response.Content.ReadAsStringAsync();

            var obj = JsonConvert.DeserializeObject<T>(jsonObject);

            return obj;
        }
    }
}
