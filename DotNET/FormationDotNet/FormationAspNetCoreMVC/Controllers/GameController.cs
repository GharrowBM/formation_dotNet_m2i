using FormationAspNetCoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormationAspNetCoreMVC.Controllers
{
    public class GameController : Controller
    {
        private IGameConverter _gameConverter;

        public GameController(IGameConverter gameConverter)
        {
            _gameConverter = gameConverter;
        }
        public IActionResult Index(string id)
        {
            return new ContentResult() { Content = _gameConverter.Convert(id)};
        }
    }
}
