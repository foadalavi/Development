using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace School.Domain.Helper
{
    public class HttpHelper
    {
        public static HttpContent GetHttpContect(object data)
        {
            return new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, MediaTypeNames.Application.Json);
        }
    }
}
