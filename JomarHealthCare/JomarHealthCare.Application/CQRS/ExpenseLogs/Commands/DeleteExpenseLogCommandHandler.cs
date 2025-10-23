using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.CompanyBanks.Commands;
using JomarHealthCare.Application.CQRS.PettyCashHeadings.Commands;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.ExpenseLogs.Commands
{
    internal class DeleteExpenseLogCommandHandler: IRequestHandler<DeleteExpenseLogCommand, bool>
    {
        private readonly IExpenseLogRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteExpenseLogCommandHandler(
            IUnitOfWork unitOfWork,
            IExpenseLogRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteExpenseLogCommand request, CancellationToken cancellationToken)
        {
            // Optional: Verify the record belongs to the user's company
            var expenselog = await _repository.GetByKeyAsync(request.Id, cancellationToken);

            if (expenselog == null)
            {
                return false;
            }

            _repository.Delete(expenselog);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    
    }
}
