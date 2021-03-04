using System.Collections.Generic;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services {
    public interface ICharacterService {

        bool SaveChanges();
        IEnumerable<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        void CreateCharacter(Character cmd);
        void DeleteCharacter(Character cmd);
        void UpdateCharacter(Character cmd);
    }
}