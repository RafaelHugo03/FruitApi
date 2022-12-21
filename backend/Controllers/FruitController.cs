using Microsoft.AspNetCore.Mvc;
using src.Entities;
using src.Repositories.Contracts;
using src.ViewModels;

namespace src.Controllers
{
    [ApiController]
    [Route("fruits")]
    public class FruitController : ControllerBase
    {
        private readonly IFruitRepository fruitRepository;

        public FruitController(IFruitRepository fruitRepository)
        {
            this.fruitRepository = fruitRepository;
        }

        [HttpGet("get-fruits")]
        public IActionResult GetAllFruits()
        {
            try
            {
                var fruits = fruitRepository.GetAllFruits();
                return Ok(new ResultViewModel(true, "", fruits));
            }
            catch(Exception e)
            {
                return BadRequest(new ResultViewModel(false, $"Erro ao buscar frutas: {e.Message}", null));
            }
        }

    }
}