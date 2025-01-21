using Base62;
using Scrypt;
using System;

namespace WeightProgram.Data {
    public partial class Receipt {
        public void Evaluate() {
            var encoder = new ScryptEncoder();
            ReceiptCode = encoder.Encode($"{Id}").ToBase62();
        }
    }
}