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
        
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            // 定義服務回傳物件
            var ServiceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            // 設定返回物件的 Data 屬性
            ServiceResponse.Data = characters;            
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            
            var ServiceResponse = new ServiceResponse<List<Character>>();
            ServiceResponse.Data = characters;
            return ServiceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var ServiceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            ServiceResponse.Data = character;
            return ServiceResponse;
        }
    }
}