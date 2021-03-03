using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Data {
    public class CharacterService : ICharacterService {

        private readonly CharacterContext _context;
        public CharacterService(CharacterContext context) {
            _context = context;
        }

        public void CreateCharacter(Character cmd)
        {
           if(cmd == null) {
               throw new ArgumentNullException(nameof(cmd));
           }

           _context.Characters.Add(cmd);
        }

        public async Task<IEnumerable<Character>> GetAllCharacters()
        {
            return   _context.Characters.ToList();
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return _context.Characters.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }
    }
}