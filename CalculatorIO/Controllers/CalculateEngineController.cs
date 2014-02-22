using ImperiaonlineToolsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorIO.Controllers
{
    public class CalculateEngineController : Controller
    {
        //
        // GET: /CalculateEngine/
        public ActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculator(CalcInputModel data)
        {
            TimeModel ServTime = new TimeModel(data.ServerTime);
            TimeModel TimToCrash = new TimeModel(data.TimeToCrash);
            TimeModel timToEnemy = new TimeModel(data.TimeToEnemy);
            CalcOutputModel OutputData = new CalcOutputModel();
            OutputData.CrashTime = (ServTime.Add(TimToCrash)).ToString();
            WorldSpeedsModel WorldSpeed = new WorldSpeedsModel(data.Speed);
            decimal result = Math.Round((data.DistanceToEnemy / data.EnemySpeed) / (1 + data.EnemyCartography / 10) * 3600) / WorldSpeed.WorldSpeed;
            if (data.EnemySpeed == 160 || data.EnemySpeed == 200 || data.EnemySpeed == 240 || data.EnemySpeed == 320)
            {
                result = Math.Round((data.DistanceToEnemy / data.EnemySpeed) / (1 + data.EnemyCartography / 10 + data.EnemyWarHorses * 3 / 100) * 3600) / WorldSpeed.WorldSpeed;
            }
            if (data.Miracle != 0)
            {
                result = result - result * (data.Miracle / 100);
            }
            if (data.ColonyHorses != 0)
            {
                result = result - result * (data.ColonyHorses / 100);
            }
            if (data.InWar == "No" && result < WorldSpeed.MinTime)
            {
                result = WorldSpeed.MinTime;
            }
            if (data.InWar == "Yes" && result < WorldSpeed.MinTimeInWar)
            {
                result = WorldSpeed.MinTimeInWar;
            }

            TimeModel resultModel = new TimeModel((int)result);
            OutputData.EnemyHomeFor = resultModel.ToString();
            OutputData.EnemyHomeAt = (ServTime.Add(TimToCrash)).Add(resultModel).ToString();
            OutputData.AttackAt = ((ServTime.Add(TimToCrash)).Add(resultModel)).Substract(timToEnemy).ToString();
            return PartialView("_CalcOutput", OutputData);
        }
	}
}