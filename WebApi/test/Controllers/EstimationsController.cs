using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using test.Models;

namespace test.Controllers
{
    public class EstimationsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Estimation> Get(Guid userId)
        {
            var dbContext = new SmartMoneyDbContext();
            var estimatedStops =
                dbContext.Stops.Where(
                    stop => dbContext.Transactions.Count(transaction => transaction.StopId == stop.Id) == 0 
                    && dbContext.Estimations.Count(estimation => estimation.StopId == stop.Id) > 0
                    && stop.UserId == userId)
                    .ToList();
            var stopIds = estimatedStops.Select(similarStop => similarStop.Id).ToArray();
            var estimations = dbContext.Estimations.Where(estimation => stopIds.Contains(estimation.StopId)).ToList();
            return estimations;
        }
    }
}