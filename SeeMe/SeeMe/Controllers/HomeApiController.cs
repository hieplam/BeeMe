using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;
using System.Web.Http;

namespace SeeMe.Controllers
{
    public class HomeApiController : ApiController
    {
        public IEnumerable<string> Get()
        {
            var sourcePath = HostingEnvironment.MapPath("~/sourcehinh");
            
            if (!Directory.Exists(sourcePath))
            {
                Directory.CreateDirectory(sourcePath);
            }

            return Directory.GetFiles(sourcePath);
        }
        
        public HttpResponseMessage Get(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new InvalidDataException();
            }

            var filePath = HostingEnvironment.MapPath($"~/sourcehinh/{fileName}");
            if (!Directory.Exists(filePath))
            {
                throw new FileNotFoundException();
            }

            using (var fileStream = new FileStream(fileName, FileMode.Open))
            {
                var image = Image.FromStream(fileStream);
                var memoryStream = new MemoryStream();
                image.Save(memoryStream, ImageFormat.Jpeg);

                var result = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(memoryStream.ToArray())
                };
                result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");

                return result;
            }
        }
    }
}
