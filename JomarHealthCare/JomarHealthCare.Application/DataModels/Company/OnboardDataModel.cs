namespace JomarHealthCare.Application.DataModels.Company;

public class OnboardDataModel
{
    public string CompanyName { get; set; } = default!;
    public string EmailAddress { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string ConfirmPassword { get; set; } = default!;
}

public class CompanyDataModel
{
    public Guid CompanyId { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string Telephone { get; set; }
    public string CompanyCode { get; set; }
    public string EmailAddress { get; set; }
    public string CurrentCqcRating { get; set; }
    public string CityOfOperation { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
}


public class CompanyPorfileSettingDataModel
{
    public Guid CompanyId { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string Website { get; set; }
    public string LogoUrl { get; set; }
    public string Language { get; set; }
    public string PostCode { get; set; }
    public string Telephone { get; set; }
    public string Country { get; set; }
    public string Currency { get; set; }
    public string CurrentCqcRating { get; set; }
    public string CityOfOperation { get; set; }
    public string OurPhilosophy { get; set; }
    public string Purpose { get; set; }
    public string Complaint { get; set; }
    public string ContactUs { get; set; }
    public string PPE { get; set; }
}