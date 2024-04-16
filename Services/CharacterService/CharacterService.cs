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
        
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            if (character is not null)
            {
                return character;
            }
            else
            {
                throw new Exception("角色找不到!");
            }
        }
    }
}