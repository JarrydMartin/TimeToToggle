using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TimeToToggleCore.Untlies
{
    public static class Parse<T>
    {
        public static async Task<T> HttpResponse(HttpResponseMessage response)
        {
            var responseJSON = await response.Content.ReadAsStringAsync();
            return JsonTranslate<T>.FromJson(responseJSON);
        }
    }
}
