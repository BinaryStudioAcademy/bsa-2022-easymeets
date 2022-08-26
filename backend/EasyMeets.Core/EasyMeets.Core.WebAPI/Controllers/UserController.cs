﻿using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using EasyMeets.Core.Common.DTO.UploadImage;
using EasyMeets.Core.Common.DTO.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("current")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userService.GetCurrentUserAsync();
            return Ok(user);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<UserDto>> CreateUserPreferences([FromBody] NewUserDto user)
        {
            return Ok(await _userService.CreateUserPreferences(user));
        }

        [HttpGet("check-email")]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> CheckUserExistingByEmail(string email)
        {
            return Ok(await _userService.CheckExistingUserByEmail(email));
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePreferences([FromBody] UserDto user)
        {
            var currentUser = await _userService.GetCurrentUserAsync();
            await _userService.UpdateUserPreferences(user, currentUser.Email);
            return Ok();
        }


        [HttpPut("uploadimage")]
        public async Task<ActionResult<ImagePathDto>> UploadImageAsync([FromForm] IFormFile file)
        {
            var imagePath = await _userService.UploadImageAsync(file);
            return Ok(imagePath);
        }

        [HttpPost("zoom/add")]
        public async Task<ActionResult> CreateZoomCredentials([FromBody]NewCredentialsRequestDto newCredentialsRequestDto)
        {
            await _userService.CreateZoomCredentials(newCredentialsRequestDto);
            return Ok();
        }
    }
}
