using System.ComponentModel.DataAnnotations;
using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos
 {

    public class CharacterCreateDTO {

        
        public string  Name { get; set; }

        public int HitPoints { get; set; } = 100;
        
        public int Strength { get; set; } = 10;
        
        public int Defense { get; set; } = 10;
        
        public int Intelligence { get; set; } = 10;
        
        public RPGClass Class { get; set; } = RPGClass.Knight;
        
    }
}