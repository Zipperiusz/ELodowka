using AutoMapper;
using ELodowka.Api.Common.DTOs.Step;
using ELodowka.Data.Steps;

namespace ELodowka.Api.Common.Profiles;

public class StepProfile : Profile
{
    public StepProfile()
    {
        CreateMap<StepAddDto, Step>().ReverseMap();
    }
}