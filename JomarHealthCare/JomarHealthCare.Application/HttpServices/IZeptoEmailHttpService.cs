using JomarHealthCare.Application.RequestModels.ZohoEmail;
using JomarHealthCare.Application.ResponseModels.ZohoEmail;
using Refit;

namespace JomarHealthCare.Application.HttpServices
{
    public interface IZeptoEmailHttpService
    {
        [Post("/email")]
        public Task<ApiResponse<ZeptoSendEmailResponseModel>> SendEmailAsync([Body] ZeptoSendEmailRequestModel model);

        [Post("/email/template")]
        public Task<ApiResponse<ZeptoSendEmailResponseModel>> SendTemplatedEmailAsync([Body] ZeptoSendTemplatedEmailRequestModel model);
    }
}
