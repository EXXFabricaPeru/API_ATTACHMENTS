using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class SapDocumentLineModel
    {

        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public double? Quantity { get; set; }
        public double? Price { get; set; }
        public double? PriceAfterVAT { get; set; }
        public string Currency { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public double? RequiredQuantity { get; set; }
        
        public double? Rate { get; set; }
        public double? DiscountPercent { get; set; }
        public string VendorNum { get; set; }
        public string SerialNum { get; set; }
        public string WarehouseCode { get; set; }
        public int SalesPersonCode { get; set; }
        public string TreeType { get; set; }
        public string AccountCode { get; set; }
        public string UseBaseUnits { get; set; }
        public string SupplierCatNum { get; set; }
        public string CostingCode { get; set; }
        public string CostingCode2 { get; set; }
        public string CostingCode3 { get; set; }
        public string CostingCode4 { get; set; }
        public string CostingCode5 { get; set; }
        public string ProjectCode { get; set; }
        public string VatGroup { get; set; }
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public string TaxType { get; set; }
        public string TaxLiable { get; set; }
        public string FreeText { get; set; }
        //public int ShippingMethod { get; set; }
        public double? AppliedTax { get; set; }
        public double? AppliedTaxFC { get; set; }
        public double? AppliedTaxSC { get; set; }
        public string WTLiable { get; set; }
        public string DeferredTax { get; set; }

        public string MeasureUnit { get; set; }
        public double? UnitsOfMeasurment { get; set; }
        public double? LineTotal { get; set; }
        public double? TaxPercentagePerRow { get; set; }
        public double? TaxTotal { get; set; }
        public string ConsumerSalesForecast { get; set; }
        public double? ExciseAmount { get; set; }
        public double? TaxPerUnit { get; set; }
        public double? TotalInclTax { get; set; }
        public string SWW { get; set; }
        public object TransactionType { get; set; }
        public string DistributeExpense { get; set; }
        public double? RowTotalFC { get; set; }
        public double? RowTotalSC { get; set; }
        public string PickStatusEx { get; set; }
        public double? TaxBeforeDPM { get; set; }
        public double? TaxBeforeDPMFC { get; set; }
        public double? TaxBeforeDPMSC { get; set; }
        public string TaxOnly { get; set; }
        public double? UnitPrice { get; set; }
        public string LineStatus { get; set; }
        public double? PackageQuantity { get; set; }
        public string Text { get; set; }
        public string LineType { get; set; }
        public int DocEntry { get; set; }


    }
}