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
            int customerCount = 100;
            int receiptCountPerCustomerMin = 0;
            int receiptCountPerCustomerMax = 2;
            var faker = new Faker();
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
            // Create a Faker instance for generating fake Receipt data
            var receiptFaker = new Faker<Receipt>()
                .RuleFor(r => r.Id, f => f.IndexFaker + 1)
                .RuleFor(r => r.TotalCost, f => f.Random.Int(50, 1000) * 1000)
                .RuleFor(r => r.Date, f => f.Date.Past(1))
                .FinishWith((f, r) => {
                    r.Evaluate();
                });

            for(int i = 0; i < customerCount; i++) {
                var wgtData = wgtDataFaker.Generate();

                int receiptCount = faker.Random.Int(receiptCountPerCustomerMin, receiptCountPerCustomerMax);
                for(int j = 0; j < receiptCount; j++) {
                    var receipt = receiptFaker.Generate();
                    receipt.Date = faker.Date.Future(1, wgtData.ExitDate);
                    receipt.Evaluate();
                    receipt.WeightDataId = wgtData.Id;
                    receipt.WeightData = wgtData;
                    wgtData.Receipts.Add(receipt);

                    context.Set<Receipt>().Add(receipt);
                }
                context.Set<WeightData>().Add(wgtData);
            }
#endif
        }
    }
}
