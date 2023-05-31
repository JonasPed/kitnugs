using KitNugs.Services;
using Microsoft.AspNetCore.Mvc;

namespace KitNugs.Controllers
{
    public class HelloController : MyResourceControllerBase
    {
        private readonly ILogger<HelloController> _logger;
        private readonly IHelloService helloService;

        public HelloController(ILogger<HelloController> logger, IHelloService helloService)
        {
            _logger = logger;
            this.helloService = helloService;
        }

        public override Task<HelloResponse> Hello([FromQuery] string name)
        {
            var businessResult = helloService.BusinessLogic(name).Result;

            return Task.Run(() => new HelloResponse { 
                Now = businessResult.Now, 
                Name = businessResult.Name,
                From_configuration = businessResult.FromConfiguration
            } );
        }
    }
}
