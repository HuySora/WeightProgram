using System;

namespace WeightProgram.Data {
    public partial class WeightData {
        public void Evaluate() {
            WeightDifference = Math.Abs(Weight2 - Weight1);
            ContainerTotalWeight = (ContainerCount * ContainerWeightPerUnit) / 1000;
            NetGoodsWeight = WeightDifference - ContainerTotalWeight;
        }
    }
}