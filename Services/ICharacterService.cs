using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Data {
    public interface ICharacterService {

        bool SaveChanges();
        Task<IEnumerable<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);

        void CreateCharacter(Character cmd);
    }
}