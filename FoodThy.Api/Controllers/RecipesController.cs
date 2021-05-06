using FoodThy.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodThy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RecipesController : ControllerBase
    {
        //private readonly IUser _user;
        //public RecipesController(IUser user)
        //{
        //    _user = user;
        //}

        //[HttpGet(Name = nameof(GetReceip))]
        //public async Task<IActionResult> GetReceip()
        //{
            

        //    await _user.CreateUser();

        //    return Ok();
        //}
    }
}
