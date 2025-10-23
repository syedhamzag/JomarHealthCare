using JomarHealthCare.Application.HttpServices;

namespace JomarHealthCare.API.Controllers.API.FileUpload
{
    [ApiController]
    [Route("api/v1/files")]
    public class FileUploadController : ControllerBase
    {
        private readonly IAzureBlobStorageService _blobStorageService;

        public FileUploadController(IAzureBlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null)
                return BadRequest("No file uploaded.");

            try
            {
                string filename = DateTime.Now + "_" + file.FileName;
                var Url = await _blobStorageService.UploadFileAsync(true, filename, file.OpenReadStream(), file.ContentType);

                return Ok(new
                {
                    file.FileName,
                    Url
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }

}