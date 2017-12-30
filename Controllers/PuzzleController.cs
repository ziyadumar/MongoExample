using System.Collections.Generic;
using System.Threading.Tasks;
using Bubbles.Interfaces;
using Bubbles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Bubbles.Controllers
{
    [Route("api/[controller]")]
    public class PuzzleController
    {
        private IPuzzleRepository _puzzleRepository;
        private ConfigurationModel _options;

        public PuzzleController(
            IPuzzleRepository puzzleRepository,
            IOptions<ConfigurationModel> options
        )
        {
            _puzzleRepository = puzzleRepository;
            _options = options.Value;
        }

        [HttpGet]
        public async Task Get()
        {
            var s = new PuzzleData
            {
                MaxX = 2,
                MaxY = 2,
                Images = new List<PuzzleImage>{
                    new PuzzleImage {
                        PositionX = 0,
                        PositionY = 1,
                        Url = "image1.png"
                    }
                }
            };
            
            await _puzzleRepository.Add(s);
        }
    }
}