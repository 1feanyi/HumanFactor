using System.Threading.Tasks;
using System.Web.Mvc;
using HumanFactor.Models;
using HumanFactor.Services;

namespace HumanFactor.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        [Authorize]
        public async Task<ActionResult> Statistics()
        {
            var db = new TriviaContext();
            var statisticsService = new StatisticsService(db);

            return this.View(await statisticsService.GenerateStatistics());
        }
    }
}