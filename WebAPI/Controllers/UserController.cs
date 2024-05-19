using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _userRepository;

        public UserController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("get")]
        public Task<IEnumerable<User>> Get()
        {
            return _userRepository.GetAll(["Type","Events","Events.Type","Tickets"]);
        }

        [HttpPost("add")]
        public ObjectResult Add(UserDto userDto)
        {
            _userRepository.Add(new User(userDto.Name, userDto.Email, userDto.Password, userDto.Type));
            _userRepository.SaveChanges();
            return Ok(userDto);
        }

        [HttpPost("update")]
        public ObjectResult Update(UserDto userDto, Guid userId)
        {
            var userFromDb = _userRepository.Find(u => u.Id == userId).FirstOrDefault();
            if(userFromDb==null)
            {
                return NotFound("User doesn't exist.");
            }
            userFromDb.Name = userDto.Name;
            userFromDb.Email = userDto.Email;
            userFromDb.Password= userDto.Password;
            userFromDb.TypeId = userDto.Type;
            _userRepository.Update(userFromDb);
            _userRepository.SaveChanges();
            return Ok(userFromDb);
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(Guid userId)
        {
            var userFromDb = _userRepository.Find(u=>u.Id == userId).FirstOrDefault();
            if(userFromDb!=null)
            {
                _userRepository.Remove(userFromDb);
                _userRepository.SaveChanges();
                return Ok("User successfully deleted.");
            }
            else
            return NotFound("User doesn't exist.");
        }
    }
}
