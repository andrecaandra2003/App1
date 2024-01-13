using App1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace App1.Services
{
    public class PacientiServices : IPacientiServices
    {
        private SQLiteAsyncConnection _dbConnection;

        public PacientiServices()
        {
            SetUpDb();
        }

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "pacienti.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<PacientiModels>();
            }
        }

        public async Task<bool> AddPacienti(PacientiModels pacient)
        {
            await _dbConnection.InsertAsync(pacient);
            return true;
        }

        public async Task<bool> DeletePacienti(PacientiModels pacient)
        {
            await _dbConnection.DeleteAsync(pacient);
            return true;
        }

        public async Task<List<PacientiModels>> GetPacientiList()
        {
            return await _dbConnection.Table<PacientiModels>().ToListAsync();
        }

        public async Task<bool> UpdatePacienti(PacientiModels pacient)
        {
            await _dbConnection.UpdateAsync(pacient);
            return true;
        }
    }
}
