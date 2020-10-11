using System;

namespace Adept.OOP
{
    interface IProduct
    {
        void Display();
        string Name { get; }
        double Price { get; }
        int Size { get; }
    }
}
