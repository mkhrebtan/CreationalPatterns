using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreationalPatterns.Abstraction;

namespace CreationalPatterns.Builders
{
    public class HotClimateModelBuilder : ClimateModelBuilder
    {
        public override ClimateModelBuilder SetName()
        {
            _model.Name = "Hot Desert Climate Model";
            return this;
        }

        public override ClimateModelBuilder SetIceCoverage()
        {
            _model.IceCoverage = 10;
            return this;
        }

        public override ClimateModelBuilder SetRegion()
        {
            _model.GeographicalRegion = "Desert";
            return this;
        }

        public override ClimateModelBuilder SetOceanLevel()
        {
            _model.OceanLevel = 10;
            return this;
        }

        public override ClimateModelBuilder SetTemperature()
        {
            _model.Temperature = 35;
            return this;
        }

        public override ClimateModelBuilder SetPressure()
        {
            _model.Pressure = 1015;
            return this;
        }
    }
}