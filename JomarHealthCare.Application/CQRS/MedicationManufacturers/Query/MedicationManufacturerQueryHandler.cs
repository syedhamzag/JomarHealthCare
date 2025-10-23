using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Query
{
    public class MedicationManufacturerQueryHandler : IRequestHandler<MedicationManufacturerQuery, List<MedicationManufacturer>>
    {
        private readonly IMedicationManufacturerRepository _repository;
        public MedicationManufacturerQueryHandler(IMedicationManufacturerRepository repository)
        {
            _repository = repository;                                                           
        }
        public async Task<List<MedicationManufacturer>> Handle(MedicationManufacturerQuery request, CancellationToken cancellationToken)
        {
            return await _repository.Get().ToListAsync(cancellationToken);
        }
    }
}
