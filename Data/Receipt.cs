using Base62;
using Scrypt;
using System;

namespace WeightProgram.Data {
    public partial class Receipt {
        public string GetReceiptCodeShort {
            get {
                // Get the last maximum 7 characters
                int startIndex = Math.Max(0, ReceiptCode.Length - 7);
                int length = Math.Min(ReceiptCode.Length, 7);
                return ReceiptCode.Substring(startIndex, length);
            }
        }
        public void Evaluate() {
            var encoder = new ScryptEncoder();
            ReceiptCode = encoder.Encode($"{Id}").ToBase62();
        }
    }
}