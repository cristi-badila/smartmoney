﻿using System;
using System.Globalization;
using System.Linq;
using SmartMoneyJobRunner.Models;

namespace SmartMoneyJobRunner
{
    public class DetectPOI
    {
        public void Run()
        {
            var smartMoneyDbContext = new SmartMoneyDbContext();
            Console.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture) + " Detecting POI");
            Console.WriteLine("Analyzing " + smartMoneyDbContext.Stops.Count() + " stops");
            var stops = smartMoneyDbContext.Stops.Where(stop => !stop.PointsOfInterest.Any()).ToArray();
            Console.WriteLine("Found: {0} stops without POI", stops.Length);
        }
    }
}