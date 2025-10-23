namespace JomarHealthCare.Application.Configs
{
    public class JwtOptions
    {
        public string? IssuerName { get; init; }
        public string? Audience { get; init; }
        public string? SecretKey { get; init; }
    }
}
