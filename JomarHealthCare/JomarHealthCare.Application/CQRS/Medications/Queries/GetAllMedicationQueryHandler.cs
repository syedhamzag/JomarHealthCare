using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Medications.Queries
{
    public class GetAllMedicationQueryHandler : IRequestHandler<GetAllMedicationQuery, List<Medication?>>
    {
        private readonly IMedicationRepository _repository;
        public GetAllMedicationQueryHandler(IMedicationRepository medicationRepository)
        {
            _repository = medicationRepository;
        }
        public async Task<List<Medication>> Handle(GetAllMedicationQuery request, CancellationToken cancellationToken)
        {
            return await _repository.Get().ToListAsync(cancellationToken);
        }
    }
}
