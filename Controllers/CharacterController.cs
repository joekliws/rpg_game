using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using dotnet_rpg.Data;
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
     public  async Task<ActionResult<IEnumerable<CharacterReadDTO>>> GetAllCharacters() {
         var characters  = await _repository.GetAllCharacters();
         return Ok(_mapper.Map<IEnumerable<CharacterReadDTO>>(characters));

     }

     [HttpGet("{id}")]
     public async  Task<ActionResult<Character>> GetCharacterById(int id) {
         var character = await _repository.GetCharacterById(id);
         if(character != null) {
         return Ok(_mapper.Map<CharacterReadDTO>(character));
         }

         return NotFound();

     }

     [HttpPost]
     [Route("api/character/new")]
     public ActionResult <CharacterReadDTO> CreateCharacter(CharacterCreateDTO characterCreateDTO)
     {
         var characterModel = _mapper.Map<Character>(characterCreateDTO);
         _repository.CreateCharacter(characterModel);
         _repository.SaveChanges();

         return Created("new", characterModel);
     }
     
 }
}