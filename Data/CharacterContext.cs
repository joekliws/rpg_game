using dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data {

    public class CharacterContext : DbContext {

        public CharacterContext() {}
        public CharacterContext(DbContextOptions<CharacterContext> opt) : base(opt)
        {

        }

        public DbSet<Character> Characters {get; set;}

    }
}