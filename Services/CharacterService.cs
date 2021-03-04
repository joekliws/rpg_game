using System;
using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;
using dotnet_rpg.Data;
using dotnet_rpg.Dtos;

namespace dotnet_rpg.Services {
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

        public void DeleteCharacter(Character cmd)
        {
             if(cmd == null) {
               throw new ArgumentNullException(nameof(cmd));
           }
           _context.Characters.Remove(cmd);
        }

        public IEnumerable<Character> GetAllCharacters()
        {
            return _context.Characters ;
        }

        public Character GetCharacterById(int id)
        {
            return _context.Characters.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }

        public void UpdateCharacter(Character cmd)
        {
            //do nothing
        }
    }
}