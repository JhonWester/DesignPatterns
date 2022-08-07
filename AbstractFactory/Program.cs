// See https://aka.ms/new-console-template for more information
using AbstractFactory.ConcreteFactories;
using AbstractFactory.Interfaces;

Console.WriteLine("Hello, World!");

Console.WriteLine("Client: Testing client code with the first factory type...");
ClientMethod(new ConcreteFactory1());
Console.WriteLine();

Console.WriteLine("Client: Testing the same client code with the second factory type...");
ClientMethod(new ConcreteFactory2());


static void ClientMethod(IAbstractFactory factory)
{
    var productA = factory.CreateProductA();
    var productB = factory.CreateProductB();

    Console.WriteLine(productB.UseFulFunctionB());
    Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
}