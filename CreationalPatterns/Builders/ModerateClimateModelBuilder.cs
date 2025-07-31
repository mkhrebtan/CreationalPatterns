using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreationalPatterns.Abstraction;

namespace CreationalPatterns.Builders
{
    public class ModerateClimateModelBuilder : ClimateModelBuilder
    {
        public override ClimateModelBuilder SetIceCoverage()
        {
            _model.IceCoverage = 50;
            return this;
        }

        public override ClimateModelBuilder SetName()
        {
            _model.Name = "Moderate Climate Model";
            return this;
        }

        public override ClimateModelBuilder SetOceanLevel()
        {
            _model.OceanLevel = 20;
            return this;
        }

        public override ClimateModelBuilder SetPressure()
        {
            _model.Pressure = 1010;
            return this;
        }

        public override ClimateModelBuilder SetRegion()
        {
            _model.GeographicalRegion = "Temperate";
            return this;
        }

        public override ClimateModelBuilder SetTemperature()
        {
            _model.Temperature = 22;
            return this;
        }
    }
}