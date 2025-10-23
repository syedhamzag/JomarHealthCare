namespace JomarHealthCare.Domain.Entities
{
    public class Client : AuditableEntity, ICompanyEntity
    {
        public Client()
        {
            InvolvingParties = new HashSet<ClientInvolvingParty>();
            ClientCareDetails = new HashSet<ClientCareDetails>();
            RegulatoryContact = new HashSet<ClientRegulatoryContact>();
            ClientRota = new HashSet<ClientRota>();
            StaffBlackList = new HashSet<StaffBlackList>();
            ComplainRegister = new HashSet<ClientComplainRegister>();
            ClientNutrition = new HashSet<ClientNutrition>();
            ClientLogAudit = new HashSet<ClientLogAudit>();
            ClientMedAudit = new HashSet<ClientMedAudit>();
            ClientVoice = new HashSet<ClientVoice>();
            ClientMgtVisit = new HashSet<ClientMgtVisit>();
            ClientProgram = new HashSet<ClientProgram>();
            ClientServiceWatch = new HashSet<ClientServiceWatch>();
            StaffSpotCheck = new HashSet<StaffSpotCheck>();
            StaffAdlObs = new HashSet<StaffAdlObs>();
            StaffMedCompObs = new HashSet<StaffMedComp>();
            StaffKeyWorkerVoice = new HashSet<StaffKeyWorkerVoice>();
            StaffReference = new HashSet<StaffReference>();
            Enotice = new HashSet<Enotice>();
            Resources = new HashSet<Resources>();
            IncomingMeds = new HashSet<IncomingMeds>();
            ClientBloodPressure = new HashSet<ClientBloodPressure>();
            ClientFoodIntake = new HashSet<ClientFoodIntake>();
            ClientBowelMovement = new HashSet<ClientBowelMovement>();
            ClientPainChart = new HashSet<ClientPainChart>();
            ClientWoundCare = new HashSet<ClientWoundCare>();
            ClientSeizure = new HashSet<ClientSeizure>();
            ClientBloodCoagulationRecord = new HashSet<ClientBloodCoagulationRecord>();
            ClientEyeHealthMonitoring = new HashSet<ClientEyeHealthMonitoring>();
            ClientHeartRate = new HashSet<ClientHeartRate>();
            ClientPulseRate = new HashSet<ClientPulseRate>();
            ClientBodyTemp = new HashSet<ClientBodyTemp>();
            ClientOxygenLvl = new HashSet<ClientOxygenLvl>();
            ClientBMIChart = new HashSet<ClientBMIChart>();
            PersonalDetail = new HashSet<PersonalDetail>();
            CarePlanNutrition = new HashSet<CarePlanNutrition>();
            Balance = new HashSet<Balance>();
            PhysicalAbility = new HashSet<PhysicalAbility>();
            HistoryOfFall = new HashSet<HistoryOfFall>();
            HealthAndLiving = new HashSet<HealthAndLiving>();
            SpecialHealthCondition = new HashSet<SpecialHealthCondition>();
            SpecialHealthAndMedication = new HashSet<SpecialHealthAndMedication>();
            PersonalHygiene = new HashSet<PersonalHygiene>();
            InfectionControl = new HashSet<InfectionControl>();
            ManagingTasks = new HashSet<ManagingTasks>();
            Pets = new HashSet<Pets>();
            HospitalEntry = new HashSet<HospitalEntry>();
            HospitalExit = new HashSet<HospitalExit>();
            HomeRiskAssessment = new HashSet<HomeRiskAssessment>();
            DutyOnCall = new HashSet<DutyOnCall>();
            ClientDailyTask = new HashSet<ClientDailyTask>();
            StaffTeamLead = new HashSet<StaffTeamLead>();
            CreateShiftRoles = new HashSet<CreateShiftRoles>();
            BestInterestAssessment = new BestInterestAssessment();
            FilesAndRecord = new HashSet<FilesAndRecord>();
        }




        public Guid ClientId { get; set; }
        public Guid? CompanyId { get; set; }
        public string Pin { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public string PreferredName { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public string Hobbies { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string KeyworkerId { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public int? NumberOfCalls { get; set; }
        public int? AreaCodeId { get; set; }
        public int? TeritoryId { get; set; }
        public string ServiceType { get; set; }
        public string ProvisionVenue { get; set; }
        public string PostCode { get; set; }
        public decimal? Rate { get; set; }
        public string TeamLeaderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Telephone { get; set; }
        public string Language { get; set; }
        public string KeySafe { get; set; }
        public string ChoiceOfStaff { get; set; }
        public ClientStatusEnum StatusId { get; set; }
        public string Capacity { get; set; }
        public string ProviderReference { get; set; }
        public int? NumberOfStaff { get; set; }
        public string UniqueId { get; set; }
        public string ProfileImage { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ClientManagerId { get; set; }
        public string Denture { get; set; }
        public string Aid { get; set; }
        public double? LocationDistance { get; set; }
        public int? TimeMonitorLower { get; set; }
        public int? TimeMonitorHigher { get; set; }
        public string PracticalSupport { get; set; }
        public string CallGap { get; set; }
        public bool IsDelete { get; set; }
        public bool IsFacilityClient { get; set; }

        public Company Company { get; set; }
        public virtual ICollection<ClientInvolvingParty> InvolvingParties { get; set; }
        public virtual ICollection<ClientRegulatoryContact> RegulatoryContact { get; set; }
        public virtual ICollection<ClientRota> ClientRota { get; set; }
        public virtual ICollection<ClientCareDetails> ClientCareDetails { get; set; }
        public virtual ICollection<ClientMedication> ClientMedication { get; set; }
        public virtual ICollection<StaffBlackList> StaffBlackList { get; set; }
        public virtual ICollection<HospitalEntry> HospitalEntry { get; set; }
        public virtual ICollection<HospitalExit> HospitalExit { get; set; }
        public virtual ICollection<ClientDailyTask> ClientDailyTask { get; set; }
        public virtual ICollection<StaffTeamLead> StaffTeamLead { get; set; }
        public virtual BestInterestAssessment BestInterestAssessment { get; set; }
        public virtual ICollection<FilesAndRecord> FilesAndRecord { get; set; }
        public virtual ICollection<ClientCareObj> ClientCareObj { get; set; } = new HashSet<ClientCareObj>();
        public virtual ICollection<ClientHealthCondition> ClientHealthCondition { get; set; } = new HashSet<ClientHealthCondition>();
        public virtual ICollection<ClientHobbies> ClientHobbies { get; set; } = new HashSet<ClientHobbies>();
        public virtual ICollection<CuidiBuddy> CuidiBuddy { get; set; } = new HashSet<CuidiBuddy>();
        public virtual ICollection<IncidentReporting> IncidentReporting { get; set; } = new HashSet<IncidentReporting>();
        public virtual ICollection<AuditTrail> AuditTrail { get; set; } = new HashSet<AuditTrail>();
        public virtual ICollection<ClientTaskBoard> TaskBoard { get; set; } = new HashSet<ClientTaskBoard>();
        #region Client
        public virtual ICollection<ClientComplainRegister> ComplainRegister { get; set; }
        public virtual ICollection<ClientNutrition> ClientNutrition { get; set; }
        public virtual ICollection<ClientLogAudit> ClientLogAudit { get; set; }
        public virtual ICollection<ClientMedAudit> ClientMedAudit { get; set; }
        public virtual ICollection<ClientVoice> ClientVoice { get; set; }
        public virtual ICollection<ClientMgtVisit> ClientMgtVisit { get; set; }
        public virtual ICollection<ClientProgram> ClientProgram { get; set; }
        public virtual ICollection<ClientServiceWatch> ClientServiceWatch { get; set; }
        public virtual ICollection<CareReview> CareReview { get; set; }
        #endregion

        #region Staff
        public virtual ICollection<StaffSpotCheck> StaffSpotCheck { get; set; }
        public virtual ICollection<StaffAdlObs> StaffAdlObs { get; set; }
        public virtual ICollection<StaffMedComp> StaffMedCompObs { get; set; }
        public virtual ICollection<StaffKeyWorkerVoice> StaffKeyWorkerVoice { get; set; }
        public virtual ICollection<StaffReference> StaffReference { get; set; }
        #endregion

        #region Admin Forms
        public virtual ICollection<Enotice> Enotice { get; set; }
        public virtual ICollection<Resources> Resources { get; set; }
        public virtual ICollection<IncomingMeds> IncomingMeds { get; set; }
        #endregion

        #region Telehealth
        public virtual ICollection<ClientBloodPressure> ClientBloodPressure { get; set; }
        public virtual ICollection<ClientFoodIntake> ClientFoodIntake { get; set; }
        public virtual ICollection<ClientBowelMovement> ClientBowelMovement { get; set; }
        public virtual ICollection<ClientPainChart> ClientPainChart { get; set; }
        public virtual ICollection<ClientWoundCare> ClientWoundCare { get; set; }
        public virtual ICollection<ClientSeizure> ClientSeizure { get; set; }
        public virtual ICollection<ClientBloodCoagulationRecord> ClientBloodCoagulationRecord { get; set; }
        public virtual ICollection<ClientEyeHealthMonitoring> ClientEyeHealthMonitoring { get; set; }
        public virtual ICollection<ClientHeartRate> ClientHeartRate { get; set; }
        public virtual ICollection<ClientPulseRate> ClientPulseRate { get; set; }
        public virtual ICollection<ClientBodyTemp> ClientBodyTemp { get; set; }
        public virtual ICollection<ClientOxygenLvl> ClientOxygenLvl { get; set; }
        public virtual ICollection<ClientBMIChart> ClientBMIChart { get; set; }
        #endregion

        #region CarePlan
        public virtual ICollection<PersonalDetail> PersonalDetail { get; set; }
        public virtual ICollection<CarePlanNutrition> CarePlanNutrition { get; set; }
        public virtual ICollection<Balance> Balance { get; set; }
        public virtual ICollection<HistoryOfFall> HistoryOfFall { get; set; }
        public virtual ICollection<HealthAndLiving> HealthAndLiving { get; set; }
        public virtual ICollection<PhysicalAbility> PhysicalAbility { get; set; }
        public virtual ICollection<SpecialHealthCondition> SpecialHealthCondition { get; set; }
        public virtual ICollection<SpecialHealthAndMedication> SpecialHealthAndMedication { get; set; }
        public virtual ICollection<PersonalHygiene> PersonalHygiene { get; set; }
        public virtual ICollection<InfectionControl> InfectionControl { get; set; }
        public virtual ICollection<ManagingTasks> ManagingTasks { get; set; }
        public virtual ICollection<Pets> Pets { get; set; }
        public virtual ICollection<HomeRiskAssessment> HomeRiskAssessment { get; set; }
        public virtual ICollection<DutyOnCall> DutyOnCall { get; set; }
        #endregion

        #region Equipment and Assessment
        public virtual ICollection<EquipmentAssessment> EquipmentAssessment { get; set; }
        #endregion

        #region Body Map
        public virtual ICollection<BodyMap> BodyMap { get; set; }
        #endregion

        #region Client Matrix Audit
        public virtual ICollection<ClientMatrixAudit> ClientMatrixAudit { get; set; }
        #endregion

        public virtual ICollection<ComplainRegistorClients> ComplainRegistorClients { get; set; } = new HashSet<ComplainRegistorClients>();


        public virtual ICollection<ClientKeyWorkerVoice> ClientKeyWorkerVoice { get; set; } = new HashSet<ClientKeyWorkerVoice>();
        public virtual ICollection<CreateShiftRoles> CreateShiftRoles { get; set; }

        public virtual ICollection<ClientBillTo> ClientBillTo { get; set; }
        public virtual ICollection<ClientInvoiceRate> ClientInvoiceRate { get; set; }
        public virtual ICollection<PersonCentred> PersonCentred { get; set; }
        public ClientFacility ClientFacility { get; set; }

        public virtual AreaCode AreaCode { get; set; }

        public virtual Territory Territory { get; set; }

    }
}
