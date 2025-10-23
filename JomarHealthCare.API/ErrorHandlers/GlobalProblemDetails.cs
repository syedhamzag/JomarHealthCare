namespace JomarHealthCare.API.ErrorHandlers
{
    public class GlobalProblemDetails : ProblemDetails
    {
        public GlobalProblemDetails()
        {
            Errors = new();
        }
        public Dictionary<string, List<string>>? Errors { get; set; }
        public string? TraceIdentifier { get; set; }
        public string? Path { get; set; }
    }
}
