using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreationalPatterns.Abstraction;

namespace CreationalPatterns.Creation
{
    public class ClimateModelClient
    {
        private readonly IClimateModel _baseModel;

        public ClimateModelClient(ClimateModelBuilder builder)
        {
            _baseModel = builder
                .SetName()
                .SetTemperature()
                .SetPressure()
                .SetOceanLevel()
                .SetIceCoverage()
                .SetRegion()
                .Build();
        }

        public IClimateModel CreateClimateModel()
        {
            return _baseModel.Clone();
        }

        public IClimateModel CreateClimateModel(string name, decimal temperature, decimal pressure, decimal oceanLevel, decimal iceCoverage, string geographicalRegion)
        {
            IClimateModel newModel = CreateClimateModel();
            newModel.Name = name;
            newModel.Temperature = temperature;
            newModel.Pressure = pressure;
            newModel.OceanLevel = oceanLevel;
            newModel.IceCoverage = iceCoverage;
            newModel.GeographicalRegion = geographicalRegion;
            return newModel;
        }

        public string CompareModels(IClimateModel model1, IClimateModel model2)
        {
            return model1.CompareWith(model2);
        }

        public string GetBaseModelData()
        {
            return _baseModel.GetClimateData();
        }

        public string GetClimateData(IClimateModel model)
        {
            return model.GetClimateData();
        }

        public void UpdateClimateModel(IClimateModel model, string name, decimal temperature, decimal pressure, decimal oceanLevel, decimal iceCoverage, string geographicalRegion)
        {
            model.Name = name;
            model.Temperature = temperature;
            model.Pressure = pressure;
            model.OceanLevel = oceanLevel;
            model.IceCoverage = iceCoverage;
            model.GeographicalRegion = geographicalRegion;
        }
    }
}