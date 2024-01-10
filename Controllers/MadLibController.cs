using FiveToSeven.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

    [ApiController]
    [Route("MadLib")]
    public class MadLibController : ControllerBase
    {
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }



        [HttpGet]
        [Route("MadLib/{userName}/{name}/{age}/{noun1}/{noun2}/{verb1}/{verb2}/{adjective}")]
        public string MadLib(string userName, string name, int age, string noun1, string noun2, string verb1, string verb2, string adjective){
            return _madLibService.MadLib(userName, name, age, noun1, noun2, verb1, verb2, adjective);
        }
    }
