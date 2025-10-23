using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    internal class StaffPersonalInfoQueryHandler : IRequestHandler<StaffPersonalInfoQuery, IQueryable<StaffPersonalInfo>>
    {
        private readonly IStaffPersonalInfoRepository _repository;

        public StaffPersonalInfoQueryHandler(IStaffPersonalInfoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffPersonalInfo>> Handle(StaffPersonalInfoQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(key.ToString().Trim()))
            {
                var staff = _repository.Get(x => x.StaffPersonalInfoId.ToString() == key.ToString().Trim());
                staff.FirstOrDefault().ProfilePix = await ConvertImageUrlToBase64Async(staff.FirstOrDefault().ProfilePix);
                return staff;
            }
            return _repository.Get();
        }
        public static async Task<string> ConvertImageUrlToBase64Async(string imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
                imageUrl = "https://ecommerceacct.blob.core.windows.net/staffprofilepix/staffprofilepix_10/4/2023%201%3A23%3A19%20PM_123123";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(imageUrl);

                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Failed to download image. Status: {response.StatusCode}");

                var imageBytes = await response.Content.ReadAsByteArrayAsync();

                // Detect content type from response header
                var contentType = response.Content.Headers.ContentType?.MediaType ?? "image/jpeg";

                return $"data:{contentType};base64,{Convert.ToBase64String(imageBytes)}";
            }
        }
    }
}
