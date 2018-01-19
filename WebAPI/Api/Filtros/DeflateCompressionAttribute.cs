using System.Net.Http;
using System.Web.Http.Filters;

namespace Api.Filtros
{
    public class DeflateCompressionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {   
            var content = actionExecutedContext.Response.Content;
            var bytes = (content == null)? null : content.ReadAsByteArrayAsync().Result;
            var alibbadContent = (bytes == null)? new byte[0] : CompressionHelp.DeflateByte(bytes);

            actionExecutedContext.Response.Content = new ByteArrayContent(alibbadContent);
            actionExecutedContext.Response.Content.Headers.Remove("Content-Type");
            actionExecutedContext.Response.Content.Headers.Add("Content-ecoding","deflate");
            actionExecutedContext.Response.Content.Headers.Add("Content-Type", "application/json");
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}