using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffHolidayHandler : IRequestHandler<UpdateStaffHolidayCommand, bool>
    {
        private readonly IStaffHolidayRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateStaffHolidayHandler(IStaffHolidayRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateStaffHolidayCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffHoliday>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}