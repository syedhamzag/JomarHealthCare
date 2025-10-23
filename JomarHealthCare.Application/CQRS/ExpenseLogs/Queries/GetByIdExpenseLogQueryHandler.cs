using MediatR;
using JomarHealthCare.Application.CQRS.ExpenseLogs.Queries;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.ExpenseLogs.Queries
{
    internal class GetByIdExpenseLogQueryHandler : IRequestHandler<GetExpenseLogById, Expenselog>
    {
        private readonly IExpenseLogRepository _repository;
        public GetByIdExpenseLogQueryHandler(IExpenseLogRepository repository)
        {
            _repository = repository;
        }
        public async Task<Expenselog> Handle(GetExpenseLogById request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null)
            {
                throw new KeyNotFoundException("Not found");
            }
            return new Expenselog
            {
                Id = entity.Id,
                ExpenseDate = entity.ExpenseDate,
                ReferenceNo = entity.ReferenceNo,
                StaffId = entity.StaffId,
                ItemOfPurchase = entity.ItemOfPurchase,
                Quantity = entity.Quantity,
                Price = entity.Price,
                AmountGivenAdvance = entity.AmountGivenAdvance,
                ReturnBalance = entity.ReturnBalance,
                ProofOfPurchase = entity.ProofOfPurchase,
                PurchaseDate = entity.PurchaseDate,
                LocationOfPurchase = entity.LocationOfPurchase,
                ReceiptNo = entity.ReceiptNo,
                WhoApproved = entity.WhoApproved,
                Remarks = entity.Remarks,
                ClientId = entity.ClientId,
                CompanyId = entity.CompanyId
            };
        }
    }
}
