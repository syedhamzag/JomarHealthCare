using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;

public class ComplainRegistorDataModel
{
    public int Id { get; set; }
    public string Reference { get; set; }
    public DateTime? ComplainDate { get; set; }
    public DateTime? ComplainCloseDate { get; set; }
    public string TypeOfComplain { get; set; }
    public string PersonMakingComplain { get; set; }
    public DateTime? Ac_Date { get; set; }
    public DateTime? Ac_DateOfIncident { get; set; }
    public string OfficerName { get; set; }
    public string ListOfConcern { get; set; }
    public string ContentOfOfficer { get; set; }
    public DateTime? Pi_Date { get; set; }
    public string Pi_Status { get; set; }
    public string Pi_AnyOther { get; set; }
    public bool Pi_Notify { get; set; }
    public bool M_SpokenToStaff { get; set; }
    public bool M_ChecktheRecord { get; set; }
    public bool M_VisitedYou { get; set; }
    public bool M_OnetoOne { get; set; }
    public bool M_Whistle { get; set; }
    public bool M_Independent { get; set; }
    public string M_Other { get; set; }
    public DateTime? Ido_Date { get; set; }
    public string Ido_Status { get; set; }
    public string Ido_ListOfConcern { get; set; }
    public string Ido_AnyOtherInfo { get; set; }
    public string Ido_Attachment { get; set; }
    public bool Ido_Notify { get; set; }
    public string Ido_StaffResponse { get; set; }

    public DateTime? IoP_Date { get; set; }
    public string IoP_Status { get; set; }
    public string IoP_ListOfConcern { get; set; }
    public string IoP_AnyOtherInfo { get; set; }
    public string IoP_Attachment { get; set; }
    public bool IoP_Notify { get; set; }

    public DateTime? Ev_Date { get; set; }
    public string Ev_Decision { get; set; }
    public string Ev_Attachment { get; set; }
    public string Ev_Status { get; set; }
    public string Ev_Reference { get; set; }

    public string RC_CasuesWithIncident { get; set; }
    public string RC_Prevented { get; set; }
    public bool RC_Shared { get; set; }

    public DateTime? Clc_Date { get; set; }
    public string Clc_AnyInfo { get; set; }
    public string Clc_Attachment { get; set; }
    public string Clc_Status { get; set; }

    public DateTime? Cls_Date { get; set; }
    public string Cls_AnyInfo { get; set; }
    public string Cls_Attachment { get; set; }
    public string Cls_Status { get; set; }

    public string GeneralStatus { get; set; }
    public string ReasonOfPending { get; set; }
    public Guid? CompanyId { get; set; }
    public string ClosingStatment { get; set; }
    public List<ComplainRegistorClientDataModel> ComplainRegistorClients { get; set; }
    public List<ComplainRegistorStaffDataModel> ComplainRegistorStaff { get; set; }
}

public class ComplainRegistorClientDataModel
{
    public int Id { get; set; }
    public int ComplainRegistorId { get; set; }

    public Guid ClientId { get; set; }
}

public class ComplainRegistorStaffDataModel
{
    public int Id { get; set; }
    public int ComplainRegistorId { get; set; }

    public Guid StaffId { get; set; }
}