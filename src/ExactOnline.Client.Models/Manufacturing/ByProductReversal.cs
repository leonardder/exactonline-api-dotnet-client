using System;

namespace ExactOnline.Client.Models.Manufacturing
{
    [SupportedActionsSDK(true, true, false, false)]
    [DataServiceKey("ReversalStockTransactionId")]
    public class ByProductReversal
    {
        /// <summary>ID of creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? CreatedBy { get; set; }
        /// <summary>Name of the creating user</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string CreatedByFullName { get; set; }
        /// <summary>Date of this reversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>Boolean indicating if this reversal was the result of shop order backflushing, processed during a ShopOrderReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public bool IsBackflush { get; set; }
        /// <summary>Does the ByProductReversal&apos;s item use batch numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsBatch { get; set; }
        /// <summary>Indicates if fractions (for example 0.35) are allowed for quantities of the ByProductReversal&apos;s item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsFractionAllowedItem { get; set; }
        /// <summary>Does the ByProductReversal&apos;s item use serial numbers</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public byte? IsSerial { get; set; }
        /// <summary>Item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Item { get; set; }
        /// <summary>Code of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemCode { get; set; }
        /// <summary>Description of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemDescription { get; set; }
        /// <summary>Picture url of by-product item</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string ItemPictureUrl { get; set; }
        /// <summary>Notes associated with this reversal</summary>
        public string Note { get; set; }
        /// <summary>ID of the original stock transaction, which was reversed</summary>
        public Guid? OriginalStockTransactionId { get; set; }
        /// <summary>Quantity reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public double? Quantity { get; set; }
        /// <summary>ID of stock transaction related to this ByProductReversal</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid ReversalStockTransactionId { get; set; }
        /// <summary>Shop order being reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrder { get; set; }
        /// <summary>ID of shop order material plan</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? ShopOrderMaterialPlan { get; set; }
        /// <summary>Number of shop order being reversed to</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public int? ShopOrderNumber { get; set; }
        /// <summary>ID of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? StorageLocation { get; set; }
        /// <summary>Code of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationCode { get; set; }
        /// <summary>Description of storage location reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string StorageLocationDescription { get; set; }
        /// <summary>Effective date of this ByProductReversal</summary>
        public DateTime? TransactionDate { get; set; }
        /// <summary>Unit of measurement abbreviation of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string Unit { get; set; }
        /// <summary>Unit of measurement of item reversed</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string UnitDescription { get; set; }
        /// <summary>ID of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public Guid? Warehouse { get; set; }
        /// <summary>Code of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseCode { get; set; }
        /// <summary>Description of warehouse reversed from</summary>
        [SDKFieldType(FieldType.ReadOnly)]
        public string WarehouseDescription { get; set; }
    }
}
