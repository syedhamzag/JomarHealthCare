using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Configuration;
using JomarHealthCare.Application.HttpServices;

namespace JomarHealthCare.Infrastructure.Implementations
{
    public class AzureBlobStorageService : IAzureBlobStorageService
    {
        private readonly string _connectionString;
        private readonly string _containerName;
        private readonly BlobClientOptions _blobClientOptions;

        public AzureBlobStorageService(IConfiguration configuration)
        {
            _connectionString = configuration["AzureBlob:ConnectionString"]!;
            _containerName = configuration["AzureBlob:ContainerName"]!;

            // Initialize BlobClientOptions with the desired service version
            _blobClientOptions = new BlobClientOptions(BlobClientOptions.ServiceVersion.V2023_08_03);
        }

        public async Task<string> UploadFileAsync(bool isPublic, string filename, Stream fileStream, string contentType)
        {
            try
            {
                // Create container client with explicit version options
                var blobContainerClient = new BlobContainerClient(_connectionString, _containerName, _blobClientOptions);

                // Ensure the container exists
                await blobContainerClient.CreateIfNotExistsAsync();

                // Set container access level if public
                if (isPublic)
                {
                    await blobContainerClient.SetAccessPolicyAsync(PublicAccessType.Blob);
                }

                // Get blob client and upload file
                BlobClient blobClient = blobContainerClient.GetBlobClient(filename);
                fileStream.Position = 0;

                await blobClient.UploadAsync(
                    fileStream,
                    new BlobUploadOptions
                    {
                        HttpHeaders = new BlobHttpHeaders { ContentType = contentType }
                    });

                return blobClient.Uri.AbsoluteUri;
            }
            catch (Exception ex)
            {
                // Log or handle exception as needed
                throw new ApplicationException("Failed to upload to Azure Blob Storage", ex);
            }
        }
    }
}
