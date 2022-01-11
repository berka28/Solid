using Solid.Interfaces;
using Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    static class Factory
    {

        public static IMenuManager CreateMenu()
        {
            return new MenuManager();
        }


        public static ICustomer CreateCustomer()
        {
            return new Customer();
        }

        public static IAnimal CreateAnimal()
        {
            return new Dog();
        }

        public static IStandardService CreateStandardService()
        {
            return new StandardService();
        }
        public static IWash CreateWash()
        {
            return new Wash();
        }

        public static IClawCutting CreateClowCutting()
        {
            return new ClawCutting();
        }

        public static IReceipt CreateReceipt()
        {
            return new Receipt();
        }

        public static ISetServicePriceName SetPriceName()
        {
            return new SetServicePriceName();
        }

    }
}
