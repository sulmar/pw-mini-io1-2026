var coffeeMachine = new CoffeeMachine();

Console.WriteLine();
Console.WriteLine(coffeeMachine.ToMermaidGraph());

Console.WriteLine(coffeeMachine.State); // Off

coffeeMachine.Fail();
System.Console.WriteLine(coffeeMachine.State);

coffeeMachine.Repair();
Console.WriteLine(coffeeMachine.State); // Ready

coffeeMachine.Fail();
Console.WriteLine(coffeeMachine.State); // Broken

coffeeMachine.Repair();
Console.WriteLine(coffeeMachine.State); // Off


coffeeMachine.TurnOn();
Console.WriteLine(coffeeMachine.State); // Ready

