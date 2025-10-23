using MediatR;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.CompanyBanks.Queries
{
    internal class GetCompanyBankByIdQueryHandler : IRequestHandler<GetCompanyBankById, CompanyBank>
    {
        private readonly ICompanyBankRepository _repository;
        public GetCompanyBankByIdQueryHandler(ICompanyBankRepository repository)
        {
            _repository = repository;
        }
        public async Task<CompanyBank> Handle(GetCompanyBankById request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null)
            {
                throw new KeyNotFoundException("Not found");
            }
            return new CompanyBank
            {
                Id = entity.Id,
                BankName = entity.BankName,
                Title = entity.Title,
                AccountNo = entity.AccountNo,
                TransitNo = entity.TransitNo,
                InstitudionNo = entity.InstitudionNo,
                SortCode = entity.SortCode,
                IsUKBank = entity.IsUKBank,
                IsOperating = entity.IsOperating,
                CompanyId = entity.CompanyId
            };
        }
    }
}
