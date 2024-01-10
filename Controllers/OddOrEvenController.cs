using FiveToSeven.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;


    [ApiController]
    [Route("OddOrEven")]
    public class OddOrEvenController
    {
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("OddOrEven")]

        public string OddOrEven(int num){
            return _oddOrEvenService.OddOrEven(num);
        }

    }
