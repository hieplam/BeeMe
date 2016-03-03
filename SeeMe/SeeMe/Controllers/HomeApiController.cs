using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;
using System.Web.Http;
using SeeMe.Utilitiis;

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

            return Directory.GetFiles(sourcePath).Select(Path.GetFileName).ToList().Shuffle();
        }
        /// <summary>
        /// This method used for download image, browser will open a popup to save image. Comment for later use
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        //public HttpResponseMessage Get(string fileName)
        //{
        //    var filePath = HostingEnvironment.MapPath($"~/sourcehinh/{fileName}");
        //    if (filePath == null)
        //    {
        //        return new HttpResponseMessage(HttpStatusCode.NotFound);
        //    }
        //    var fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read);
        //    var response = new HttpResponseMessage { Content = new StreamContent(fileStream) };

        //    response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = fileName };
        //    response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
        //    response.Content.Headers.ContentLength = new FileInfo(filePath).Length;

        //    return response;
        //}

        public HttpResponseMessage Get(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            var filePath = HostingEnvironment.MapPath($"~/sourcehinh/{fileName}");
            if (!File.Exists(filePath))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            using (var fileStream = new FileStream(filePath, FileMode.Open))
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
