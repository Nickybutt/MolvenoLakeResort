using System.Web;

namespace MolvenoLakeResort
{
    public static class CookieHelper
    {
        public static HttpCookie HasCookie(this HttpRequestBase request, string cookie)
        {
            return request.Cookies[cookie] ??null;
        }

        public static string GetCookieValue(this HttpCookie cookie)
        {
            return HttpUtility.HtmlEncode(cookie.Value);

        }

        public static void SetCookieValue(this HttpResponseBase response, string cookie, string value)
        {
            response.Cookies[cookie].Value = value;
        }
    }
}
