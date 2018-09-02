using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers    
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {   
        private readonly IUserRepository _userRepository;    

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/valuese
        [HttpGet]
        public IEnumerable<Users> GetAll() => _userRepository.GetAll();

        // GET api/values/
        [HttpGet("{id}", Name="GetUser")]
        public IActionResult Get(long id)
        {
            var user = _userRepository.Find(id);

            if(user == null)
            {
                return NotFound();
            }
            
            return new ObjectResult(user);
        }

        // POST api/values
        [HttpPost]
        public void ADD(string name, string email)
        {
            Users user = new Users();

            user.Name = name;
            user.Email = email;

            _userRepository.Add(user);            
        }
        
        // PUT api/values/
        [HttpPut]
        public void Put(Users user)
        {
            _userRepository.Update(user);
        }

       // DELETE api/values/
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _userRepository.Remove(id);
        }
    }
}
