namespace JomarHealthCare.Domain.Entities
{
    public class CreditCard
    {
        public int Id { get; set; }
        public CreditCardEnum CardType { get; set; }
        public string OtherTypeName { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string PostalCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSignature { get; set; }
        public DateTime? SignatureDate { get; set; }
    }
}
