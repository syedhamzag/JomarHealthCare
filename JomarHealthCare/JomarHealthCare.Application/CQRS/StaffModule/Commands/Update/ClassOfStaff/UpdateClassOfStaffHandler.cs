using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateClassOfStaffHandler : IRequestHandler<UpdateClassOfStaffCommand, bool>
    {
        private readonly IClassOfStaffRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public UpdateClassOfStaffHandler(IClassOfStaffRepository repo, IMapper mapper, IUnitOfWork uow)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<bool> Handle(UpdateClassOfStaffCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<ClassOfStaff>(request.DataModel);
            _repo.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}