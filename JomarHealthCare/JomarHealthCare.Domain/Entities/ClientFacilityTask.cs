namespace JomarHealthCare.Domain.Entities;

public class ClientFacilityTask
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string BeforePerformingTask { get; set; }
    public string HowToTaskPerform { get; set; }
    public string RiskAssociated { get; set; }
    public string HowToMigitate { get; set; }
    public string WhatToDoAfterTaskCompleting { get; set; }
    public string Picture { get; set; }
    public string Video { get; set; }
    public int FacilityClientId { get; set; }

    public virtual ClientFacility ClientFacility
    {
        get; set;
    }
}
