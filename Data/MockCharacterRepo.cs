using System.Collections.Generic;
using dotnet_rpg.Models;

namespace  dotnet_rpg.Data
{
    public class MockCharacterRepo : ICharacterRepo
    {
        public void CreateCharacter(Character cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Character> GetAllCharacters()
        {
            var characters = new List<Character> {
                new Character {Id=0},
                new Character {Id=1},
                new Character {Id=2},
                new Character {Id=3}

            };

            return characters;
        }

        public Character GetCharacterById(int id)
        {
           return new Character {Id=0};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}