global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        // 初始化角色清單
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character{Id = 1, Name = "小糖果"}
        };
        
        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            // 定義服務回傳物件
            var ServiceResponse = new ServiceResponse<List<GetCharacterDto>>();
            // 新增角色(Dto -> Model)
            var character = _mapper.Map<Character>(newCharacter);
            // 角色ID: 目前最大值+1
            character.Id = characters.Max(c => c.Id) + 1;
            characters.Add(character);
            // 設定返回物件的 Data 屬性
            ServiceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();            
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            
            var ServiceResponse = new ServiceResponse<List<GetCharacterDto>>();
            ServiceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<GetCharacterDto>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            ServiceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            return ServiceResponse;
        }
    }
}