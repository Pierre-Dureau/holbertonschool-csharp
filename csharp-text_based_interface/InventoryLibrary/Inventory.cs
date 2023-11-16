using System;
using InventoryLibrary;

public class Inventory : BaseClass
{
    public string user_id {  get; set; }
    public string item_id { get; set; }
    public int quantity {
        get { return quantity; }
        set { quantity = (value >= 0) ? value : throw new Exception("Quantity cannot be less than 0"); }
    }
}
