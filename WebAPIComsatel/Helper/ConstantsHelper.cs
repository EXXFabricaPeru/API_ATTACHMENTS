using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIComsatel.Helper
{
    public static class ConstantsHelper
    {
        public const string SUCCESS = "Success";
        public const string ERROR = "Error";

        public const string LOGIN = "/b1s/v1/Login";
        public const string PURCHASE_QUOTATIONS = "/b1s/v1/PurchaseQuotations";
        public const string PURCHASE_ORDERS = "/b1s/v1/PurchaseOrders";
        public const string PURCHASE_INVOICES = "/b1s/v1/PurchaseInvoices";
        public const string PURCHASE_DELIVERYNOTES = "/b1s/v1/PurchaseDeliveryNotes";
        public const string DRAFTS = "/b1s/v1/Drafts";
        public const string APPROVALREQUESTS = "/b1s/v1/ApprovalRequests";
        public const string USERS = "/b1s/v1/Users";
        public const string PATH_ADMIN = "/b1s/v1/CompanyService_GetPathAdmin";
        public const string PAYMENT_TERMS_TYPES = "/b1s/v1/PaymentTermsTypes";
        public const string APPROVAL_REQUEST_VIEW = "/b1s/v1/sml.svc/OAVWParameters(USER={0})/OAVW";
        public const string APPROVAL_REQUEST_VIEW_FILTER = "/b1s/v1/sml.svc/OAVWParameters(USER={1})/OAVW?$filter=Status eq '{0}'";
        public const string COMPANY_SERVICES = "/b1s/v1/CompanyService_GetAdminInfo";
        public const string EMPLOYEES = "/b1s/v1/EmployeesInfo";
        public const string PROJECTS = "/b1s/v1/ProjectsService_GetProjectList";
        public const string FAMILIA = "/b1s/v1/FAMILIA";
        public const string BUSINESS_PARTNERS = "/b1s/v1/BusinessPartners";
        public const string PURCHASE_REQUEST = "/b1s/v1/PurchaseRequests";

        public const string PURCHASE_QUOTATIONS_FAMILIA = "/b1s/v1/$crossjoin(PurchaseQuotations,PurchaseQuotations/DocumentLines,Items)?$expand=PurchaseQuotations($select=DocEntry,DocNum,CardCode,CardName,Project,DocDate,TaxDate,DocDueDate,DocTotal,DocTotalFc,DocCurrency,DocRate,VatSum,VatSumFc,RequriedDate),PurchaseQuotations/DocumentLines($select=DocEntry,LineNum,ItemCode,ItemDescription,Quantity,Price,UnitPrice,LineTotal,TaxTotal,RequiredDate,RequiredQuantity,WarehouseCode,ShipDate,CostingCode,CostingCode2,CostingCode3,CostingCode4,CostingCode5),Items($select=U_SYP_FAMILIA,U_SYP_SUBFAMILIA)&$filter=PurchaseQuotations/DocEntry eq PurchaseQuotations/DocumentLines/DocEntry and PurchaseQuotations/DocumentLines/ItemCode eq Items/ItemCode  ";// and Items/U_SYP_FAMILIA eq '{0}'";
        public const string PURCHASE_QUOTATIONS_SUB_FAMILIA = "/b1s/v1/$crossjoin(PurchaseQuotations,PurchaseQuotations/DocumentLines,Items)?$expand=PurchaseQuotations($select=DocEntry,DocNum,CardCode,CardName,Project,DocDate,TaxDate,DocDueDate,DocTotal,DocTotalFc,DocCurrency,DocRate,VatSum,VatSumFc,RequriedDate),PurchaseQuotations/DocumentLines($select=DocEntry,LineNum,ItemCode,ItemDescription,Quantity,Price,UnitPrice,LineTotal,TaxTotal,RequiredDate,RequiredQuantity,WarehouseCode,ShipDate,CostingCode,CostingCode2,CostingCode3,CostingCode4,CostingCode5),Items($select=U_SYP_FAMILIA,U_SYP_SUBFAMILIA)&$filter=PurchaseQuotations/DocEntry eq PurchaseQuotations/DocumentLines/DocEntry and PurchaseQuotations/DocumentLines/ItemCode eq Items/ItemCode "; //  and Items/U_SYP_SUBFAMILIA eq '{0}'";
        public const string APPROVE = "ardApproved";
        public const string REJECT = "ardNotApproved";


        public const string ATTACHMENTS = "/b1s/v1/Attachments2";



        //TYPE

        public const string OFERTA_COMPRA = "OF";
        public const string ORDEN_COMPRA = "OC";
        public const string ENTRADA_COMPRA = "EC";
        public const string FACTURA_COMPRA = "FC";
        public const string ANTICIPO_COMPRA = "AC";

        public const string OBJ_OFERTA_COMPRA = "540000006";
        public const string OBJ_ORDEN_COMPRA = "22";
        public const string OBJ_ENTRADA_COMPRA = "20";
        public const string OBJ_FACTURA_COMPRA = "18";
        public const string OBJ_ANTICIPO_COMPRA = "204";


        public const string oPurchaseQuotations = "oPurchaseQuotations";
        public const string oPurchaseOrders = "oPurchaseOrders";
        public const string oPurchaseDeliveryNotes = "oPurchaseDeliveryNotes";
        public const string oPurchaseInvoices = "oPurchaseInvoices";

        public const string filterDraft = "?$filter=(DocObjectCode eq 'oPurchaseQuotations' or DocObjectCode eq 'oPurchaseOrders' or DocObjectCode eq 'oPurchaseDeliveryNotes' or DocObjectCode eq 'oPurchaseInvoices' ) and AuthorizationStatus eq 'dasPending'";
        public const string filterApprovalRequests = "?$filter=Status eq 'W' and (ObjectType eq '" + OBJ_OFERTA_COMPRA + "' or " +
            "ObjectType eq '" + OBJ_ORDEN_COMPRA + "' or " +
            "ObjectType eq '" + OBJ_ENTRADA_COMPRA + "' or " +
            "ObjectType eq '" + OBJ_FACTURA_COMPRA + "'" +
            ") and OriginatorID eq ";
        public const string filterUsers = "?$filter=UserCode eq ";

        public const string filterApproval = "/b1s/v1/$crossjoin(ApprovalRequests,ApprovalRequests/ApprovalRequestLines,Drafts)" +
            "?$expand=ApprovalRequests($select=Code,DraftEntry,Remarks,ObjectType,Status)," +
            "ApprovalRequests/ApprovalRequestLines($select=UserID)," +
            "Drafts($select=CardCode,Project,CardName,U_SYP_TCOMPRA)" + //U_SYP_TCOMPRA
            "&$filter=ApprovalRequests/DraftEntry eq Drafts/DocEntry " +
            "and ApprovalRequests/Status eq '{0}' " +
            "and (ObjectType eq '22' or ObjectType eq '540000006'or ObjectType eq '18'or ObjectType eq '20' )" +
            "and  ApprovalRequests/ApprovalRequestLines/UserID eq {1}"+
        "&$orderby=ApprovalRequests/DraftEntry desc";

        public const string filterApprovalALL = "/b1s/v1/$crossjoin(ApprovalRequests,ApprovalRequests/ApprovalRequestLines,Drafts)" +
           "?$expand=ApprovalRequests($select=Code,DraftEntry,Remarks,ObjectType,Status)," +
           "ApprovalRequests/ApprovalRequestLines($select=UserID)," +
           "Drafts($select=CardCode,Project,CardName,U_SYP_TCOMPRA)" + //U_SYP_TCOMPRA
           "&$filter=ApprovalRequests/DraftEntry eq Drafts/DocEntry " +
           "and (ObjectType eq '22' or ObjectType eq '540000006'or ObjectType eq '18'or ObjectType eq '20' )" +
           "and  ApprovalRequests/ApprovalRequestLines/UserID eq {0} "+
           "&$orderby=ApprovalRequests/DraftEntry desc";


        //STATUS

        public const int status_ALL = 0;
        public const int status_Pendiente = 1;
        public const int status_Aprobado = 2;
        public const int status_Rechazado = 3;

        public const string status_Pendiente_SAP = "W";
        public const string status_Aprobado_SAP = "Y";
        public const string status_Rechazado_SAP = "N";

        public const string status_Pendiente_SAP_Detalle = "arsPending";
        public const string status_Aprobado_SAP_Detalle = "arsApproved";
        public const string status_Rechazado_SAP_Detale = "arsNotApproved";


    }
}