using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;
using App6.Models;
using App6;

namespace App6.Data
{
    public class ClothesDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<ClothesDatabase> Instance = new AsyncLazy<ClothesDatabase>(async () =>
        {
            var instance = new ClothesDatabase();
            CreateTableResult result = await Database.CreateTableAsync<Clothes>();
            return instance;
        });

        public ClothesDatabase()
        {
            Database = new SQLiteAsyncConnection(Constant.DatabasePath, Constant.Flags);
        }

        public Task<List<Clothes>> GetItemsAsync()
        {
            return Database.Table<Clothes>().ToListAsync();
        }

        public Task<List<Clothes>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<Clothes>("SELECT * FROM [Clothes] WHERE [Done] = 0");
        }

        public Task<Clothes> GetItemAsync(int id)
        {
            return Database.Table<Clothes>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Clothes item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Clothes item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
