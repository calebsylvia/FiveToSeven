using FiveToSeven.Services.ReverseItAN;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;


    [ApiController]
    [Route("ReverseItAN")]
    public class ReverseItANController
    {
    private readonly IReverseItANService _reverseItANService;

    public ReverseItANController(IReverseItANService reverseItANService)
    {
        _reverseItANService = reverseItANService;
    }



        [HttpGet]
        [Route("ReverseItAN")]

        public string ReverseItAN(string input)
        {
            return _reverseItANService.ReverseItAN(input);
        }
    }
