using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyDogApp.API.Models;

namespace MyDogApp.API.Data
{
    public class DatingRepository : IDatingRepository
    {
        private readonly DataContext _db;
        public DatingRepository(DataContext db)
        {
            _db = db;

        }
        public void Add<T>(T entity) where T : class
        {
            _db.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _db.Remove(entity);
        }

        public async Task<User> GetUser(int id)
        {
            var user = await _db.Users.Include( p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _db.Users.Include( p => p.Photos).ToListAsync();

            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _db.SaveChangesAsync() > 0;
        }
    }
}