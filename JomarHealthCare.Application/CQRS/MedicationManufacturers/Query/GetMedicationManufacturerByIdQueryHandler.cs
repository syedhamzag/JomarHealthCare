using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.MedicationManufacturers.Query
{
    public class GetMedicationManufacturerByIdQueryHandler : IRequestHandler<GetMedicationManaufacturerByIdQuery, List<MedicationManufacturer?>>
    {
        private readonly IMedicationManufacturerRepository _repository;

        public GetMedicationManufacturerByIdQueryHandler(IMedicationManufacturerRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<MedicationManufacturer>> Handle(GetMedicationManaufacturerByIdQuery request, CancellationToken cancellationToken)
        {
            
            var entities = await _repository.Get().Where(x => x.MedicationManufacturerId == request.Id).ToListAsync();

            return entities.Select(entity => new MedicationManufacturer
            {
               MedicationManufacturerId  = entity.MedicationManufacturerId,
               Manufacturer = entity.Manufacturer,
            }).ToList();
        }
    }

}
