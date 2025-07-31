using CreationalPatterns.Abstraction;
using CreationalPatterns.Builders;
using CreationalPatterns.Creation;
using CreationalPatterns.Models;

ColdClimateModelBuilder coldClimateBuilder = new ColdClimateModelBuilder();
ModerateClimateModelBuilder moderateClimateBuilder = new ModerateClimateModelBuilder();
HotClimateModelBuilder hotClimateBuilder = new HotClimateModelBuilder();

ClimateModelClient coldClimateClient = new ClimateModelClient(coldClimateBuilder);
ClimateModelClient moderateClimateClient = new ClimateModelClient(moderateClimateBuilder);
ClimateModelClient hotClimateClient = new ClimateModelClient(hotClimateBuilder);

System.Console.WriteLine("===Cold Climate Base Model===");
System.Console.WriteLine(coldClimateClient.GetBaseModelData());
System.Console.WriteLine("===Moderate Climate Base Model===");
System.Console.WriteLine(moderateClimateClient.GetBaseModelData());
System.Console.WriteLine("===Hot Climate Base Model===");
System.Console.WriteLine(hotClimateClient.GetBaseModelData());

IClimateModel tropicalClimateModel = hotClimateClient.CreateClimateModel("Tropical", 30.0m, 1013.25m, 0.5m, 0.1m, "Tropical Region");
System.Console.WriteLine("===Tropical Climate Model===");
System.Console.WriteLine(tropicalClimateModel.GetClimateData());

IClimateModel mountainClimateModel = moderateClimateClient.CreateClimateModel();
moderateClimateClient.UpdateClimateModel(mountainClimateModel, "Mountain", 5.0m, 1000.0m, 0.2m, 0.3m, "Mountain Region");
System.Console.WriteLine("===Mountain Climate Model===");
System.Console.WriteLine(mountainClimateModel.GetClimateData());

IClimateModel arcticClimateModel = coldClimateClient.CreateClimateModel("Arctic", -20.0m, 980.0m, 0.1m, 0.9m, "Arctic Region");
System.Console.WriteLine("===Arctic Climate Model===");
System.Console.WriteLine(arcticClimateModel.GetClimateData());

System.Console.WriteLine("===Comparing Models===");
System.Console.WriteLine(coldClimateClient.CompareModels(mountainClimateModel, arcticClimateModel));
System.Console.WriteLine(coldClimateClient.CompareModels(mountainClimateModel, tropicalClimateModel));
System.Console.WriteLine(coldClimateClient.CompareModels(arcticClimateModel, tropicalClimateModel));
