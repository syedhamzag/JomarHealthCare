namespace JomarHealthCare.Application.DataModels.Client.Rotering;

public class ClientRotaDataModel
{
    public int ClientRotaId { get; set; }
    public int ClientRotaTypeId { get; set; }
    public List<ClientRotaDayDataModel> ClientRotaDays { get; set; }
    public Guid? ClientId { get; set; }
}

public class ClientRotaDayDataModel
{
    public int ClientRotaDaysId { get; set; }
    public int ClientRotaId { get; set; }
    public int? RotaDayofWeekId { get; set; }
    public int? RotaId { get; set; }
    public string StartTime { get; set; }
    public string StopTime { get; set; }
    public string WeekDay { get; set; }
    public Guid? OtherStaff { get; set; }
    public List<ClientRotaTaskDataModel> ClientRotaTask { get; set; }
}


public class ClientRotaTaskDataModel
{
    public int ClientRotaTaskId { get; set; }
    public int RotaTaskId { get; set; }
    public int ClientRotaDaysId { get; set; }
}