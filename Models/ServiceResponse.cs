using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    // 服務的回應
    public class ServiceResponse<T>
    {
       // 回傳的資料
       // <T> : 可接受任何型別的資料(實際返回資料的型別)
       public T? Data { get; set; }

       // 執行是否成功
       public bool Success { get; set; } = true;

       // 訊息
       public string Message { get; set; } = string.Empty;
    }
}