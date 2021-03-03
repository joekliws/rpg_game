

using System.ComponentModel.DataAnnotations;

namespace dotnet_rpg.Models
 {

    public class Character {

        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string  Name { get; set; } = "Frodo";

        [Required]
        public int HitPoints { get; set; } = 100;
        
        [Required]
        public int Strength { get; set; } = 10;
        
        [Required]
        public int Defense { get; set; } = 10;
        
        [Required]
        public int Intelligence { get; set; } = 10;
        
        [Required]
        public RPGClass Class { get; set; } = RPGClass.Knight;
        
    }
}