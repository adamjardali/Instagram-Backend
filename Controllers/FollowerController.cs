using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using Instagram.Dto;
using Instagram.Interfaces;
using Instagram.Models;

namespace Instagram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowerController : Controller
    {
        private readonly IFollowerRepository _followerRepository;
        private readonly IMapper _mapper;

        public FollowerController(IFollowerRepository followerRepository, IMapper mapper)
        {
            _followerRepository = followerRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Follower>))]
        public IActionResult GetFollowers(Guid Id)
        {
            var users = _mapper.Map<List<FollowerDto>>(_followerRepository.GetFollowers(Id));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(users);
        }

        // [HttpGet("{Id:guid}")]
        // [ProducesResponseType(200, Type = typeof(User))]
        // [ProducesResponseType(400)]
        // public IActionResult GetUserById(Guid Id)
        // {
        //     if (!_userRepository.UserExists(Id))
        //     {
        //         return NotFound();
        //     }
        //     var user = _mapper.Map<UserDto>(_userRepository.GetUser(Id));

        //     if(!ModelState.IsValid){
        //         return BadRequest(ModelState);
        //     }
        //     return Ok(user);
        //     // Add code here to return user
        // }

        // [HttpGet("{UserName}")]
        // [ProducesResponseType(200, Type = typeof(User))]
        // [ProducesResponseType(400)]
        // public IActionResult GetUserByName(string UserName)
        // {
        //     if (!_userRepository.UserExists(UserName))
        //     {
        //         return NotFound();
        //     }
        //     var user = _mapper.Map<UserDto>(_userRepository.GetUser(UserName));

        //     if(!ModelState.IsValid){
        //         return BadRequest(ModelState);
        //     }
        //     return Ok(user);
        // }

        // [HttpDelete("{Id:Guid}")]
        // [ProducesResponseType(400)]
        // [ProducesResponseType(204)]
        // [ProducesResponseType(404)]
        // public IActionResult DeleteUser(Guid Id)
        // {
        //     if(!_userRepository.UserExists(Id))
        //     {
        //         return NotFound();
        //     }
        //     var UserToDelete = _userRepository.GetUser(Id);

        //     if(!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     if(!_userRepository.DeleteUser(UserToDelete))
        //     {
        //         ModelState.AddModelError("","Something went wrong deleting User");
        //     }
        //     return NoContent();
        // }

        // [HttpPatch("{Id:Guid}")]
        // [ProducesResponseType(400)]
        // [ProducesResponseType(204)]
        // [ProducesResponseType(404)]
        // public IActionResult UpdateUser(Guid Id, [FromBody] UserUpdateDto UpdatedUser)
        // {
        //     if (UpdatedUser == null)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     if (Id != UpdatedUser.Id)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     if (!_userRepository.UserExists(Id))
        //     {
        //         return NotFound();
        //     }

        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     var user = _mapper.Map<User>(UpdatedUser);

        //     if (!_userRepository.UpdateUser(user))
        //     {
        //         ModelState.AddModelError("", "Something went wrong while updating the user");
        //         return StatusCode(500, ModelState);
        //     }

        //     return NoContent();
        // }

        // [HttpPost]
        // [ProducesResponseType(204)]
        // [ProducesResponseType(400)]
        // public IActionResult CreateUser([FromBody] UserCreateDto UserCreate)
        // {
        //     if(UserCreate == null)
        //     {
        //         return BadRequest(ModelState);
        //     }
            
        //     var users = _userRepository.GetUsers().Where(p => (p.UserName == UserCreate.UserName) || (p.Email == UserCreate.Email) || (p.CountryCode == UserCreate.CountryCode && p.PhoneNumber == UserCreate.PhoneNumber)).FirstOrDefault();

        //     if(users != null)
        //     {
        //         ModelState.AddModelError("","User already Exits");
        //         return StatusCode(422,ModelState);
        //     }

        //     if(!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     var UserMap = _mapper.Map<User>(UserCreate);

        //     if(!_userRepository.CreateUser(UserMap))
        //     {
        //         ModelState.AddModelError("", "Something went wrong while saving the user");
        //         return StatusCode(500,ModelState);   
        //     }

        //     return Ok("Successfully created");


        // }


       
    }
}
