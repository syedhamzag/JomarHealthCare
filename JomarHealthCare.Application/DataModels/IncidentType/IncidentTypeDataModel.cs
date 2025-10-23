using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.DataModels.IncidentType
{
    public class IncidentTypeDataModel
    {
        public int IncidentTypeId { get; set; }
        public string IncidentTypes { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
