using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPatterns.Abstraction
{
    public interface IClimateModel
    {
        string Name { get; set; }
        decimal Temperature { get; set; }
        decimal Pressure { get; set; }
        decimal OceanLevel { get; set; }
        decimal IceCoverage { get; set; }
        string GeographicalRegion { get; set; }

        IClimateModel Clone();
        string GetClimateData();
        string CompareWith(IClimateModel otherModel);
    }
}