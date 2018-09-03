using WebAPI.Controllers.Models;
using System.Collections.Generic;

namespace WebAPI.Repository
{
    public interface IUserRepository
    {
        IEnumerable<Users> GetAll();         
         void Add(Users user);         
         void Update(Users id);
         void Remove(int id);
         Users Find(int id);         
    }
}