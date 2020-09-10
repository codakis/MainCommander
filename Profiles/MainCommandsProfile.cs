using AutoMapper;
using MainCommander.Dtos;
using MainCommander.Models;
namespace MainCommander.Profiles
{
    public class MainCommandsProfile : Profile
    {
        public MainCommandsProfile()
        {
            CreateMap<MainCommand, MainCommandReadDto>();
        }
    }
}