using System.Collections.Generic;
using System.Linq;
using WebAPI.Controllers.DBContext;
using WebAPI.Controllers.Models;

namespace WebAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDBContext _context;

        public UserRepository(UserDBContext context)
        {
            _context = context;
        }
        public void Add(Users user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }
        public Users Find(long id)
        {
            return _context.User.FirstOrDefault(c => c.UserID == id);
        }

        public IEnumerable<Users> GetAll()
        {
            return _context.User.ToList();         
        }

        public void Remove(long id)
        {
            var user = _context.User.Find(id);            
            _context.User.Remove(user);
            _context.SaveChanges();
        }

        public void Update(Users user)
        {
            _context.User.Update(user);
        }
    }
}