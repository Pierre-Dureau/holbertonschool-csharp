using System;
using System.Collections.Generic;
using InventoryLibrary;

public class Item : BaseClass
{
    public string name { get; set; }
    public string description { get; set; }
    public float price {
        get { return price };
        set { price = (float)Math.Round(value, 2) }; 
    }
    public List<string> tags {  get; set; }
}

