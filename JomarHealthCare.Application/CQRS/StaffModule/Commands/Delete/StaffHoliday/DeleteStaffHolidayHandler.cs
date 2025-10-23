using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class DeleteStaffHolidayHandler : IRequestHandler<DeleteStaffHolidayCommand, bool>
    {
        private readonly IStaffHolidayRepository _repo;
        private readonly IUnitOfWork _uow;

        public DeleteStaffHolidayHandler(IStaffHolidayRepository repo, IUnitOfWork uow)
        {
            _repo = repo;
            _uow = uow;
        }

        public async Task<bool> Handle(DeleteStaffHolidayCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null) return false;

            _repo.Delete(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}