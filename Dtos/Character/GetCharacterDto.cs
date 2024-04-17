using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Character
{
    // 返回角色資料DTO物件
    public class GetCharacterDto
    {
        public int Id { get; set; }
        // 建立默認的角色名稱
        public string Name { get; set; } = "Candy";
        // 生命值
        public int HitPoints { get; set; } = 100;
        // 強度
        public int Strength { get; set; } = 10;
        // 防禦
        public int Defense { get; set; } = 10;
        // 智力
        public int Intelligence { get; set; } = 10;
        // 角色
        public RpgEnum Class { get; set; }  = RpgEnum.Knight;
    }
}