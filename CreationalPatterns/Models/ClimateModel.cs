using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.Abstraction;

namespace CreationalPatterns.Models
{
    public class ClimateModel : IClimateModel
    {
        #region Properties

        private string _name = "Unknown";
        public string Name { get => _name; set => _name = value; }

        private decimal _temperature = 0.0m;
        public decimal Temperature { get => _temperature; set => _temperature = value; }

        private decimal _pressure = 0.0m;
        public decimal Pressure { get => _pressure; set => _pressure = value; }

        private decimal _oceanLevel = 0.0m;
        public decimal OceanLevel { get => _oceanLevel; set => _oceanLevel = value; }

        private decimal _iceCoverage = 0.0m;
        public decimal IceCoverage { get => _iceCoverage; set => _iceCoverage = value; }

        private string _geographicalRegion = "Unknown";
        public string GeographicalRegion { get => _geographicalRegion; set => _geographicalRegion = value; }

        #endregion

        public ClimateModel() {}

        private ClimateModel(ClimateModel model)
        {
            Name = model.Name + " (Copy)";
            Temperature = model.Temperature;
            Pressure = model.Pressure;
            OceanLevel = model.OceanLevel;
            IceCoverage = model.IceCoverage;
            GeographicalRegion = model.GeographicalRegion;
        }

        public IClimateModel Clone()
        {
            return new ClimateModel(this);
        }

        public string CompareWith(IClimateModel other)
        {
            StringBuilder comparison = new StringBuilder();
            comparison.AppendLine($"Comparing {Name} with {other.Name}:");
            comparison.AppendLine($"Temperature Difference: {Temperature - other.Temperature}°C");
            comparison.AppendLine($"Pressure Difference: {Pressure - other.Pressure} hPa");
            comparison.AppendLine($"Ocean Level Difference: {OceanLevel - other.OceanLevel} m");
            comparison.AppendLine($"Ice Coverage Difference: {IceCoverage - other.IceCoverage}%");
            comparison.AppendLine($"Geographical Region: {GeographicalRegion} vs {other.GeographicalRegion}");
            return comparison.ToString();
        }

        public string GetClimateData()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Climate Model: {Name}");
            data.AppendLine($"Temperature: {Temperature}°C");
            data.AppendLine($"Pressure: {Pressure} hPa");
            data.AppendLine($"Ocean Level: {OceanLevel} m");
            data.AppendLine($"Ice Coverage: {IceCoverage}%");
            data.AppendLine($"Geographical Region: {GeographicalRegion}");
            return data.ToString();
        }
    }
}