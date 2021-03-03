using System.Collections.Generic;
using dotnet_rpg.Data;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers {
 
 [ApiController]
 [Route("api/characters")]
 public class CharacterController : ControllerBase {
     
     private readonly ICharacterRepo _repository;
     private readonly IMapper _mapper;

     public CharacterController(ICharacterRepo repository, IMapper mapper) {
         _mapper = mapper;
         _repository = repository;

     }


     [HttpGet]
     public ActionResult <IEnumerable<CharacterReadDTO>> GetAllCharacters() {
         var characters  = _repository.GetAllCharacters();
         return Ok(_mapper.Map<IEnumerable<CharacterReadDTO>>(characters));

     }

     [HttpGet("{id}")]
     public ActionResult <Character> GetCharacterById(int id) {
         var character = _repository.GetCharacterById(id);
         if(character != null) {
         return Ok(_mapper.Map<CharacterReadDTO>(character));
         }

         return NotFound();

     }

     [HttpPost]
     [route("api/character/new")]
     public ActionResult <CharacterReadDTO> CreateCharacter(CharacterCreateDTO characterCreateDTO)
     {
         var characterModel = _mapper.Map<Character>(characterCreateDTO);
         _repository.CreateCharacter(characterModel);
         _repository.SaveChanges();

         return Created()
     }
     
 }
}