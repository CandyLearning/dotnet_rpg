using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        
        // base(options) : 調用 DbContext 的建構子，並傳遞 options 參數。這是初始化 DataContext 類的 Entity Framework 的標準方式，以確保所有必要的配置選項都被傳遞給 DbContext。
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        // DBSet 可以對資料表做操作，屬性名稱對應資料表名稱(名稱通常是複數)
        // DbSet<Character>: DbSet<T> 是一個泛型類型，提供了 CRUD（創建、讀取、更新、刪除）操作的功能，
        // 專門用來操作某個實體類型 T 的集合。在這裡，T 是 Character 類型。DbSet 使你能夠查詢表中的數據，以及將新記錄添加到表中。
        // 使用 Set<T>() 方法時，EF Core 會動態地為該實體類型提供一個 DbSet
        // 當訪問這個屬性時，它會調用 Set<Character>() 來獲得或創建一個 DbSet<Character> 的實例
        public DbSet<Character> Characters => Set<Character>();
    }
}