using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    // 在 SwaggerUI 的 Schema 可以顯示出 Enum 代表的字串
    [JsonConverter(typeof(JsonStringEnumConverter))]
    // 角色類型
    public enum RpgEnum
    {
       // 騎士
       Knight = 1,
       // 法師
       Mage = 2,
       // 牧師
       Cleric = 3 
    }
}