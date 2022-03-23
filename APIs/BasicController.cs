using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;


namespace cms.APIs
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BasicController : ControllerBase
    {

        //
        private readonly ILogger<BasicController> _logger;
        private IWebHostEnvironment _env;

        public BasicController(IWebHostEnvironment en)
        {
            _env = en;
        }

        [HttpPost]
        public IActionResult UploadImage(List<IFormFile> files)
        {
            var filepath = "";
            foreach(IFormFile photo in Request.Form.Files)
            {
                string serverMapPath = Path.Combine(_env.WebRootPath, "images", photo.FileName);
                using(var stream = new FileStream(serverMapPath, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }

                filepath = "http://localhost:5086/" + "images/" + photo.FileName;
                Console.WriteLine("GOT A FILEEEEEE");
            }

            //
            return new JsonResult (new { url = filepath });
            //
        }
    }
}
