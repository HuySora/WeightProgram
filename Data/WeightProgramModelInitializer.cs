using Bogus;
using SQLite.CodeFirst;
using System;
using System.Data.Entity;

namespace WeightProgram.Data {
    public class WeightProgramModelInitializer : SqliteCreateDatabaseIfNotExists<WeightProgramModelContainer> {
        public WeightProgramModelInitializer(DbModelBuilder modelBuilder) : base(modelBuilder) {
        }
        protected override void Seed(WeightProgramModelContainer context) {
#if DEBUG
            // Create a Faker instance for generating fake WeightData data
            var wgtDataFaker = new Faker<WeightData>()
                .RuleFor(c => c.Id, f => f.IndexFaker + 1)
                .RuleFor(c => c.WarehouseName, f => f.Company.CompanyName())
                .RuleFor(c => c.ScaleType, f => f.PickRandom(new[] { "XUẤT", "NHẬP" }))
                .RuleFor(c => c.VehiclePlateNumber, f => f.Vehicle.Vin())
                .RuleFor(c => c.CustomerName, f => f.Name.FullName())
                .RuleFor(c => c.Goods, f => f.Commerce.ProductName())
                .RuleFor(c => c.Weight1, f => f.Random.Int(10000, 30000))
                .RuleFor(c => c.ContainerCount, f => f.Random.Int(100, 500))
                .RuleFor(c => c.ContainerWeightPerUnit, f => f.Random.Int(200, 1000))
                .RuleFor(c => c.Notes, f => f.Lorem.Sentence())
                .RuleFor(c => c.EntryDate, f => f.Date.Past(1))
                .RuleFor(c => c.ExitDate, f => f.Date.Future(1))
                .FinishWith((f, c) => {
                    c.Weight2 = c.Weight1 + f.Random.Int(1000, 20000);
                    c.Evaluate();
                });

            for(int i = 0; i < 100; i++) {
                var wgtData = wgtDataFaker.Generate();
                context.Set<WeightData>().Add(wgtData);
            }
#endif
        }
    }
}
