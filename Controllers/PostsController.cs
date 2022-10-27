using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostsAPI.Models;

namespace PostsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        [Route("SayHello")]
        
        public string SayHello(SayHelloModel name)
        {
            return "Say Hello " + name.userName + name.lastName;
        }

        [HttpGet]
        [Route("Adding")]

        public string AddNumbers(AddingModel numbers){
            return "The sum of your numbers is: " + (numbers.number1 + numbers.number2);
        }
    }
}