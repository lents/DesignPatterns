FoodSupplier supplier = new FoodSupplier
{
    Name = "Elena",
    PhoneNumber = "+7*****",
    Address = "Moscow, Kreml"
};

SupplierMemory memory = new SupplierMemory();
memory.Memento = supplier.SaveState();

Console.WriteLine(supplier);

supplier.Address = "Saint-Petersburg, Nevsky pr.";

Console.WriteLine(supplier);

supplier.RestoreState(memory.Memento);

Console.WriteLine(supplier);

Console.ReadLine();