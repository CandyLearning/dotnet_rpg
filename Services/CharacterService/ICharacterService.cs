using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        // 取得所有角色清單
        List<Character> GetAllCharacters();

        // 依照指定的 Id 取得角色
        Character GetCharacterById(int id);

        // 新增角色
        List<Character> AddCharacter(Character newCharacter);
    }

}