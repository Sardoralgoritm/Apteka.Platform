﻿using Domian.Entities.Branchs;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domian.Entities.Receipts;

[Table("receipts")]
public class Receipt : Auditable
{
    [Column("branch_id")]
    public Guid BranchId { get; set; }
    public Branch Branch { get; set; } = new Branch();
    [Column("total_price")]
    public double TotalPrice { get; set; }
    [Column("tax_price")]
    public double TaxPrice { get; set; }
    public List<ReceiptItems> ReceiptItems { get; set; } = new();
}
