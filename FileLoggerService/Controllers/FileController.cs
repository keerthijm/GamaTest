using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileLoggerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService fileService;

        public FileController(IFileService _fileService)        {
           
            fileService = _fileService;
        }
        // GET: api/<HomeController>
        [HttpGet]
        public string Get()
        {
            return fileService.GetFileContent();
        }
    

        // POST api/<HomeController>
        [HttpPost]
        public void Post([Bind("Id,Date,Description")] FileContent fileContent)
        {
            if (ModelState.IsValid)
            {
                fileService.Save(fileContent);
            }
        }
    }
}
