// See https://aka.ms/new-console-template for more information
using FactoryMethod.Class;
using FactoryMethod.Concept;
using System;

namespace factoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App launched with creator concrete 1");
            ClientCreator(new CreatorConcrete1());

            Console.WriteLine("App launched with creator concrete 2");
            ClientCreator(new CreatorConcrete2());
        }
        public static void ClientCreator(Creator creator)
        {
            Console.WriteLine(creator.SomeOperation());
        }
    }
}


