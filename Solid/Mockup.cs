using Solid.Interfaces;
using Solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Mockup
    {
        public static List<IAnimal> CreateMockAnimals()
        {
            // Create a list of dogs to use for testing
            var animals = new List<IAnimal>
            {
                 new Dog { AnimalName = "Pampas", Owner = new Customer() { UserName = "Maj-Britt" }, IsCheckedIn = true, ClawCutting = new ClawCutting() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } },
                 new Dog { AnimalName = "Karras", Owner = new Customer() { UserName = "Uno" }, IsCheckedIn = true, ClawCutting = new ClawCutting() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } },
                 new Dog { AnimalName = "Tellus", Owner = new Customer() { UserName = "Camilla" }, IsCheckedIn = true, ClawCutting = new ClawCutting() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } },
                 new Dog { AnimalName = "Tissla", Owner = new Customer() { UserName = "Johan" }, IsCheckedIn = false, ClawCutting = new ClawCutting() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } },
                 new Dog { AnimalName = "Gwyijn", Owner = new Customer() { UserName = "Berka" }, IsCheckedIn = false, ClawCutting = new ClawCutting() { Status = false }, Wash = new Wash() { Status = false }, StandardService = new StandardService() { Status = false } }
            };
            return animals;
        }

        public static List<ICustomer> CreateMockCustomers()
        {
            var customers = new List<ICustomer>
            {
                new Customer { SSO = 1940, UserName = "Maj-Britt", Email = "majbritt@domain.com", Phone = 0701234567, Animals = new() {}, },
                new Customer { SSO = 1950, UserName = "Uno", Email = "uno@domain.com", Phone = 0702345678, Animals = new() { } },
                new Customer { SSO = 1960, UserName = "Camilla", Email = "camilla@domain.com", Phone = 0703456789, Animals = new() { } },
                new Customer { SSO = 1970, UserName = "Johan", Email = "johan@domain.com", Phone = 0707654321, Animals = new() { } },
                new Customer { SSO = 1980, UserName = "Berka", Email = "berka@domain.com", Phone = 0706543210, Animals = new() { } }
            };
            return customers;
        }

    }
}
