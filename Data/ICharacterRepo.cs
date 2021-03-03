using System.Collections.Generic;
using dotnet_rpg.Models;

namespace dotnet_rpg.Data {
    public interface ICharacterRepo {

        bool SaveChanges();
        IEnumerable<Character> GetAllCharacters();
        Character GetCharacterById(int id);

        void CreateCharacter(Character cmd);
    }
}