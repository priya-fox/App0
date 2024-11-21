using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using App0;


namespace App0
{
    public class DatabaseService
    {
        SQLiteAsyncConnection _connection;
        public DatabaseService()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Staff.db");
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<Staff>().Wait();
        }

        public async Task ClearDatabaseAsync()
        {
            await _connection.DeleteAllAsync<Staff>();
        }
        public async Task AddStaffAsync(Staff staff)
        {
            await _connection.InsertAsync(staff);
        }
        public async Task<List<Staff>> GetStaffAsync()
        {
            return await _connection.Table<Staff>().ToListAsync();
        }
        public async Task UpdateStaffAsync(Staff staff)
        {
            await _connection.UpdateAsync(staff);
        }
        public async Task DeleteStaffAsync(Staff staff)
        {
            await _connection.DeleteAsync(staff);
        }

    }
}
