using AutoMapper;
using dotnet_rpg.Dtos;
using dotnet_rpg.Models;

namespace dotnet_rpg.Profiles {
    public class CharactersProfile : Profile {

        public CharactersProfile() {
            //source -> target
            CreateMap<Character, CharacterReadDTO>();
            CreateMap<CharacterCreateDTO, Character>();
        }

    }
}