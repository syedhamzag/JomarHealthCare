using Microsoft.AspNetCore.Http;

namespace JomarHealthCare.Application.HttpServices
{
    public interface IAzureBlobStorageService
    {
        Task<string> UploadFileAsync(bool isPublic, string filename, Stream fileStream, string contentType);
    }
}
