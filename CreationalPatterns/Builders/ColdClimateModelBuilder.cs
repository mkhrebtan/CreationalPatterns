using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreationalPatterns.Abstraction;
using CreationalPatterns.Models;

namespace CreationalPatterns.Builders
{
    public class ColdClimateModelBuilder : ClimateModelBuilder
    {
        public override ClimateModelBuilder SetIceCoverage()
        {
            _model.IceCoverage = 85;
            return this;
        }

        public override ClimateModelBuilder SetName()
        {
            _model.Name = "Arctic Climate Model";
            return this;
        }

        public override ClimateModelBuilder SetOceanLevel()
        {
            _model.OceanLevel = -15;
            return this;
        }

        public override ClimateModelBuilder SetPressure()
        {
            _model.Pressure = 1025;
            return this;
        }

        public override ClimateModelBuilder SetRegion()
        {
            _model.GeographicalRegion = "Polar";
            return this;
        }

        public override ClimateModelBuilder SetTemperature()
        {
            _model.Temperature = -15;
            return this;
        }
    }
}