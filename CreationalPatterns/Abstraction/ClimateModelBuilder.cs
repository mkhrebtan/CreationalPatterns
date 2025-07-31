using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreationalPatterns.Models;

namespace CreationalPatterns.Abstraction
{
    public abstract class ClimateModelBuilder
    {
        protected ClimateModel _model = new ClimateModel();

        public IClimateModel Build()
        {
            ClimateModel result = _model;
            Reset();
            return result;
        }

        public void Reset()
        {
            _model = new ClimateModel();
        }

        public abstract ClimateModelBuilder SetIceCoverage();
        public abstract ClimateModelBuilder SetName();
        public abstract ClimateModelBuilder SetOceanLevel();
        public abstract ClimateModelBuilder SetPressure();
        public abstract ClimateModelBuilder SetRegion();
        public abstract ClimateModelBuilder SetTemperature();
    }
}