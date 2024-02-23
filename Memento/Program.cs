FoodSupplier supplier = new FoodSupplier
{
    Name = "Elena",
    PhoneNumber = "+7*****",
    Address = "Moscow, Kreml"
};

SupplierMemory memory = new SupplierMemory();
memory.Memento = supplier.SaveState();

supplier.Address = "Saint-Petersburg, Nevsky pr.";

supplier.RestoreState(memory.Memento);
Console.ReadLine();