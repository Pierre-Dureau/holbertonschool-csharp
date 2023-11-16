using System;
using System.Collections.Generic;
using System.Text.Json;
using InventoryLibrary;

public class JSONStorage
{
    public Dictionary<string, BaseClass> objects;

    public JSONStorage() => objects = new Dictionary<string, BaseClass>();

    public Dictionary<string, BaseClass> All() => objects;

    public void New(BaseClass obj) => objects.Add($"{obj.GetType().Name}.{obj.id}", obj);

    public void Save() {
        string jsonString = JsonSerializer.Serialize(objects);
        File.WriteAllText("../storage/inventory_manager.json", jsonString);
    }

    public void Load() {
        if (File.Exists("../storage/inventory_manager.json")) {
            string jsonString = File.ReadAllText("../storage/inventory_manager.json");
            Dictionary<string, string> myDictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
        }
    }
}