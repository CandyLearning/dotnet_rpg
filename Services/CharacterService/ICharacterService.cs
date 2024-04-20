using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        // 取得所有角色清單
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        // 依照指定的 Id 取得角色
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        // 新增角色
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        // 更新角色
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
    }

}