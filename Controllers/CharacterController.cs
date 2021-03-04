using System.Collections.Generic;
using AutoMapper;
using dotnet_rpg.Services;
using dotnet_rpg.Dtos;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers {
 
 [ApiController]
 [Route("api/characters")]
 public class CharacterController : ControllerBase {
     
     private readonly ICharacterService _repository;
     private readonly IMapper _mapper;

     public CharacterController(ICharacterService repository, IMapper mapper) {
         _mapper = mapper;
         _repository = repository;

     }


     [HttpGet]
     public  ActionResult<IEnumerable<CharacterReadDTO>> GetAllCharacters() {
         var characters  =  _repository.GetAllCharacters();
         return Ok(_mapper.Map<IEnumerable<CharacterReadDTO>>(characters));

     }

     [HttpGet("{id}")]
     public   ActionResult<CharacterReadDTO> GetCharacterById(int id) {
         var character = _repository.GetCharacterById(id);
         if(character != null) {
         return Ok(_mapper.Map<CharacterReadDTO>(character));
         }

         return NotFound();

     }

     [HttpPost]
     public  ActionResult<CharacterReadDTO> CreateCharacter(CharacterCreateDTO characterCreateDTO)
     {
         var characterModel = _mapper.Map<Character>(characterCreateDTO);
         _repository.CreateCharacter(characterModel);
          _repository.SaveChanges();

         return Created("http://localhost:5000/characters",characterModel);
     }
     [HttpDelete("{id}")]
     public ActionResult<CharacterReadDTO> DeleteCharacter(int id) {
        var character = _repository.GetCharacterById(id);
        if(character == null)
        {
         return NotFound();
        }
        _repository.DeleteCharacter(character);
        _repository.SaveChanges();
         return NoContent();
     }

     [HttpPut("{id}")]
     public ActionResult<CharacterReadDTO> UpdateCharacter(int id, CharacterCreateDTO updatedCharacter) 
     {
          var character = _repository.GetCharacterById(id);
        if(character == null)
        {
         return NotFound();
        }
        _mapper.Map(updatedCharacter, character);
        _repository.UpdateCharacter(character);
        
        _repository.SaveChanges();
         return Ok(character);
     }
     
 }
}