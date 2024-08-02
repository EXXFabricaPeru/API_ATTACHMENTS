using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Models
{
    public class BusinessPartnerSLModel
    {
        public class BPAddress
        {
            [JsonProperty("AddressName", NullValueHandling = NullValueHandling.Ignore)]
            public string AddressName { get; set; }

            [JsonProperty("Street", NullValueHandling = NullValueHandling.Ignore)]
            public string Street { get; set; }

            [JsonProperty("Block", NullValueHandling = NullValueHandling.Ignore)]
            public string Block { get; set; }

            [JsonProperty("ZipCode", NullValueHandling = NullValueHandling.Ignore)]
            public string ZipCode { get; set; }

            [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
            public string City { get; set; }

            [JsonProperty("County", NullValueHandling = NullValueHandling.Ignore)]
            public string County { get; set; }

            [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
            public string Country { get; set; }

            [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
            public object State { get; set; }

            [JsonProperty("FederalTaxID", NullValueHandling = NullValueHandling.Ignore)]
            public object FederalTaxID { get; set; }

            [JsonProperty("TaxCode", NullValueHandling = NullValueHandling.Ignore)]
            public object TaxCode { get; set; }

            [JsonProperty("BuildingFloorRoom", NullValueHandling = NullValueHandling.Ignore)]
            public string BuildingFloorRoom { get; set; }

            [JsonProperty("AddressType", NullValueHandling = NullValueHandling.Ignore)]
            public string AddressType { get; set; }

            [JsonProperty("AddressName2", NullValueHandling = NullValueHandling.Ignore)]
            public object AddressName2 { get; set; }

            [JsonProperty("AddressName3", NullValueHandling = NullValueHandling.Ignore)]
            public object AddressName3 { get; set; }

            [JsonProperty("TypeOfAddress", NullValueHandling = NullValueHandling.Ignore)]
            public object TypeOfAddress { get; set; }

            [JsonProperty("StreetNo", NullValueHandling = NullValueHandling.Ignore)]
            public object StreetNo { get; set; }

            [JsonProperty("BPCode", NullValueHandling = NullValueHandling.Ignore)]
            public string BPCode { get; set; }

            [JsonProperty("RowNum", NullValueHandling = NullValueHandling.Ignore)]
            public int RowNum { get; set; }

            [JsonProperty("GlobalLocationNumber", NullValueHandling = NullValueHandling.Ignore)]
            public string GlobalLocationNumber { get; set; }

            [JsonProperty("Nationality", NullValueHandling = NullValueHandling.Ignore)]
            public object Nationality { get; set; }

            [JsonProperty("TaxOffice", NullValueHandling = NullValueHandling.Ignore)]
            public object TaxOffice { get; set; }

            [JsonProperty("GSTIN", NullValueHandling = NullValueHandling.Ignore)]
            public object GSTIN { get; set; }

            [JsonProperty("GstType", NullValueHandling = NullValueHandling.Ignore)]
            public object GstType { get; set; }

            [JsonProperty("CreateDate", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime CreateDate { get; set; }

            [JsonProperty("CreateTime", NullValueHandling = NullValueHandling.Ignore)]
            public string CreateTime { get; set; }

            [JsonProperty("MYFType", NullValueHandling = NullValueHandling.Ignore)]
            public object MYFType { get; set; }

            [JsonProperty("TaasEnabled", NullValueHandling = NullValueHandling.Ignore)]
            public string TaasEnabled { get; set; }
        }

        public class BPBankAccount
        {
            [JsonProperty("LogInstance", NullValueHandling = NullValueHandling.Ignore)]
            public int LogInstance { get; set; }

            [JsonProperty("UserNo4", NullValueHandling = NullValueHandling.Ignore)]
            public object UserNo4 { get; set; }

            [JsonProperty("BPCode", NullValueHandling = NullValueHandling.Ignore)]
            public string BPCode { get; set; }

            [JsonProperty("County", NullValueHandling = NullValueHandling.Ignore)]
            public string County { get; set; }

            [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
            public object State { get; set; }

            [JsonProperty("UserNo2", NullValueHandling = NullValueHandling.Ignore)]
            public object UserNo2 { get; set; }

            [JsonProperty("IBAN", NullValueHandling = NullValueHandling.Ignore)]
            public string IBAN { get; set; }

            [JsonProperty("ZipCode", NullValueHandling = NullValueHandling.Ignore)]
            public object ZipCode { get; set; }

            [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
            public object City { get; set; }

            [JsonProperty("Block", NullValueHandling = NullValueHandling.Ignore)]
            public object Block { get; set; }

            [JsonProperty("Branch", NullValueHandling = NullValueHandling.Ignore)]
            public string Branch { get; set; }

            [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
            public string Country { get; set; }

            [JsonProperty("Street", NullValueHandling = NullValueHandling.Ignore)]
            public object Street { get; set; }

            [JsonProperty("ControlKey", NullValueHandling = NullValueHandling.Ignore)]
            public string ControlKey { get; set; }

            [JsonProperty("UserNo3", NullValueHandling = NullValueHandling.Ignore)]
            public object UserNo3 { get; set; }

            [JsonProperty("BankCode", NullValueHandling = NullValueHandling.Ignore)]
            public string BankCode { get; set; }

            [JsonProperty("AccountNo", NullValueHandling = NullValueHandling.Ignore)]
            public string AccountNo { get; set; }

            [JsonProperty("UserNo1", NullValueHandling = NullValueHandling.Ignore)]
            public string UserNo1 { get; set; }

            [JsonProperty("InternalKey", NullValueHandling = NullValueHandling.Ignore)]
            public int InternalKey { get; set; }

            [JsonProperty("BuildingFloorRoom", NullValueHandling = NullValueHandling.Ignore)]
            public object BuildingFloorRoom { get; set; }

            [JsonProperty("BIK", NullValueHandling = NullValueHandling.Ignore)]
            public object BIK { get; set; }

            [JsonProperty("AccountName", NullValueHandling = NullValueHandling.Ignore)]
            public string AccountName { get; set; }

            [JsonProperty("CorrespondentAccount", NullValueHandling = NullValueHandling.Ignore)]
            public object CorrespondentAccount { get; set; }

            [JsonProperty("Phone", NullValueHandling = NullValueHandling.Ignore)]
            public object Phone { get; set; }

            [JsonProperty("Fax", NullValueHandling = NullValueHandling.Ignore)]
            public object Fax { get; set; }

            [JsonProperty("CustomerIdNumber", NullValueHandling = NullValueHandling.Ignore)]
            public string CustomerIdNumber { get; set; }

            [JsonProperty("ISRBillerID", NullValueHandling = NullValueHandling.Ignore)]
            public object ISRBillerID { get; set; }

            [JsonProperty("ISRType", NullValueHandling = NullValueHandling.Ignore)]
            public int ISRType { get; set; }

            [JsonProperty("BICSwiftCode", NullValueHandling = NullValueHandling.Ignore)]
            public object BICSwiftCode { get; set; }

            [JsonProperty("ABARoutingNumber", NullValueHandling = NullValueHandling.Ignore)]
            public object ABARoutingNumber { get; set; }

            [JsonProperty("MandateID", NullValueHandling = NullValueHandling.Ignore)]
            public object MandateID { get; set; }

            [JsonProperty("SignatureDate", NullValueHandling = NullValueHandling.Ignore)]
            public object SignatureDate { get; set; }

            [JsonProperty("MandateExpDate", NullValueHandling = NullValueHandling.Ignore)]
            public object MandateExpDate { get; set; }

            [JsonProperty("SEPASeqType", NullValueHandling = NullValueHandling.Ignore)]
            public object SEPASeqType { get; set; }

            [JsonProperty("U_SYP_MAXIMO_PAG", NullValueHandling = NullValueHandling.Ignore)]
            public double? U_SYP_MAXIMO_PAG { get; set; }

            [JsonProperty("U_SYP_SUCURSALES", NullValueHandling = NullValueHandling.Ignore)]
            public string U_SYP_SUCURSALES { get; set; }

            [JsonProperty("U_SYP_IDC", NullValueHandling = NullValueHandling.Ignore)]
            public string U_SYP_IDC { get; set; }
        }

        public class BPCurrenciesCollection
        {
            [JsonProperty("CurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
            public string CurrencyCode { get; set; }

            [JsonProperty("Include", NullValueHandling = NullValueHandling.Ignore)]
            public string Include { get; set; }
        }



        public class BPPaymentMethod
        {
            [JsonProperty("PaymentMethodCode", NullValueHandling = NullValueHandling.Ignore)]
            public string PaymentMethodCode { get; set; }

            [JsonProperty("RowNumber", NullValueHandling = NullValueHandling.Ignore)]
            public int RowNumber { get; set; }

            [JsonProperty("BPCode", NullValueHandling = NullValueHandling.Ignore)]
            public string BPCode { get; set; }
        }

        public class BPWithholdingTaxCollection
        {
            [JsonProperty("WTCode", NullValueHandling = NullValueHandling.Ignore)]
            public string WTCode { get; set; }

            [JsonProperty("BPCode", NullValueHandling = NullValueHandling.Ignore)]
            public string BPCode { get; set; }
        }

        public class ContactEmployee
        {
            [JsonProperty("CardCode", NullValueHandling = NullValueHandling.Ignore)]
            public string CardCode { get; set; }

            [JsonProperty("Name", NullValueHandling = NullValueHandling.Ignore)]
            public string Name { get; set; }

            [JsonProperty("Position", NullValueHandling = NullValueHandling.Ignore)]
            public string Position { get; set; }

            [JsonProperty("Address", NullValueHandling = NullValueHandling.Ignore)]
            public string Address { get; set; }

            [JsonProperty("Phone1", NullValueHandling = NullValueHandling.Ignore)]
            public string Phone1 { get; set; }

            [JsonProperty("Phone2", NullValueHandling = NullValueHandling.Ignore)]
            public string Phone2 { get; set; }

            [JsonProperty("MobilePhone", NullValueHandling = NullValueHandling.Ignore)]
            public string MobilePhone { get; set; }

            [JsonProperty("Fax", NullValueHandling = NullValueHandling.Ignore)]
            public object Fax { get; set; }

            [JsonProperty("E_Mail", NullValueHandling = NullValueHandling.Ignore)]
            public string E_Mail { get; set; }

            [JsonProperty("Pager", NullValueHandling = NullValueHandling.Ignore)]
            public object Pager { get; set; }

            [JsonProperty("Remarks1", NullValueHandling = NullValueHandling.Ignore)]
            public string Remarks1 { get; set; }

            [JsonProperty("Remarks2", NullValueHandling = NullValueHandling.Ignore)]
            public object Remarks2 { get; set; }

            [JsonProperty("Password", NullValueHandling = NullValueHandling.Ignore)]
            public object Password { get; set; }

            [JsonProperty("InternalCode", NullValueHandling = NullValueHandling.Ignore)]
            public int InternalCode { get; set; }

            [JsonProperty("PlaceOfBirth", NullValueHandling = NullValueHandling.Ignore)]
            public string PlaceOfBirth { get; set; }

            [JsonProperty("DateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
            public object DateOfBirth { get; set; }

            [JsonProperty("Gender", NullValueHandling = NullValueHandling.Ignore)]
            public string Gender { get; set; }

            [JsonProperty("Profession", NullValueHandling = NullValueHandling.Ignore)]
            public object Profession { get; set; }

            [JsonProperty("Title", NullValueHandling = NullValueHandling.Ignore)]
            public string Title { get; set; }

            [JsonProperty("CityOfBirth", NullValueHandling = NullValueHandling.Ignore)]
            public object CityOfBirth { get; set; }

            [JsonProperty("Active", NullValueHandling = NullValueHandling.Ignore)]
            public string Active { get; set; }

            [JsonProperty("FirstName", NullValueHandling = NullValueHandling.Ignore)]
            public string FirstName { get; set; }

            [JsonProperty("MiddleName", NullValueHandling = NullValueHandling.Ignore)]
            public string MiddleName { get; set; }

            [JsonProperty("LastName", NullValueHandling = NullValueHandling.Ignore)]
            public string LastName { get; set; }

            [JsonProperty("EmailGroupCode", NullValueHandling = NullValueHandling.Ignore)]
            public object EmailGroupCode { get; set; }

            [JsonProperty("BlockSendingMarketingContent", NullValueHandling = NullValueHandling.Ignore)]
            public string BlockSendingMarketingContent { get; set; }

            [JsonProperty("CreateDate", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime CreateDate { get; set; }

            [JsonProperty("CreateTime", NullValueHandling = NullValueHandling.Ignore)]
            public string CreateTime { get; set; }

            [JsonProperty("UpdateDate", NullValueHandling = NullValueHandling.Ignore)]
            public DateTime UpdateDate { get; set; }

            [JsonProperty("UpdateTime", NullValueHandling = NullValueHandling.Ignore)]
            public string UpdateTime { get; set; }

            [JsonProperty("ConnectedAddressName", NullValueHandling = NullValueHandling.Ignore)]
            public object ConnectedAddressName { get; set; }

            [JsonProperty("ConnectedAddressType", NullValueHandling = NullValueHandling.Ignore)]
            public object ConnectedAddressType { get; set; }

            [JsonProperty("ForeignCountry", NullValueHandling = NullValueHandling.Ignore)]
            public object ForeignCountry { get; set; }

            [JsonProperty("ContactEmployeeBlockSendingMarketingContents", NullValueHandling = NullValueHandling.Ignore)]
            public List<object> ContactEmployeeBlockSendingMarketingContents { get; set; }
        }




        [JsonProperty("odata.etag", NullValueHandling = NullValueHandling.Ignore)]
        public string odataetag { get; set; }

        [JsonProperty("CardCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CardCode { get; set; }

        [JsonProperty("CardName", NullValueHandling = NullValueHandling.Ignore)]
        public string CardName { get; set; }

        [JsonProperty("CardType", NullValueHandling = NullValueHandling.Ignore)]
        public string CardType { get; set; }

        [JsonProperty("GroupCode", NullValueHandling = NullValueHandling.Ignore)]
        public int GroupCode { get; set; }

        [JsonProperty("Address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        [JsonProperty("ZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ZipCode { get; set; }

        [JsonProperty("MailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public object MailAddress { get; set; }

        [JsonProperty("MailZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public object MailZipCode { get; set; }

        [JsonProperty("Phone1", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone1 { get; set; }

        [JsonProperty("Phone2", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone2 { get; set; }

        [JsonProperty("Fax", NullValueHandling = NullValueHandling.Ignore)]
        public string Fax { get; set; }

        [JsonProperty("ContactPerson", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactPerson { get; set; }

        [JsonProperty("Notes", NullValueHandling = NullValueHandling.Ignore)]
        public object Notes { get; set; }

        [JsonProperty("PayTermsGrpCode", NullValueHandling = NullValueHandling.Ignore)]
        public int PayTermsGrpCode { get; set; }

        [JsonProperty("CreditLimit", NullValueHandling = NullValueHandling.Ignore)]
        public double CreditLimit { get; set; }

        [JsonProperty("MaxCommitment", NullValueHandling = NullValueHandling.Ignore)]
        public double MaxCommitment { get; set; }

        [JsonProperty("DiscountPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double DiscountPercent { get; set; }

        [JsonProperty("VatLiable", NullValueHandling = NullValueHandling.Ignore)]
        public string VatLiable { get; set; }

        [JsonProperty("FederalTaxID", NullValueHandling = NullValueHandling.Ignore)]
        public string FederalTaxID { get; set; }

        [JsonProperty("DeductibleAtSource", NullValueHandling = NullValueHandling.Ignore)]
        public string DeductibleAtSource { get; set; }

        [JsonProperty("DeductionPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double DeductionPercent { get; set; }

        [JsonProperty("DeductionValidUntil", NullValueHandling = NullValueHandling.Ignore)]
        public object DeductionValidUntil { get; set; }

        [JsonProperty("PriceListNum", NullValueHandling = NullValueHandling.Ignore)]
        public int PriceListNum { get; set; }

        [JsonProperty("IntrestRatePercent", NullValueHandling = NullValueHandling.Ignore)]
        public double IntrestRatePercent { get; set; }

        [JsonProperty("CommissionPercent", NullValueHandling = NullValueHandling.Ignore)]
        public double CommissionPercent { get; set; }

        [JsonProperty("CommissionGroupCode", NullValueHandling = NullValueHandling.Ignore)]
        public int CommissionGroupCode { get; set; }

        [JsonProperty("FreeText", NullValueHandling = NullValueHandling.Ignore)]
        public string FreeText { get; set; }

        [JsonProperty("SalesPersonCode", NullValueHandling = NullValueHandling.Ignore)]
        public int SalesPersonCode { get; set; }

        [JsonProperty("Currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("RateDiffAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string RateDiffAccount { get; set; }

        [JsonProperty("Cellular", NullValueHandling = NullValueHandling.Ignore)]
        public string Cellular { get; set; }

        [JsonProperty("AvarageLate", NullValueHandling = NullValueHandling.Ignore)]
        public object AvarageLate { get; set; }

        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("County", NullValueHandling = NullValueHandling.Ignore)]
        public string County { get; set; }

        [JsonProperty("Country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("MailCity", NullValueHandling = NullValueHandling.Ignore)]
        public object MailCity { get; set; }

        [JsonProperty("MailCounty", NullValueHandling = NullValueHandling.Ignore)]
        public object MailCounty { get; set; }

        [JsonProperty("MailCountry", NullValueHandling = NullValueHandling.Ignore)]
        public object MailCountry { get; set; }

        [JsonProperty("EmailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [JsonProperty("Picture", NullValueHandling = NullValueHandling.Ignore)]
        public object Picture { get; set; }

        [JsonProperty("DefaultAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultAccount { get; set; }

        [JsonProperty("DefaultBranch", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBranch { get; set; }

        [JsonProperty("DefaultBankCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBankCode { get; set; }

        [JsonProperty("AdditionalID", NullValueHandling = NullValueHandling.Ignore)]
        public object AdditionalID { get; set; }

        [JsonProperty("Pager", NullValueHandling = NullValueHandling.Ignore)]
        public object Pager { get; set; }

        [JsonProperty("FatherCard", NullValueHandling = NullValueHandling.Ignore)]
        public object FatherCard { get; set; }

        [JsonProperty("CardForeignName", NullValueHandling = NullValueHandling.Ignore)]
        public object CardForeignName { get; set; }

        [JsonProperty("FatherType", NullValueHandling = NullValueHandling.Ignore)]
        public string FatherType { get; set; }

        [JsonProperty("DeductionOffice", NullValueHandling = NullValueHandling.Ignore)]
        public object DeductionOffice { get; set; }

        [JsonProperty("ExportCode", NullValueHandling = NullValueHandling.Ignore)]
        public object ExportCode { get; set; }

        [JsonProperty("MinIntrest", NullValueHandling = NullValueHandling.Ignore)]
        public double MinIntrest { get; set; }

        [JsonProperty("CurrentAccountBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double CurrentAccountBalance { get; set; }

        [JsonProperty("OpenDeliveryNotesBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double OpenDeliveryNotesBalance { get; set; }

        [JsonProperty("OpenOrdersBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double OpenOrdersBalance { get; set; }

        [JsonProperty("OpenChecksBalance", NullValueHandling = NullValueHandling.Ignore)]
        public double OpenChecksBalance { get; set; }

        [JsonProperty("VatGroup", NullValueHandling = NullValueHandling.Ignore)]
        public object VatGroup { get; set; }

        [JsonProperty("ShippingType", NullValueHandling = NullValueHandling.Ignore)]
        public object ShippingType { get; set; }

        [JsonProperty("Password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        [JsonProperty("Indicator", NullValueHandling = NullValueHandling.Ignore)]
        public object Indicator { get; set; }

        [JsonProperty("IBAN", NullValueHandling = NullValueHandling.Ignore)]
        public object IBAN { get; set; }

        [JsonProperty("CreditCardCode", NullValueHandling = NullValueHandling.Ignore)]
        public int CreditCardCode { get; set; }

        [JsonProperty("CreditCardNum", NullValueHandling = NullValueHandling.Ignore)]
        public object CreditCardNum { get; set; }

        [JsonProperty("CreditCardExpiration", NullValueHandling = NullValueHandling.Ignore)]
        public object CreditCardExpiration { get; set; }

        [JsonProperty("DebitorAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string DebitorAccount { get; set; }

        [JsonProperty("OpenOpportunities", NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenOpportunities { get; set; }

        [JsonProperty("Valid", NullValueHandling = NullValueHandling.Ignore)]
        public string Valid { get; set; }

        [JsonProperty("ValidFrom", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ValidFrom { get; set; }

        [JsonProperty("ValidTo", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ValidTo { get; set; }

        [JsonProperty("ValidRemarks", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidRemarks { get; set; }

        [JsonProperty("Frozen", NullValueHandling = NullValueHandling.Ignore)]
        public string Frozen { get; set; }

        [JsonProperty("FrozenFrom", NullValueHandling = NullValueHandling.Ignore)]
        public object FrozenFrom { get; set; }

        [JsonProperty("FrozenTo", NullValueHandling = NullValueHandling.Ignore)]
        public object FrozenTo { get; set; }

        [JsonProperty("FrozenRemarks", NullValueHandling = NullValueHandling.Ignore)]
        public object FrozenRemarks { get; set; }

        [JsonProperty("Block", NullValueHandling = NullValueHandling.Ignore)]
        public string Block { get; set; }

        [JsonProperty("BillToState", NullValueHandling = NullValueHandling.Ignore)]
        public object BillToState { get; set; }

        [JsonProperty("ShipToState", NullValueHandling = NullValueHandling.Ignore)]
        public object ShipToState { get; set; }

        [JsonProperty("ExemptNum", NullValueHandling = NullValueHandling.Ignore)]
        public object ExemptNum { get; set; }

        [JsonProperty("Priority", NullValueHandling = NullValueHandling.Ignore)]
        public int Priority { get; set; }

        [JsonProperty("FormCode1099", NullValueHandling = NullValueHandling.Ignore)]
        public object FormCode1099 { get; set; }

        [JsonProperty("Box1099", NullValueHandling = NullValueHandling.Ignore)]
        public object Box1099 { get; set; }

        [JsonProperty("PeymentMethodCode", NullValueHandling = NullValueHandling.Ignore)]
        public object PeymentMethodCode { get; set; }

        [JsonProperty("BackOrder", NullValueHandling = NullValueHandling.Ignore)]
        public string BackOrder { get; set; }

        [JsonProperty("PartialDelivery", NullValueHandling = NullValueHandling.Ignore)]
        public string PartialDelivery { get; set; }

        [JsonProperty("BlockDunning", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockDunning { get; set; }

        [JsonProperty("BankCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string BankCountry { get; set; }

        [JsonProperty("HouseBank", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseBank { get; set; }

        [JsonProperty("HouseBankCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseBankCountry { get; set; }

        [JsonProperty("HouseBankAccount", NullValueHandling = NullValueHandling.Ignore)]
        public object HouseBankAccount { get; set; }

        [JsonProperty("ShipToDefault", NullValueHandling = NullValueHandling.Ignore)]
        public object ShipToDefault { get; set; }

        [JsonProperty("DunningLevel", NullValueHandling = NullValueHandling.Ignore)]
        public object DunningLevel { get; set; }

        [JsonProperty("DunningDate", NullValueHandling = NullValueHandling.Ignore)]
        public object DunningDate { get; set; }

        [JsonProperty("CollectionAuthorization", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectionAuthorization { get; set; }

        [JsonProperty("DME", NullValueHandling = NullValueHandling.Ignore)]
        public object DME { get; set; }

        [JsonProperty("InstructionKey", NullValueHandling = NullValueHandling.Ignore)]
        public object InstructionKey { get; set; }

        [JsonProperty("SinglePayment", NullValueHandling = NullValueHandling.Ignore)]
        public string SinglePayment { get; set; }

        [JsonProperty("ISRBillerID", NullValueHandling = NullValueHandling.Ignore)]
        public object ISRBillerID { get; set; }

        [JsonProperty("PaymentBlock", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentBlock { get; set; }

        [JsonProperty("ReferenceDetails", NullValueHandling = NullValueHandling.Ignore)]
        public object ReferenceDetails { get; set; }

        [JsonProperty("HouseBankBranch", NullValueHandling = NullValueHandling.Ignore)]
        public object HouseBankBranch { get; set; }

        [JsonProperty("OwnerIDNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object OwnerIDNumber { get; set; }

        [JsonProperty("PaymentBlockDescription", NullValueHandling = NullValueHandling.Ignore)]
        public int PaymentBlockDescription { get; set; }

        [JsonProperty("TaxExemptionLetterNum", NullValueHandling = NullValueHandling.Ignore)]
        public object TaxExemptionLetterNum { get; set; }

        [JsonProperty("MaxAmountOfExemption", NullValueHandling = NullValueHandling.Ignore)]
        public double MaxAmountOfExemption { get; set; }

        [JsonProperty("ExemptionValidityDateFrom", NullValueHandling = NullValueHandling.Ignore)]
        public object ExemptionValidityDateFrom { get; set; }

        [JsonProperty("ExemptionValidityDateTo", NullValueHandling = NullValueHandling.Ignore)]
        public object ExemptionValidityDateTo { get; set; }

        [JsonProperty("LinkedBusinessPartner", NullValueHandling = NullValueHandling.Ignore)]
        public object LinkedBusinessPartner { get; set; }

        [JsonProperty("LastMultiReconciliationNum", NullValueHandling = NullValueHandling.Ignore)]
        public object LastMultiReconciliationNum { get; set; }

        [JsonProperty("DeferredTax", NullValueHandling = NullValueHandling.Ignore)]
        public string DeferredTax { get; set; }

        [JsonProperty("Equalization", NullValueHandling = NullValueHandling.Ignore)]
        public string Equalization { get; set; }

        [JsonProperty("SubjectToWithholdingTax", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectToWithholdingTax { get; set; }

        [JsonProperty("CertificateNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object CertificateNumber { get; set; }

        [JsonProperty("ExpirationDate", NullValueHandling = NullValueHandling.Ignore)]
        public object ExpirationDate { get; set; }

        [JsonProperty("NationalInsuranceNum", NullValueHandling = NullValueHandling.Ignore)]
        public object NationalInsuranceNum { get; set; }

        [JsonProperty("AccrualCriteria", NullValueHandling = NullValueHandling.Ignore)]
        public string AccrualCriteria { get; set; }

        [JsonProperty("WTCode", NullValueHandling = NullValueHandling.Ignore)]
        public string WTCode { get; set; }

        [JsonProperty("BillToBuildingFloorRoom", NullValueHandling = NullValueHandling.Ignore)]
        public string BillToBuildingFloorRoom { get; set; }

        [JsonProperty("DownPaymentClearAct", NullValueHandling = NullValueHandling.Ignore)]
        public string DownPaymentClearAct { get; set; }

        [JsonProperty("ChannelBP", NullValueHandling = NullValueHandling.Ignore)]
        public object ChannelBP { get; set; }

        [JsonProperty("DefaultTechnician", NullValueHandling = NullValueHandling.Ignore)]
        public object DefaultTechnician { get; set; }

        [JsonProperty("BilltoDefault", NullValueHandling = NullValueHandling.Ignore)]
        public string BilltoDefault { get; set; }

        [JsonProperty("CustomerBillofExchangDisc", NullValueHandling = NullValueHandling.Ignore)]
        public object CustomerBillofExchangDisc { get; set; }

        [JsonProperty("Territory", NullValueHandling = NullValueHandling.Ignore)]
        public object Territory { get; set; }

        [JsonProperty("ShipToBuildingFloorRoom", NullValueHandling = NullValueHandling.Ignore)]
        public object ShipToBuildingFloorRoom { get; set; }

        [JsonProperty("CustomerBillofExchangPres", NullValueHandling = NullValueHandling.Ignore)]
        public object CustomerBillofExchangPres { get; set; }

        [JsonProperty("ProjectCode", NullValueHandling = NullValueHandling.Ignore)]
        public object ProjectCode { get; set; }

        [JsonProperty("VatGroupLatinAmerica", NullValueHandling = NullValueHandling.Ignore)]
        public string VatGroupLatinAmerica { get; set; }

        [JsonProperty("DunningTerm", NullValueHandling = NullValueHandling.Ignore)]
        public string DunningTerm { get; set; }

        [JsonProperty("Website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        [JsonProperty("OtherReceivablePayable", NullValueHandling = NullValueHandling.Ignore)]
        public object OtherReceivablePayable { get; set; }

        [JsonProperty("BillofExchangeonCollection", NullValueHandling = NullValueHandling.Ignore)]
        public object BillofExchangeonCollection { get; set; }

        [JsonProperty("CompanyPrivate", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyPrivate { get; set; }

        [JsonProperty("LanguageCode", NullValueHandling = NullValueHandling.Ignore)]
        public int LanguageCode { get; set; }

        [JsonProperty("UnpaidBillofExchange", NullValueHandling = NullValueHandling.Ignore)]
        public object UnpaidBillofExchange { get; set; }

        [JsonProperty("WithholdingTaxDeductionGroup", NullValueHandling = NullValueHandling.Ignore)]
        public int WithholdingTaxDeductionGroup { get; set; }

        [JsonProperty("ClosingDateProcedureNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object ClosingDateProcedureNumber { get; set; }

        [JsonProperty("Profession", NullValueHandling = NullValueHandling.Ignore)]
        public object Profession { get; set; }

        [JsonProperty("BankChargesAllocationCode", NullValueHandling = NullValueHandling.Ignore)]
        public object BankChargesAllocationCode { get; set; }

        [JsonProperty("TaxRoundingRule", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxRoundingRule { get; set; }

        [JsonProperty("Properties1", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties1 { get; set; }

        [JsonProperty("Properties2", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties2 { get; set; }

        [JsonProperty("Properties3", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties3 { get; set; }

        [JsonProperty("Properties4", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties4 { get; set; }

        [JsonProperty("Properties5", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties5 { get; set; }

        [JsonProperty("Properties6", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties6 { get; set; }

        [JsonProperty("Properties7", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties7 { get; set; }

        [JsonProperty("Properties8", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties8 { get; set; }

        [JsonProperty("Properties9", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties9 { get; set; }

        [JsonProperty("Properties10", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties10 { get; set; }

        [JsonProperty("Properties11", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties11 { get; set; }

        [JsonProperty("Properties12", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties12 { get; set; }

        [JsonProperty("Properties13", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties13 { get; set; }

        [JsonProperty("Properties14", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties14 { get; set; }

        [JsonProperty("Properties15", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties15 { get; set; }

        [JsonProperty("Properties16", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties16 { get; set; }

        [JsonProperty("Properties17", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties17 { get; set; }

        [JsonProperty("Properties18", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties18 { get; set; }

        [JsonProperty("Properties19", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties19 { get; set; }

        [JsonProperty("Properties20", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties20 { get; set; }

        [JsonProperty("Properties21", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties21 { get; set; }

        [JsonProperty("Properties22", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties22 { get; set; }

        [JsonProperty("Properties23", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties23 { get; set; }

        [JsonProperty("Properties24", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties24 { get; set; }

        [JsonProperty("Properties25", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties25 { get; set; }

        [JsonProperty("Properties26", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties26 { get; set; }

        [JsonProperty("Properties27", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties27 { get; set; }

        [JsonProperty("Properties28", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties28 { get; set; }

        [JsonProperty("Properties29", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties29 { get; set; }

        [JsonProperty("Properties30", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties30 { get; set; }

        [JsonProperty("Properties31", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties31 { get; set; }

        [JsonProperty("Properties32", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties32 { get; set; }

        [JsonProperty("Properties33", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties33 { get; set; }

        [JsonProperty("Properties34", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties34 { get; set; }

        [JsonProperty("Properties35", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties35 { get; set; }

        [JsonProperty("Properties36", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties36 { get; set; }

        [JsonProperty("Properties37", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties37 { get; set; }

        [JsonProperty("Properties38", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties38 { get; set; }

        [JsonProperty("Properties39", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties39 { get; set; }

        [JsonProperty("Properties40", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties40 { get; set; }

        [JsonProperty("Properties41", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties41 { get; set; }

        [JsonProperty("Properties42", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties42 { get; set; }

        [JsonProperty("Properties43", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties43 { get; set; }

        [JsonProperty("Properties44", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties44 { get; set; }

        [JsonProperty("Properties45", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties45 { get; set; }

        [JsonProperty("Properties46", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties46 { get; set; }

        [JsonProperty("Properties47", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties47 { get; set; }

        [JsonProperty("Properties48", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties48 { get; set; }

        [JsonProperty("Properties49", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties49 { get; set; }

        [JsonProperty("Properties50", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties50 { get; set; }

        [JsonProperty("Properties51", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties51 { get; set; }

        [JsonProperty("Properties52", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties52 { get; set; }

        [JsonProperty("Properties53", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties53 { get; set; }

        [JsonProperty("Properties54", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties54 { get; set; }

        [JsonProperty("Properties55", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties55 { get; set; }

        [JsonProperty("Properties56", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties56 { get; set; }

        [JsonProperty("Properties57", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties57 { get; set; }

        [JsonProperty("Properties58", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties58 { get; set; }

        [JsonProperty("Properties59", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties59 { get; set; }

        [JsonProperty("Properties60", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties60 { get; set; }

        [JsonProperty("Properties61", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties61 { get; set; }

        [JsonProperty("Properties62", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties62 { get; set; }

        [JsonProperty("Properties63", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties63 { get; set; }

        [JsonProperty("Properties64", NullValueHandling = NullValueHandling.Ignore)]
        public string Properties64 { get; set; }

        [JsonProperty("CompanyRegistrationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object CompanyRegistrationNumber { get; set; }

        [JsonProperty("VerificationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object VerificationNumber { get; set; }

        [JsonProperty("DiscountBaseObject", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountBaseObject { get; set; }

        [JsonProperty("DiscountRelations", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountRelations { get; set; }

        [JsonProperty("TypeReport", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeReport { get; set; }

        [JsonProperty("ThresholdOverlook", NullValueHandling = NullValueHandling.Ignore)]
        public string ThresholdOverlook { get; set; }

        [JsonProperty("SurchargeOverlook", NullValueHandling = NullValueHandling.Ignore)]
        public string SurchargeOverlook { get; set; }

        [JsonProperty("DownPaymentInterimAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string DownPaymentInterimAccount { get; set; }

        [JsonProperty("OperationCode347", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationCode347 { get; set; }

        [JsonProperty("InsuranceOperation347", NullValueHandling = NullValueHandling.Ignore)]
        public string InsuranceOperation347 { get; set; }

        [JsonProperty("HierarchicalDeduction", NullValueHandling = NullValueHandling.Ignore)]
        public string HierarchicalDeduction { get; set; }

        [JsonProperty("ShaamGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string ShaamGroup { get; set; }

        [JsonProperty("WithholdingTaxCertified", NullValueHandling = NullValueHandling.Ignore)]
        public string WithholdingTaxCertified { get; set; }

        [JsonProperty("BookkeepingCertified", NullValueHandling = NullValueHandling.Ignore)]
        public string BookkeepingCertified { get; set; }

        [JsonProperty("PlanningGroup", NullValueHandling = NullValueHandling.Ignore)]
        public object PlanningGroup { get; set; }

        [JsonProperty("Affiliate", NullValueHandling = NullValueHandling.Ignore)]
        public string Affiliate { get; set; }

        [JsonProperty("Industry", NullValueHandling = NullValueHandling.Ignore)]
        public object Industry { get; set; }

        [JsonProperty("VatIDNum", NullValueHandling = NullValueHandling.Ignore)]
        public object VatIDNum { get; set; }

        [JsonProperty("DatevAccount", NullValueHandling = NullValueHandling.Ignore)]
        public object DatevAccount { get; set; }

        [JsonProperty("DatevFirstDataEntry", NullValueHandling = NullValueHandling.Ignore)]
        public string DatevFirstDataEntry { get; set; }

        [JsonProperty("UseShippedGoodsAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string UseShippedGoodsAccount { get; set; }

        [JsonProperty("GTSRegNo", NullValueHandling = NullValueHandling.Ignore)]
        public object GTSRegNo { get; set; }

        [JsonProperty("GTSBankAccountNo", NullValueHandling = NullValueHandling.Ignore)]
        public object GTSBankAccountNo { get; set; }

        [JsonProperty("GTSBillingAddrTel", NullValueHandling = NullValueHandling.Ignore)]
        public object GTSBillingAddrTel { get; set; }

        [JsonProperty("ETaxWebSite", NullValueHandling = NullValueHandling.Ignore)]
        public object ETaxWebSite { get; set; }

        [JsonProperty("HouseBankIBAN", NullValueHandling = NullValueHandling.Ignore)]
        public string HouseBankIBAN { get; set; }

        [JsonProperty("VATRegistrationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object VATRegistrationNumber { get; set; }

        [JsonProperty("RepresentativeName", NullValueHandling = NullValueHandling.Ignore)]
        public object RepresentativeName { get; set; }

        [JsonProperty("IndustryType", NullValueHandling = NullValueHandling.Ignore)]
        public object IndustryType { get; set; }

        [JsonProperty("BusinessType", NullValueHandling = NullValueHandling.Ignore)]
        public object BusinessType { get; set; }

        [JsonProperty("Series", NullValueHandling = NullValueHandling.Ignore)]
        public int Series { get; set; }

        [JsonProperty("AutomaticPosting", NullValueHandling = NullValueHandling.Ignore)]
        public object AutomaticPosting { get; set; }

        [JsonProperty("InterestAccount", NullValueHandling = NullValueHandling.Ignore)]
        public object InterestAccount { get; set; }

        [JsonProperty("FeeAccount", NullValueHandling = NullValueHandling.Ignore)]
        public object FeeAccount { get; set; }

        [JsonProperty("CampaignNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object CampaignNumber { get; set; }

        [JsonProperty("AliasName", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasName { get; set; }

        [JsonProperty("DefaultBlanketAgreementNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object DefaultBlanketAgreementNumber { get; set; }

        [JsonProperty("EffectiveDiscount", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveDiscount { get; set; }

        [JsonProperty("NoDiscounts", NullValueHandling = NullValueHandling.Ignore)]
        public string NoDiscounts { get; set; }

        [JsonProperty("EffectivePrice", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectivePrice { get; set; }

        [JsonProperty("EffectivePriceConsidersPriceBeforeDiscount", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectivePriceConsidersPriceBeforeDiscount { get; set; }

        [JsonProperty("GlobalLocationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalLocationNumber { get; set; }

        [JsonProperty("EDISenderID", NullValueHandling = NullValueHandling.Ignore)]
        public object EDISenderID { get; set; }

        [JsonProperty("EDIRecipientID", NullValueHandling = NullValueHandling.Ignore)]
        public object EDIRecipientID { get; set; }

        [JsonProperty("ResidenNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string ResidenNumber { get; set; }

        [JsonProperty("RelationshipCode", NullValueHandling = NullValueHandling.Ignore)]
        public object RelationshipCode { get; set; }

        [JsonProperty("RelationshipDateFrom", NullValueHandling = NullValueHandling.Ignore)]
        public object RelationshipDateFrom { get; set; }

        [JsonProperty("RelationshipDateTill", NullValueHandling = NullValueHandling.Ignore)]
        public object RelationshipDateTill { get; set; }

        [JsonProperty("UnifiedFederalTaxID", NullValueHandling = NullValueHandling.Ignore)]
        public object UnifiedFederalTaxID { get; set; }

        [JsonProperty("AttachmentEntry", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachmentEntry { get; set; }

        [JsonProperty("TypeOfOperation", NullValueHandling = NullValueHandling.Ignore)]
        public object TypeOfOperation { get; set; }

        [JsonProperty("EndorsableChecksFromBP", NullValueHandling = NullValueHandling.Ignore)]
        public string EndorsableChecksFromBP { get; set; }

        [JsonProperty("AcceptsEndorsedChecks", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptsEndorsedChecks { get; set; }

        [JsonProperty("OwnerCode", NullValueHandling = NullValueHandling.Ignore)]
        public object OwnerCode { get; set; }

        [JsonProperty("BlockSendingMarketingContent", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockSendingMarketingContent { get; set; }

        [JsonProperty("AgentCode", NullValueHandling = NullValueHandling.Ignore)]
        public object AgentCode { get; set; }

        [JsonProperty("PriceMode", NullValueHandling = NullValueHandling.Ignore)]
        public object PriceMode { get; set; }

        [JsonProperty("EDocGenerationType", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocGenerationType { get; set; }

        [JsonProperty("EDocStreet", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocStreet { get; set; }

        [JsonProperty("EDocStreetNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocStreetNumber { get; set; }

        [JsonProperty("EDocBuildingNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocBuildingNumber { get; set; }

        [JsonProperty("EDocZipCode", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocZipCode { get; set; }

        [JsonProperty("EDocCity", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocCity { get; set; }

        [JsonProperty("EDocCountry", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocCountry { get; set; }

        [JsonProperty("EDocDistrict", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocDistrict { get; set; }

        [JsonProperty("EDocRepresentativeFirstName", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocRepresentativeFirstName { get; set; }

        [JsonProperty("EDocRepresentativeSurname", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocRepresentativeSurname { get; set; }

        [JsonProperty("EDocRepresentativeCompany", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocRepresentativeCompany { get; set; }

        [JsonProperty("EDocRepresentativeFiscalCode", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocRepresentativeFiscalCode { get; set; }

        [JsonProperty("EDocRepresentativeAdditionalId", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocRepresentativeAdditionalId { get; set; }

        [JsonProperty("EDocPECAddress", NullValueHandling = NullValueHandling.Ignore)]
        public object EDocPECAddress { get; set; }

        [JsonProperty("IPACodeForPA", NullValueHandling = NullValueHandling.Ignore)]
        public object IPACodeForPA { get; set; }

        [JsonProperty("UpdateDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateDate { get; set; }

        [JsonProperty("UpdateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        [JsonProperty("ExemptionMaxAmountValidationType", NullValueHandling = NullValueHandling.Ignore)]
        public string ExemptionMaxAmountValidationType { get; set; }

        [JsonProperty("ECommerceMerchantID", NullValueHandling = NullValueHandling.Ignore)]
        public object ECommerceMerchantID { get; set; }

        [JsonProperty("UseBillToAddrToDetermineTax", NullValueHandling = NullValueHandling.Ignore)]
        public string UseBillToAddrToDetermineTax { get; set; }

        [JsonProperty("CreateDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreateDate { get; set; }

        [JsonProperty("CreateTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        [JsonProperty("DefaultTransporterEntry", NullValueHandling = NullValueHandling.Ignore)]
        public object DefaultTransporterEntry { get; set; }

        [JsonProperty("DefaultTransporterLineNumber", NullValueHandling = NullValueHandling.Ignore)]
        public object DefaultTransporterLineNumber { get; set; }

        [JsonProperty("FCERelevant", NullValueHandling = NullValueHandling.Ignore)]
        public string FCERelevant { get; set; }

        [JsonProperty("FCEValidateBaseDelivery", NullValueHandling = NullValueHandling.Ignore)]
        public string FCEValidateBaseDelivery { get; set; }

        [JsonProperty("MainUsage", NullValueHandling = NullValueHandling.Ignore)]
        public object MainUsage { get; set; }

        [JsonProperty("EBooksVATExemptionCause", NullValueHandling = NullValueHandling.Ignore)]
        public object EBooksVATExemptionCause { get; set; }

        [JsonProperty("LegalText", NullValueHandling = NullValueHandling.Ignore)]
        public object LegalText { get; set; }

        [JsonProperty("DataVersion", NullValueHandling = NullValueHandling.Ignore)]
        public int DataVersion { get; set; }

        [JsonProperty("ExchangeRateForIncomingPayment", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeRateForIncomingPayment { get; set; }

        [JsonProperty("ExchangeRateForOutgoingPayment", NullValueHandling = NullValueHandling.Ignore)]
        public string ExchangeRateForOutgoingPayment { get; set; }

        [JsonProperty("CertificateDetails", NullValueHandling = NullValueHandling.Ignore)]
        public object CertificateDetails { get; set; }

        [JsonProperty("DefaultCurrency", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultCurrency { get; set; }

        [JsonProperty("EORINumber", NullValueHandling = NullValueHandling.Ignore)]
        public object EORINumber { get; set; }

        [JsonProperty("FCEAsPaymentMeans", NullValueHandling = NullValueHandling.Ignore)]
        public string FCEAsPaymentMeans { get; set; }

        [JsonProperty("U_SYP_BPAP", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_BPAP { get; set; }

        [JsonProperty("U_SYP_BPAM", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_BPAM { get; set; }

        [JsonProperty("U_SYP_BPNO", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_BPNO { get; set; }

        [JsonProperty("U_SYP_BPN2", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_BPN2 { get; set; }

        [JsonProperty("U_SYP_BPTP", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_BPTP { get; set; }

        [JsonProperty("U_SYP_BPTD", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_BPTD { get; set; }

        [JsonProperty("U_SYP_BPAT", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_BPAT { get; set; }

        [JsonProperty("U_SYP_AGENRE", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_AGENRE { get; set; }

        [JsonProperty("U_SYP_SNBUEN", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_SNBUEN { get; set; }

        [JsonProperty("U_SYP_TPER", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_TPER { get; set; }

        [JsonProperty("U_SYP_EXOPER", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_EXOPER { get; set; }

        [JsonProperty("U_SYP_DIRSUNAT", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_DIRSUNAT { get; set; }

        [JsonProperty("U_SYP_CONV", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CONV { get; set; }

        [JsonProperty("U_SYP_SVIN", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_SVIN { get; set; }

        [JsonProperty("U_SYP_RETFEC", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_RETFEC { get; set; }

        [JsonProperty("U_SYP_RETRES", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_RETRES { get; set; }

        [JsonProperty("U_SYP_BUEFEC", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_BUEFEC { get; set; }

        [JsonProperty("U_SYP_BUERES", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_BUERES { get; set; }

        [JsonProperty("U_SYP_NOHFEC", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_NOHFEC { get; set; }

        [JsonProperty("U_SYP_PERFEC", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_PERFEC { get; set; }

        [JsonProperty("U_SYP_PERRES", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_PERRES { get; set; }

        [JsonProperty("U_SYP_CDRCLI", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CDRCLI { get; set; }

        [JsonProperty("U_SYP_CDRBINLOC", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CDRBINLOC { get; set; }

        [JsonProperty("U_SYP_TVN", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_TVN { get; set; }

        [JsonProperty("U_SYP_PROVHNRS", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_PROVHNRS { get; set; }

        [JsonProperty("U_SYP_LIBRET", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_LIBRET { get; set; }

        [JsonProperty("U_SYP_APLIFACT", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_APLIFACT { get; set; }

        [JsonProperty("U_SYP_CGT_PRICEFROM", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CGT_PRICEFROM { get; set; }

        [JsonProperty("U_SYP_CUMPL1", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL1 { get; set; }

        [JsonProperty("U_SYP_CUMPL2", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL2 { get; set; }

        [JsonProperty("U_SYP_CUMPL27", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL27 { get; set; }

        [JsonProperty("U_SYP_CUMPL28", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL28 { get; set; }

        [JsonProperty("U_SYP_CUMPL29", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL29 { get; set; }

        [JsonProperty("U_SYP_CUMPL30", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL30 { get; set; }

        [JsonProperty("U_SYP_CUMPL17", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL17 { get; set; }

        [JsonProperty("U_SYP_CUMPL8", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL8 { get; set; }

        [JsonProperty("U_SYP_CUMPL9", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL9 { get; set; }

        [JsonProperty("U_SYP_CUMPL31", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL31 { get; set; }

        [JsonProperty("U_SYP_CUMPL12", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL12 { get; set; }

        [JsonProperty("U_SYP_CUMPL32", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL32 { get; set; }

        [JsonProperty("U_SYP_CUMPL3", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL3 { get; set; }

        [JsonProperty("U_SYP_CUMPL10", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL10 { get; set; }

        [JsonProperty("U_SYP_CUMPL11", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL11 { get; set; }

        [JsonProperty("U_SYP_CUMPL14", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL14 { get; set; }

        [JsonProperty("U_SYP_CUMPL26", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL26 { get; set; }

        [JsonProperty("U_SYP_CUMPL16", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL16 { get; set; }

        [JsonProperty("U_SYP_CUMPL19", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL19 { get; set; }

        [JsonProperty("U_SYP_CUMPL21", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL21 { get; set; }

        [JsonProperty("U_SYP_CUMPL33", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL33 { get; set; }

        [JsonProperty("U_SYP_CUMPL15", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL15 { get; set; }

        [JsonProperty("U_SYP_CUMPL20", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL20 { get; set; }

        [JsonProperty("U_SYP_CUMPL4", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL4 { get; set; }

        [JsonProperty("U_SYP_CUMPL18", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL18 { get; set; }

        [JsonProperty("U_SYP_CUMPL24", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL24 { get; set; }

        [JsonProperty("U_SYP_CUMPL25", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL25 { get; set; }

        [JsonProperty("U_SYP_CUMPL5", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL5 { get; set; }

        [JsonProperty("U_SYP_CUMPL6", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL6 { get; set; }

        [JsonProperty("U_SYP_CUMPL7", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CUMPL7 { get; set; }

        [JsonProperty("U_SYP_CUMPL13", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL13 { get; set; }

        [JsonProperty("U_SYP_CUMPL22", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL22 { get; set; }

        [JsonProperty("U_SYP_CUMPL23", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_CUMPL23 { get; set; }

        [JsonProperty("U_SYP_FEEA", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_FEEA { get; set; }

        [JsonProperty("U_SYP_ESTCONT", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_ESTCONT { get; set; }

        [JsonProperty("U_SYP_CONCONT", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_CONCONT { get; set; }

        [JsonProperty("U_SYP_LTLETINCPER", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_LTLETINCPER { get; set; }

        [JsonProperty("U_GF_COPDIL", NullValueHandling = NullValueHandling.Ignore)]
        public string U_GF_COPDIL { get; set; }

        [JsonProperty("U_GF_FICHRUC", NullValueHandling = NullValueHandling.Ignore)]
        public string U_GF_FICHRUC { get; set; }

        [JsonProperty("U_GF_FICHSELPS", NullValueHandling = NullValueHandling.Ignore)]
        public string U_GF_FICHSELPS { get; set; }

        [JsonProperty("U_GF_FICHINSPS", NullValueHandling = NullValueHandling.Ignore)]
        public string U_GF_FICHINSPS { get; set; }

        [JsonProperty("U_GF_COPPREG", NullValueHandling = NullValueHandling.Ignore)]
        public string U_GF_COPPREG { get; set; }

        [JsonProperty("U_GF_REPCRIESG", NullValueHandling = NullValueHandling.Ignore)]
        public string U_GF_REPCRIESG { get; set; }

        [JsonProperty("U_GF_EEFF_UPA", NullValueHandling = NullValueHandling.Ignore)]
        public string U_GF_EEFF_UPA { get; set; }

        [JsonProperty("U_GF_DEC_JURPS", NullValueHandling = NullValueHandling.Ignore)]
        public string U_GF_DEC_JURPS { get; set; }

        [JsonProperty("U_SGE_INTERCOMPANY", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SGE_INTERCOMPANY { get; set; }

        [JsonProperty("U_SGE_ECOMMERCE", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SGE_ECOMMERCE { get; set; }

        [JsonProperty("U_SGE_DB_ORIGEN", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SGE_DB_ORIGEN { get; set; }

        [JsonProperty("U_SGE_FECHAINTER", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? U_SGE_FECHAINTER { get; set; }

        [JsonProperty("U_SGE_HORAINTER", NullValueHandling = NullValueHandling.Ignore)]
        public int? U_SGE_HORAINTER { get; set; }

        [JsonProperty("U_SGE_SECUENCIA", NullValueHandling = NullValueHandling.Ignore)]
        public int U_SGE_SECUENCIA { get; set; }

        [JsonProperty("U_SGE_ESCENARIO", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SGE_ESCENARIO { get; set; }

        [JsonProperty("U_SYP_TIPOCON", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_TIPOCON { get; set; }

        [JsonProperty("U_GF_COPVIGP", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_COPVIGP { get; set; }

        [JsonProperty("U_GF_FICHCONCL", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_FICHCONCL { get; set; }

        [JsonProperty("U_GF_CUEST_COMPL", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_CUEST_COMPL { get; set; }

        [JsonProperty("U_GF_FECH_HOM_VIG", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_FECH_HOM_VIG { get; set; }

        [JsonProperty("U_GF_ACC1_NOM", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_ACC1_NOM { get; set; }

        [JsonProperty("U_GF_ACC1_DNI", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_ACC1_DNI { get; set; }

        [JsonProperty("U_GF_ACC1_PORACC", NullValueHandling = NullValueHandling.Ignore)]
        public double? U_GF_ACC1_PORACC { get; set; }

        [JsonProperty("U_GF_PVC_NOM", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_PVC_NOM { get; set; }

        [JsonProperty("U_GF_PVC_DNI", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_PVC_DNI { get; set; }

        [JsonProperty("U_GF_DECL_FOND", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_DECL_FOND { get; set; }

        [JsonProperty("U_GF_ESTADO_CIVIL", NullValueHandling = NullValueHandling.Ignore)]
        public object U_GF_ESTADO_CIVIL { get; set; }

        [JsonProperty("U_SYP_AGTR", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_AGTR { get; set; }

        [JsonProperty("U_SYP_FETMTC", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_FETMTC { get; set; }

        [JsonProperty("U_SYP_FETENT", NullValueHandling = NullValueHandling.Ignore)]
        public string U_SYP_FETENT { get; set; }

        [JsonProperty("U_SYP_FETAUT", NullValueHandling = NullValueHandling.Ignore)]
        public object U_SYP_FETAUT { get; set; }

        [JsonProperty("ElectronicProtocols", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> ElectronicProtocols { get; set; }

        [JsonProperty("BPAddresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<BPAddress> BPAddresses { get; set; }

        [JsonProperty("ContactEmployees", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContactEmployee> ContactEmployees { get; set; }

        [JsonProperty("BPAccountReceivablePaybleCollection", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> BPAccountReceivablePaybleCollection { get; set; }

        [JsonProperty("BPPaymentMethods", NullValueHandling = NullValueHandling.Ignore)]
        public List<BPPaymentMethod> BPPaymentMethods { get; set; }

        [JsonProperty("BPPaymentDates", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> BPPaymentDates { get; set; }

        [JsonProperty("BPBranchAssignment", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> BPBranchAssignment { get; set; }

        [JsonProperty("BPBankAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<BPBankAccount> BPBankAccounts { get; set; }

        [JsonProperty("BPFiscalTaxIDCollection", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> BPFiscalTaxIDCollection { get; set; }

        [JsonProperty("DiscountGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> DiscountGroups { get; set; }

        [JsonProperty("BPBlockSendingMarketingContents", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> BPBlockSendingMarketingContents { get; set; }




    }
}