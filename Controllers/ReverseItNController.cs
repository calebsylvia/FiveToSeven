using FiveToSeven.Services.ReverseItN;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

    [ApiController]
    [Route("ReverseItN")]
    public class ReverseItNController
    {
    private readonly IReverseItNService _reverseItNService;

    public ReverseItNController(IReverseItNService reverseItNService)
    {
        _reverseItNService = reverseItNService;
    }


        [HttpGet]
        [Route("ReverseItN")]
        public string ReverseItN(string input)
        {
            return _reverseItNService.ReverseItN(input);
        }

    }
