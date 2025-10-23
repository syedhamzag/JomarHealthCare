using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffOneToOneDataModel
    {
        public int OneToOneId { get; set; }
        public string Reference { get; set; }
        public Guid StaffId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? NextCheckDate { get; set; }
        public string Purpose { get; set; }
        public string PreviousSupervision { get; set; }
        public string StaffImprovedInAreas { get; set; }
        public string CurrentEventArea { get; set; }
        public string StaffConclusion { get; set; }
        public string DecisionsReached { get; set; }
        public string ImprovementRecorded { get; set; }
        public string ActionRequired { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string URL { get; set; }
        public string Attachment { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
    }
}
