using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReadExcelFile.Services;

namespace ReadExcelFile.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcelUploadController : Controller
    {
        private readonly IReadFile file;

        public ExcelUploadController(IReadFile file)
        {
            this.file = file;
        }
        [HttpPost]
        public async Task<IActionResult> UploadAsync(IFormFile files)
        {
            var trs = await file.Readxlfile(files);
           
                return Ok("filePath");
        }
       
    }
}
