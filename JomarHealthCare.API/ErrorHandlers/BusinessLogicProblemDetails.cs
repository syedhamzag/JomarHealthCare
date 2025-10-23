namespace JomarHealthCare.API.ErrorHandlers
{
    public class BusinessLogicProblemDetails: GlobalProblemDetails
    {
        public int ErrorCode { get; set; }
        public string? Message { get; set; }
    }
}
