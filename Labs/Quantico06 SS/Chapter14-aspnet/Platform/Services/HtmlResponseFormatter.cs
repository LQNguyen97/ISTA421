using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Platform.Services
{
    public class HtmlResponseFormatter : IResponseFormatter
    {
        public async Task Format(HttpContext context, string content)
        {
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync($@"
 <!DOCTYPE html>
     <html lang=""en"">
     <head>
        <title>Response</title>
    </head>
     <body>
         <h2 style='color: #ffffff; background-color: #ff0000;'>Formatted Response</h2>
         <span>{content}</span>
     </body>
 </html>");
        }
    }
}