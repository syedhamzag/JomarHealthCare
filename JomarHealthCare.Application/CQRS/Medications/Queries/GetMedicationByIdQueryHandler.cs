using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Medications.Queries
{
    public class GetMedicationByIdQueryHandler : IRequestHandler<GetMedicationByIdQuery, List<Medication?>>
    {
        private readonly IMedicationRepository _repository;
        public GetMedicationByIdQueryHandler(IMedicationRepository medicationRepository)
        {
            _repository = medicationRepository;
        }
        public async Task<List<Medication>> Handle(GetMedicationByIdQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().Where(x => x.MedicationId == request.Id).ToListAsync();

            return entities.Select(entity => new Medication
            {
                MedicationId = entity.MedicationId,
                MedicationName = entity.MedicationName,
                Strength = entity.Strength,
                Indication = entity.Indication,

            }).ToList();
        }
    }
}
