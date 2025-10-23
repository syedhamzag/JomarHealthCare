using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.HealthLiving;
internal class GetByClientHealthAndLivingQueryHandler : IRequestHandler<GetByClientHealtAndLivingQuery, HealthAndLivingDataModel>
{
    private readonly IClientHealthAndLivingRepository _repository;

    public GetByClientHealthAndLivingQueryHandler(IClientHealthAndLivingRepository repository)
    {
        _repository = repository;
    }

    public async Task<HealthAndLivingDataModel> Handle(GetByClientHealtAndLivingQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new HealthAndLivingDataModel();
        }
        return new HealthAndLivingDataModel
        {
            HLId = entity.HLId,
            BriefHealth = entity.BriefHealth,
            ObserveHealth = entity.ObserveHealth,
            WakeUp = entity.WakeUp,
            CareSupport = entity.CareSupport,
            MovingAndHandling = entity.MovingAndHandling,
            SupportToBed = entity.SupportToBed,
            DehydrationRisk = entity.DehydrationRisk,
            LifeStyle = entity.LifeStyle,
            PressureSore = entity.PressureSore,
            ContinenceIssue = entity.ContinenceIssue,
            ContinenceNeeds = entity.ContinenceNeeds,
            ContinenceSource = entity.ContinenceSource,
            ConstraintRequired = entity.ConstraintRequired,
            ConstraintDetails = entity.ConstraintDetails,
            ConstraintAttachment = entity.ConstraintAttachment,
            MeansOfComm = entity.MeansOfComm,
            Smoking = entity.Smoking,
            AbilityToRead = entity.AbilityToRead,
            TextFontSize = entity.TextFontSize,
            Email = entity.Email,
            FinanceManagement = entity.FinanceManagement,
            PostalService = entity.PostalService,
            LetterOpening = entity.LetterOpening,
            ShoppingRequired = entity.ShoppingRequired,
            SpecialCleaning = entity.SpecialCleaning,
            LaundaryRequired = entity.LaundaryRequired,
            VideoCallRequired = entity.VideoCallRequired,
            EatingWithStaff = entity.EatingWithStaff,
            AllowChats = entity.AllowChats,
            TeaChocolateCoffee = entity.TeaChocolateCoffee,
            NeighbourInvolment = entity.NeighbourInvolment,
            FamilyUpdate = entity.FamilyUpdate,
            AlcoholicDrink = entity.AlcoholicDrink,
            TVandMusic = entity.TVandMusic,
            SpecialCaution = entity.SpecialCaution,
            ClientId = entity.ClientId,
        };
    }
}
