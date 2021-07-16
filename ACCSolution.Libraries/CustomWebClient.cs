using System;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ACCSolution.Libraries
{
    public class CustomWebClient
    {
        private HttpClient _client;
        private HttpClientHandler _httpClientHandler;

        public CustomWebClient()
        {
            _client = new HttpClient();
        }


        public async Task<HttpResponseMessage> GetAsync(string url)
        {    
            var response = await _client.GetAsync(url);
            return response;
        }


        public void ConfigureHandler()
        {
            _httpClientHandler = new HttpClientHandler();
            _httpClientHandler.ServerCertificateCustomValidationCallback = CertificateValidation;
        }
        

        public bool CertificateValidation(HttpRequestMessage request, X509Certificate2 certificate, X509Chain certificateChain, SslPolicyErrors policy)
        {
            return true;
        }


    }
}
