using CommonUtilities.Utility;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtilities.Extensions
{
    public static class HttpClientExtensions
    {
        public static async Task<BooleanResult<TResp>> PostKtAsync<TResp, TReq>(
            this HttpClient client, string url, TReq req)
        {
            var stringPayload = JsonConvert.SerializeObject(req);
            HttpContent httpContent = new StringContent(stringPayload, Encoding.UTF8,
                "application/json");
            HttpResponseMessage response;
            try
            {
                response = await client.PostAsync(url, httpContent).ConfigureAwait(true);
            }
            catch (Exception e)
            {
                return BooleanResult<TResp>.FailResult(e.GetFullMessage());
            }

            if (!response.IsSuccessStatusCode)
                return BooleanResult<TResp>.FailResult(response.ReasonPhrase);
            var responseStr = await response.Content.ReadAsStringAsync().ConfigureAwait(true);
            TResp resp = JsonConvert.DeserializeObject<TResp>(responseStr);
            return BooleanResult<TResp>.SuccessResult(resp);
        }

        public static BooleanResult<TResp> PostKt<TResp, TReq>(this HttpClient client,
            string url, TReq req)
        {
            var stringPayload = JsonConvert.SerializeObject(req);
            HttpContent httpContent = new StringContent(stringPayload, Encoding.UTF8,
                "application/json");
            HttpResponseMessage response;
            try
            {
                response = client.PostAsync(url, httpContent).GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                return BooleanResult<TResp>.FailResult(e.GetFullMessage());
            }

            if (!response.IsSuccessStatusCode)
                return BooleanResult<TResp>.FailResult(response.ReasonPhrase);
            var responseStr = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            TResp resp = JsonConvert.DeserializeObject<TResp>(responseStr);
            return BooleanResult<TResp>.SuccessResult(resp);
        }
    }
}