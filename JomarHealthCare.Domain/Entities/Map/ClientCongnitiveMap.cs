using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JomarHealthCare.Domain.Entities.Map
{
    public class ClientCongnitiveMap : IEntityTypeConfiguration<ClientCongnitive>
    {
        public void Configure(EntityTypeBuilder<ClientCongnitive> builder)
        {
            builder.ToTable("tbl_ClientCongnitive");
            builder.HasKey(k => k.Id);

            #region Properties
            builder.Property(p => p.ClientId)
                   .HasColumnName("ClientId")
                   .HasMaxLength(38);

            builder.Property(p => p.AbilityStatus)
              .HasColumnName("AbilityStatus")
              .HasMaxLength(20);

            builder.Property(p => p.UserGetMissing)
             .HasColumnName("UserGetMissing");

            builder.Property(p => p.RiskLevel)
             .HasColumnName("RiskLevel")
             .HasMaxLength(10);

            builder.Property(p => p.LocationOfMissingPersonFound)
             .HasColumnName("LocationOfMissingPersonFound")
             .HasMaxLength(2048);

            builder.Property(p => p.RequireOrCondition)
             .HasColumnName("RequireOrCondition")
             .HasMaxLength(1024);

            builder.Property(p => p.PossibleTriggerToLeadClient)
             .HasColumnName("PossibleTriggerToLeadClient")
             .HasMaxLength(2048);

            builder.Property(p => p.DuesServices)
             .HasColumnName("DuesServices")
             .HasMaxLength(2048);

            builder.Property(p => p.StaffPrepare)
             .HasColumnName("StaffPrepare")
             .HasMaxLength(2048);

            builder.Property(p => p.StaffWhenUserIsMissing)
             .HasColumnName("StaffWhenUserIsMissing")
             .HasMaxLength(2048);

            builder.Property(p => p.StaffWhenUserIsFound)
             .HasColumnName("StaffWhenUserIsFound")
             .HasMaxLength(2048);

            builder.Property(p => p.DuringTransfer)
             .HasColumnName("DuringTransfer")
             .HasMaxLength(2048);

            builder.Property(p => p.DuringTransfer)
             .HasColumnName("DuringTransfer")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenEating)
             .HasColumnName("WhenEating")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenWalking)
             .HasColumnName("WhenWalking")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenSleeping)
             .HasColumnName("WhenSleeping")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenMedicating)
             .HasColumnName("WhenMedicating")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenBathing)
             .HasColumnName("WhenBathing")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenCleaning)
             .HasColumnName("WhenCleaning")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenShopping)
             .HasColumnName("WhenShopping")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenBookAppointment)
             .HasColumnName("WhenBookAppointment")
             .HasMaxLength(2048);

            builder.Property(p => p.WhenCommunication)
             .HasColumnName("WhenCommunication")
             .HasMaxLength(2048);

            builder.Property(p => p.GeneralSkinCondition)
            .HasColumnName("GeneralSkinCondition")
            .HasMaxLength(2048);

            builder.Property(p => p.SkinInspection)
            .HasColumnName("SkinInspection")
            .HasMaxLength(2048);

            builder.Property(p => p.SUBeChecked)
            .HasColumnName("SUBeChecked")
            .HasMaxLength(2048);

            builder.Property(p => p.PossibleBreakDown)
            .HasColumnName("PossibleBreakDown")
            .HasMaxLength(2048);

            builder.Property(p => p.ProtectionOrBreakdown)
            .HasColumnName("ProtectionOrBreakdown")
            .HasMaxLength(2048);

            builder.Property(p => p.PresureRelievingDevices)
            .HasColumnName("PresureRelievingDevices")
            .HasMaxLength(2048);

            builder.Property(p => p.TypeOfDeviceAvailable)
            .HasColumnName("TypeOfDeviceAvailable")
            .HasMaxLength(2048);

            builder.Property(p => p.StaffUseTheDevice)
            .HasColumnName("StaffUseTheDevice")
            .HasMaxLength(2048);

            builder.Property(p => p.SUawareSkinCare)
            .HasColumnName("SUawareSkinCare")
            .HasMaxLength(2048);

            builder.Property(p => p.BeforeSkinIntegrity)
            .HasColumnName("BeforeSkinIntegrity")
            .HasMaxLength(2048);

            builder.Property(p => p.AfterSkinIntegrity)
            .HasColumnName("AfterSkinIntegrity")
            .HasMaxLength(2048);

            builder.Property(p => p.WoundCommunicating)
            .HasColumnName("WoundCommunicating")
            .HasMaxLength(2048);

            builder.Property(p => p.WoundStage)
            .HasColumnName("WoundStage")
            .HasMaxLength(2048);

            builder.Property(p => p.WoundType)
            .HasColumnName("WoundType")
            .HasMaxLength(2048);

            builder.Property(p => p.RisktoSU)
            .HasColumnName("RisktoSU")
            .HasMaxLength(2048);

            builder.Property(p => p.RisktoStaff)
            .HasColumnName("RisktoStaff")
            .HasMaxLength(2048);

            builder.Property(p => p.Esclation)
            .HasColumnName("Esclation")
            .HasMaxLength(200);


            builder.Property(p => p.BreathingManage)
            .HasColumnName("BreathingManage")
            .HasMaxLength(2048);

            builder.Property(p => p.UseCathata)
            .HasColumnName("UseCathata")
            .HasMaxLength(2048);

            builder.Property(p => p.ControlOfCathata)
            .HasColumnName("ControlOfCathata")
            .HasMaxLength(2048);

            builder.Property(p => p.ChangeCathata)
            .HasColumnName("ChangeCathata")
            .HasMaxLength(2048);

            builder.Property(p => p.SupplyOFCathata)
            .HasColumnName("SupplyOFCathata")
            .HasMaxLength(2048);

            builder.Property(p => p.CathataConnected)
            .HasColumnName("CathataConnected")
            .HasMaxLength(2048);

            builder.Property(p => p.CathataRecylced)
            .HasColumnName("CathataRecylced")
            .HasMaxLength(2048);

            builder.Property(p => p.DurationOfUse)
            .HasColumnName("DurationOfUse")
            .HasMaxLength(2048);

            builder.Property(p => p.CathataPosition)
            .HasColumnName("CathataPosition")
            .HasMaxLength(2048);

            builder.Property(p => p.UTI)
            .HasColumnName("UTI")
            .HasMaxLength(2048);

            builder.Property(p => p.CathataEscalation)
            .HasColumnName("CathataEscalation")
            .HasMaxLength(200);

            builder.Property(p => p.Vision)
            .HasColumnName("Vision")
            .HasMaxLength(2048);

            builder.Property(p => p.Speech)
            .HasColumnName("Speech")
            .HasMaxLength(2048);

            builder.Property(p => p.Hearing)
            .HasColumnName("Hearing")
            .HasMaxLength(2048);

            builder.Property(p => p.AboutAppetit)
            .HasColumnName("AboutAppetit")
            .HasMaxLength(2048);

            builder.Property(p => p.AboutSwallow)
            .HasColumnName("AboutSwallow")
            .HasMaxLength(2048);


            builder.Property(p => p.Rubbishstorage)
            .HasColumnName("Rubbishstorage")
            .HasMaxLength(2048);

            builder.Property(p => p.RiskRubbishstorage)
            .HasColumnName("RiskRubbishstorage")
            .HasMaxLength(2048);


            builder.Property(p => p.PositionBedrail)
            .HasColumnName("PositionBedrail")
            .HasMaxLength(2048);

            builder.Property(p => p.AssociatedWithBedrail)
            .HasColumnName("AssociatedWithBedrail")
            .HasMaxLength(2048);

            builder.Property(p => p.BedrailRisk)
            .HasColumnName("BedrailRisk")
            .HasMaxLength(2048);

            builder.Property(p => p.BedrailEscalation)
            .HasColumnName("BedrailEscalation")
            .HasMaxLength(200);

            builder.Property(p => p.PositionRecliner)
            .HasColumnName("PositionRecliner")
            .HasMaxLength(2048);

            builder.Property(p => p.AssociatedWithRecliner)
            .HasColumnName("AssociatedWithRecliner")
            .HasMaxLength(2048);

            builder.Property(p => p.ReclinerRisk)
            .HasColumnName("ReclinerRisk")
            .HasMaxLength(2048);

            builder.Property(p => p.ReclinerEscalation)
            .HasColumnName("ReclinerEscalation")
            .HasMaxLength(200);
            #endregion
        }
    }
}
