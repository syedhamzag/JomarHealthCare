namespace JomarHealthCare.Application.ResponseModels
{
    public class DefaultResponse<T>
    {
        public bool Status { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public T Data { get; set; }
    }
}