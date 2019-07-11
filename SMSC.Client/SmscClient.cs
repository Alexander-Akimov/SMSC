using SMSC.Domain.Objects;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SMSC.Client
{
    public class SmscClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        //public string BaseURL { get; }
        private Uri BaseURL { get; }
        public string Error { get; private set; }

        public SmscClient(string baseUrl)
        {
            if (baseUrl.Equals(string.Empty))
                throw new Exception("baseUrl can't be empty");

            BaseURL = new Uri(baseUrl);
            _httpClient = new HttpClient();
        }

        public async Task<PackageResponse> SendMessageAsync(PackageRequest packageRequest)
        {
            try
            {
                using (var res = await _httpClient.PostAsync<PackageRequest>(
                   BaseURL,
                   packageRequest,
                   new XmlMediaTypeFormatter { UseXmlSerializer = true }))
                using (HttpContent content = res.Content)
                {
                    var data = await content.ReadAsAsync<PackageResponse>(new[] {
                    new XmlMediaTypeFormatter { UseXmlSerializer = true } });

                    return data;
                }
            }
            catch (HttpRequestException ex)
            {
                Error = ex.Message;
            }
            catch (SocketException ex)
            {
                Error = ex.Message;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return null;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}