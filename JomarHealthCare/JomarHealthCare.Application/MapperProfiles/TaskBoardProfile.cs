using AutoMapper;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.MapperProfiles
{
    public class TaskBoardProfile : Profile
    {
        public TaskBoardProfile()
        {
            CreateMap<ClientTaskBoard, ClientTaskBoardDataModel>().ReverseMap();
            CreateMap<ClientTaskBoardAssignedTo, ClientTaskBoardAssignedToDataModel>().ReverseMap();
        }
    }
}