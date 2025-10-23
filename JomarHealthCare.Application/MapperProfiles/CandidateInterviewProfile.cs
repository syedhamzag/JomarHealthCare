using AutoMapper;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class CandidateInterviewProfile : Profile
    {
        public CandidateInterviewProfile()
        {
            CreateMap<CandidateInterview, CandidateInterviewDataModel>().ReverseMap();
             CreateMap<InterviewQuestion, InterviewQuestionDataModel>().ReverseMap();
        }
    }
}