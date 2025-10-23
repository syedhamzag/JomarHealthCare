using MediatR;
using Microsoft.EntityFrameworkCore;
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
    internal class GetAllExpenseLogByCompanyQueryHandler : IRequestHandler<GetAllExpenselogByCompanyIdQuery, List<Expenselog>>
    {
        private readonly IExpenseLogRepository _repository;
        public GetAllExpenseLogByCompanyQueryHandler(IExpenseLogRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Expenselog>> Handle(GetAllExpenselogByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

            return entities.Select(entity => new Expenselog
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
            }).ToList();
        }
   
    }
}
