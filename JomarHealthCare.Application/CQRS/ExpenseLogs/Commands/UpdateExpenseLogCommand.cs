using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.ExpenseLogs.Commands
{
    public class UpdateExpenseLogCommand: IRequest<bool>
    {
        public int Id { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string ReferenceNo { get; set; }
        public Guid StaffId { get; set; }
        public string ItemOfPurchase { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal? AmountGivenAdvance { get; set; }
        public decimal? ReturnBalance { get; set; }
        public string ProofOfPurchase { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string LocationOfPurchase { get; set; }
        public string ReceiptNo { get; set; }
        public string WhoApproved { get; set; }
        public string Remarks { get; set; }
        public Guid ClientId { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
