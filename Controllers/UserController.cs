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
        public IActionResult GetById(int id)
        {
            var user = _userRepository.Find(id);

            if(user == null)
            {
                return NotFound();
            }
            
            return new ObjectResult(user);
        }    

        [HttpPost]
        public IActionResult Create([FromBody] Users user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _userRepository.Add(user);

            return CreatedAtRoute("GetUser", new { id = user.UserID}, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Users user)
        {
            if (user == null || user.UserID != id)
            {
                return BadRequest();
            }

            var _user = _userRepository.Find(id);

            if (_user == null)
            {
                return NotFound();
            }

            _user.Name = user.Name;
            _user.Email = user.Email;
            _user.Password = user.Password;

            _userRepository.Update(_user);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userRepository.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            _userRepository.Remove(id);

            return new NoContentResult();
        }
    }
}
