using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.DataModels.WhisttleBlowers
{
    public class WhisttleBlowerDataModel
    {
        public int WhisttleBlowerId { get; set; }
        public string ClientName { get; set; }
        public string PersonReportingName { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string Happening { get; set; }
        public string IsThereWitness { get; set; }
        public string WitnessDetail { get; set; }
        public string LikeCalling { get; set; }
        public string PhoneNo { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public string CreatedBy { get; set; }
        public string ActionTaken { get; set; }
        public string CandourAction { get; set; }
        public string ReferenceNumber { get; set; }
        public string NameOfHandlingPerson { get; set; }
        public string NameOfHandlingPersonTel { get; set; }
        public string IncidentType { get; set; }
        public string CompanyId { get; set; }
    }
}
