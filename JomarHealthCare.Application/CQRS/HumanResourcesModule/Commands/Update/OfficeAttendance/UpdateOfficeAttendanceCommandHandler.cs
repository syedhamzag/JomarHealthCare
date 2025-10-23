using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class UpdateOfficeAttendanceCommandHandler : IRequestHandler<UpdateOfficeAttendanceCommand, bool>
    {
        private readonly IOfficeAttendanceRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateOfficeAttendanceCommandHandler(IOfficeAttendanceRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateOfficeAttendanceCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.Get(x => x.AttendanceId == request.DataModel.AttendanceId).FirstOrDefaultAsync();
            if (entity == null)
                throw new KeyNotFoundException($"OfficeAttendance with ID {request.DataModel.AttendanceId} not found.");

            _mapper.Map(request.DataModel, entity);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
