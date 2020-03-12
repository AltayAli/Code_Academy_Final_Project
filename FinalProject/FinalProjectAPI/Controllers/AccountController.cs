using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectAPI.Data;
using FinalProjectAPI.Models;
using FinalProjectAPI.Models.Convertion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _manager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager,
                                    SignInManager<AppUser> signIn)
        {
            _manager = userManager;
            _signInManager = signIn; 

        }
        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = ToAppUser.FromRegisterModel(model);
                var CreateOpRequest =await _manager.CreateAsync(user, model.Password);
                if (CreateOpRequest.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                  return Ok("Operation OK!");
                }
                else
                {
                    return BadRequest("Error in sign in proccess");
                }
            }
            else
            {
                return BadRequest("Enter model is nov valid!!!");
            }
        }
    }
}