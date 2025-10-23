using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ComplainRegistorMap : IEntityTypeConfiguration<ComplainRegistor>
    {
        public void Configure(EntityTypeBuilder<ComplainRegistor> builder)
        {
            builder.ToTable("tbl_ComplainRegistor");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.Reference)
               .HasColumnName("Reference")
               .HasMaxLength(20);

            builder.Property(p => p.TypeOfComplain)
               .HasColumnName("TypeOfComplain")
               .HasMaxLength(512);

            builder.Property(p => p.PersonMakingComplain)
               .HasColumnName("PersonMakingComplain")
               .HasMaxLength(1024);

            builder.Property(p => p.Ac_Date)
               .HasColumnName("Ac_Date");

            builder.Property(p => p.Ac_DateOfIncident)
               .HasColumnName("Ac_DateOfIncident");

            builder.Property(p => p.OfficerName)
               .HasColumnName("OfficerName")
               .HasMaxLength(38);

            builder.Property(p => p.ListOfConcern)
               .HasColumnName("ListOfConcern")
               .HasMaxLength(1024);

            builder.Property(p => p.ContentOfOfficer)
               .HasColumnName("ContentOfOfficer")
               .HasMaxLength(256);


            builder.Property(p => p.Pi_Status)
               .HasColumnName("Pi_Status")
               .HasMaxLength(10);

            builder.Property(p => p.Pi_AnyOther)
               .HasColumnName("Pi_AnyOther")
               .HasMaxLength(512);

            builder.Property(p => p.M_Other)
               .HasColumnName("M_Other")
               .HasMaxLength(1024);

            builder.Property(p => p.Ido_Status)
               .HasColumnName("Ido_Status")
               .HasMaxLength(10);

            builder.Property(p => p.Ido_ListOfConcern)
               .HasColumnName("Ido_ListOfConcern")
               .HasMaxLength(1024);

            builder.Property(p => p.Ido_AnyOtherInfo)
               .HasColumnName("Ido_AnyOtherInfo")
               .HasMaxLength(1024);

            builder.Property(p => p.Ido_Attachment)
               .HasColumnName("Ido_Attachment")
               .HasMaxLength(1024);

            builder.Property(p => p.Ido_Notify)
               .HasColumnName("Ido_Notify");

            builder.Property(p => p.Ido_StaffResponse)
               .HasColumnName("Ido_StaffResponse")
               .HasMaxLength(1024);

            builder.Property(p => p.IoP_Status)
               .HasColumnName("IoP_Status")
               .HasMaxLength(10);

            builder.Property(p => p.IoP_ListOfConcern)
               .HasColumnName("IoP_ListOfConcern")
               .HasMaxLength(1024);

            builder.Property(p => p.IoP_AnyOtherInfo)
               .HasColumnName("IoP_AnyOtherInfo")
               .HasMaxLength(1024);

            builder.Property(p => p.IoP_Attachment)
               .HasColumnName("IoP_Attachment")
               .HasMaxLength(1024);


            builder.Property(p => p.Ev_Decision)
               .HasColumnName("Ev_Decision")
               .HasMaxLength(1024);

            builder.Property(p => p.Ev_Attachment)
               .HasColumnName("Ev_Attachment")
               .HasMaxLength(1024);

            builder.Property(p => p.Ev_Status)
               .HasColumnName("Ev_Status")
               .HasMaxLength(10);

            builder.Property(p => p.Ev_Reference)
               .HasColumnName("Ev_Reference")
               .HasMaxLength(20);

            builder.Property(p => p.RC_CasuesWithIncident)
               .HasColumnName("RC_CasuesWithIncident")
               .HasMaxLength(1024);

            builder.Property(p => p.RC_Prevented)
               .HasColumnName("RC_Prevented")
               .HasMaxLength(1024);


            builder.Property(p => p.Clc_AnyInfo)
               .HasColumnName("Clc_AnyInfo")
               .HasMaxLength(1024);

            builder.Property(p => p.Clc_Attachment)
               .HasColumnName("Clc_Attachment")
               .HasMaxLength(1024);

            builder.Property(p => p.Clc_Status)
               .HasColumnName("Clc_Status")
               .HasMaxLength(10);

            builder.Property(p => p.Cls_Date)
               .HasColumnName("Cls_Date");

            builder.Property(p => p.Cls_AnyInfo)
               .HasColumnName("Cls_AnyInfo")
               .HasMaxLength(1024);

            builder.Property(p => p.CompanyId)
               .HasColumnName("CompanyId")
               .HasMaxLength(38);


            builder.Property(p => p.Cls_Attachment)
               .HasColumnName("Cls_Attachment")
               .HasMaxLength(1024);

            builder.Property(p => p.Cls_Status)
               .HasColumnName("Cls_Status")
               .HasMaxLength(10);

            builder.Property(p => p.GeneralStatus)
              .HasColumnName("GeneralStatus")
              .HasMaxLength(10);

            builder.Property(p => p.ReasonOfPending)
               .HasColumnName("ReasonOfPending")
               .HasMaxLength(1024);

            builder.Property(p => p.ClosingStatment)
               .HasColumnName("ClosingStatment")
               .HasMaxLength(1024);
            #endregion
        }
    }
}
