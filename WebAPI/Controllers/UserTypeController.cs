using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserTypeController : ControllerBase
    {
        private readonly IRepository<UserType> _userTypeRepository;

        public UserTypeController(IRepository<UserType> userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
        }

        [HttpGet("get")]
        public IEnumerable<UserType> Get()
        {
            return _userTypeRepository.GetAll();
        }

        [HttpPost("add")]
        public ObjectResult Add(UserTypeDto userTypeDto)
        {
            _userTypeRepository.Add(new UserType(userTypeDto.Type));
            _userTypeRepository.SaveChanges();
            return Ok(userTypeDto);
        }

        [HttpPost("update")]
        public ObjectResult Update(UserTypeDto userTypeDto, int userTypeId)
        {
            var userTypeFromDb = _userTypeRepository.Find(u => u.Id == userTypeId).FirstOrDefault();
            if (userTypeFromDb == null)
            {
                return NotFound("User type doesn't exist.");
            }
            userTypeFromDb.Type = userTypeDto.Type;
            _userTypeRepository.Update(userTypeFromDb);
            _userTypeRepository.SaveChanges();
            return Ok(userTypeFromDb);
        }

        [HttpDelete("delete")]
        public ObjectResult Delete(int userTypeId)
        {
            var userTypeFromDb = _userTypeRepository.Find(u => u.Id == userTypeId).FirstOrDefault();
            if (userTypeFromDb != null)
            {
                _userTypeRepository.Remove(userTypeFromDb);
                _userTypeRepository.SaveChanges();
                return Ok("User type successfully deleted.");
            }
            else
                return NotFound("User type doesn't exist.");
        }
    }
}
