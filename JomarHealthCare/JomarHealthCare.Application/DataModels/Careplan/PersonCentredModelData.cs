namespace JomarHealthCare.Application.DataModels.Careplan;

public class PersonCentredModelData
{
    public int PersonCentredId { get; set; }
    public Guid ClientId { get; set; }
    public int Class { get; set; }
    public string ExpSupport { get; set; }
    public string Focus { get; set; }
}


public class GetPersonCentredModelData
{
    public int PersonCentredId { get; set; }
    public Guid ClientId { get; set; }
    public int Class { get; set; }
    public string ExpSupport { get; set; }
    public string Focus { get; set; }
}