using System;
using System.ComponentModel.DataAnnotations;

namespace WeightProgram.Data {
    public class Customer {
        [Required]
        public int Id { get; set; } // Primary Key
        [Required]
        public string WarehouseName { get; set; }
        [Required]
        public string ScaleType { get; set; }
        [Required]
        public string VehiclePlateNumber { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Goods { get; set; }
        [Required]
        public decimal Weight1 { get; set; }
        [Required]
        public decimal Weight2 { get; set; }
        [Required]
        public decimal WeightDifference { get; set; }
        public int PackagedGoodsCount { get; set; }
        public decimal WeightPerPackagedGoods { get; set; }
        public decimal TotalPackagedGoodsWeight { get; set; }
        public decimal ActualPackagedGoodsWeight { get; set; }
        public string Notes { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }
        [Required]
        public DateTime ExitDate { get; set; }
    }
}
