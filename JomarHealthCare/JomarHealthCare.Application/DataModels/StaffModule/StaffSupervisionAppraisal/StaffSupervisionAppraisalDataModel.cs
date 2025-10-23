using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffSupervisionAppraisalDataModel
    {
        public int StaffSupervisionAppraisalId { get; set; }
        public string Reference { get; set; }
        public Guid StaffId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? NextCheckDate { get; set; }
        public string Details { get; set; }
        public string StaffRating { get; set; }
        public string ProfessionalDevelopment { get; set; }
        public string StaffComplaints { get; set; }
        public string FiveStarRating { get; set; }
        public string StaffDevelopment { get; set; }
        public string StaffAbility { get; set; }
        public string NoAbilityToSupport { get; set; }
        public string CondourAndWhistleBlowing { get; set; }
        public string NoCondourAndWhistleBlowing { get; set; }
        public string StaffSupportAreas { get; set; }
        public string ActionRequired { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string URL { get; set; }
        public string Attachment { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
        public string Type { get; set; }
        public string Accomplishment { get; set; }

        public string Likemostaboutthisjob { get; set; }
        public string Topthreepriorities { get; set; }
        public string Managementhelped { get; set; }
        public string Companyvalue { get; set; }
        public string Goingforward { get; set; }
        public string Trainingdoyouwish { get; set; }
        public string Areyouhappyworking { get; set; }
        public string Wouldyourecommend { get; set; }
        public string Isthereanytraining { get; set; }
        public string PreventionofAbuseAndSafeguarding { get; set; }
        public string ArethereAnyChanges { get; set; }
        public string DoYouHaveAnyQuestions { get; set; }
        public string FeedbackFromManager { get; set; }
        public string BiggestAchievement { get; set; }
        public string YouContinueToDisplay { get; set; }
        public string WhatChallenges { get; set; }
        public string AreThereAnyChallenges { get; set; }
        public string WhatLearningAndDevelopment { get; set; }
        public string PromoteIndependence { get; set; }
        public string WantToAchieve { get; set; }
        public string CRBinfo { get; set; }
        public string Anyquestions { get; set; }
        public string FeedbackFromSupervisor { get; set; }
    }
}
