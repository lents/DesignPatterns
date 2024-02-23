var handler = new DiscountApproval();
handler
    .SetNext(new VipDiscountApproval())
    .SetNext(new StockClearanceDiscountApproval())
    .SetNext(new GlobalDiscountApproval());
handler.Handle(new Order { ClientCode = "1", ProductCode = "2" }, 100);
handler.Handle(new Order { ClientCode = "10", ProductCode = "2" }, 50);
handler.Handle(new Order { ClientCode = "100", ProductCode = "200" }, 100);
Console.ReadLine ();
