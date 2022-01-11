using Solid.Interfaces;
using System;

namespace Solid
{
    public class Program
    {
        static void Main(string[] args)
        {
            IMenuManager manager = Factory.CreateMenu();
            manager.Menu();
        }
    }
}
