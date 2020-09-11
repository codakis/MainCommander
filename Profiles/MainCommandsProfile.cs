using AutoMapper;
using MainCommander.Dtos;
using MainCommander.Models;
namespace MainCommander.Profiles
{
    public class MainCommandsProfile : Profile
    {
        public MainCommandsProfile()
        {
            // source to target
            CreateMap<MainCommand, MainCommandReadDto>();
            CreateMap<MainCommandCreateDto, MainCommand>();
            CreateMap<MainCommandUpdateDto, MainCommand>();

        }
    }
}