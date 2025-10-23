using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.InvoiceRate;
using JomarHealthCare.Application.DataModels.Client.Medication;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Medication;


internal class GetAllClientMedicationByClientQueryHandler : IRequestHandler<GetAllClientMedicationByClientQuery, List<GetClientMedicationDataModel>>
{
    private readonly IClientMedicationRepository _repository;
    private readonly IMapper _mapper;

    public GetAllClientMedicationByClientQueryHandler(IClientMedicationRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<GetClientMedicationDataModel>> Handle(GetAllClientMedicationByClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get()
            .Include(x => x.Medication)
            .Include(x => x.MedicationManufacturer)
            .Include(x => x.ClientMedicationDay)
                .ThenInclude(day => day.ClientMedicationPeriod)
            .Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();
        if (entities == null)
        {
            return new List<GetClientMedicationDataModel>();
        }

        return entities.Select(entity => new GetClientMedicationDataModel
        {
            ClientMedicationId = entity.ClientMedicationId,
            MedicationId = entity.MedicationId,
            MedicationManufacturerId = entity.MedicationManufacturerId,
            Medication = entity.Medication?.MedicationName,
            medicationManufacturer = entity.MedicationManufacturer?.Manufacturer,
            ExpiryDate = entity.ExpiryDate,
            Dossage = entity.Dossage,
            Frequency = entity.Frequency,
            Gap_Hour = entity.Gap_Hour,
            Route = entity.Route,
            StartDate = entity.StartDate,
            StopDate = entity.StopDate,
            Status = entity.Status,
            Remark = entity.Remark,
            PRNGuideline = entity.PRNGuideline,
            Means = entity.Means,
            Type = entity.Type,
            TimeCritical = entity.TimeCritical,
            MedicationRouteId = entity.MedicationRouteId,
            ClientMedImage = entity.ClientMedImage,
            IsPause = entity.IsPause,
            IsDelete = entity.IsDelete,
            ClientMedicationDay = entity.ClientMedicationDay != null
                ? entity.ClientMedicationDay.Select(day => new ClientMedicationDayDataModel
                {
                    ClientMedicationDayId = day.ClientMedicationDayId,
                    RotaDayofWeekId = day.RotaDayofWeekId,
                    ClientMedicationId = day.ClientMedicationId,
                    ClientMedicationPeriod = day.ClientMedicationPeriod != null
                        ? day.ClientMedicationPeriod.Select(period => new ClientMedicationPeriodDataModel
                        {
                            ClientMedicationPeriodId = period.ClientMedicationPeriodId,
                            ClientRotaTypeId = period.ClientRotaTypeId,
                            ClientMedicationDayId = period.ClientMedicationDayId,
                            RotaId = period.RotaId,
                            StartTime = period.StartTime,
                            StopTime = period.StopTime,
                            MedLiveTrackerDelete = period.MedLiveTrackerDelete
                        }).ToList()
                        : new List<ClientMedicationPeriodDataModel>()
                }).ToList()
                : new List<ClientMedicationDayDataModel>(),
            ClientId = entity.ClientId
        }).ToList();
    }
}
