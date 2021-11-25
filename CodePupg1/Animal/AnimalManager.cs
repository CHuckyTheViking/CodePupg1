using CodePupg1.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Animal
{
    class AnimalManager : IAnimalManager
    {
        private ICustomerManager CustomerManager;
        private Animals Animals;
        private IDog Dog;
        private Dog.Factory Dogfactory;

        public AnimalManager(ICustomerManager customerManager, Animals animals, IDog dog, Dog.Factory dogfactory)
        {
            CustomerManager = customerManager;
            Animals = animals;
            Dog = dog;
            Dogfactory = dogfactory;
        }

        public void Init()
        {
            CreateDogMockData("Hunden", 1);
            CreateDogMockData("Blixten", 2);
        }


        public void CreateDogMockData(string name, int id)
        {

            Dog.Breed = "Boxer";
            Dog.Id = id;
            Dog.IsHere = false;
            Dog.Name = name;
            Dog.Owner = CustomerManager.FindOwner(10);
            Animals.animals.Add(Dogfactory(Dog.Breed, Dog.Name, Dog.IsHere, Dog.Id, Dog.Owner));

        }

        public void CreateDog()
        {
            Console.WriteLine("\n Please enter the dogs name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter the breed: ");
            var breed = Console.ReadLine();

            Dog.Breed = breed;
            Dog.Id = Animals.animals.Count() + 1;
            Dog.IsHere = false;
            Dog.Name = name;

            Console.WriteLine("Please select the owner: ");
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    var customerId = Convert.ToInt32(Console.ReadLine());
                    if (customerId >= 1)
                    {
                        var owner = CustomerManager.FindOwner(customerId);
                        if (owner != null)
                        {
                            Dog.Owner = owner;
                            Animals.animals.Add(Dog);
                            Console.WriteLine("The animal has been added");
                            repeat = false;
                        }
                        else
                        {
                            Console.WriteLine("No customer was found.");
                            repeat = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter right information.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter right information.");
                }
            }
            Console.ReadKey();
        }

        public void ShowAnimals()
        {
            Console.WriteLine("Animals:  ");

            foreach (var animal in Animals.animals)
            {
                Console.WriteLine("");
                Console.WriteLine("Id: " + animal.Id);
                Console.WriteLine("Breed:  " + animal.Breed);
                Console.WriteLine("Name: " + animal.Name);
                Console.WriteLine("Checked in:  " + animal.IsHere);
                Console.WriteLine("----- Owner -----");
                if (animal.Owner != null)
                {
                    Console.WriteLine("Name: " + animal.Owner.FirstName + " " + animal.Owner.LastName);
                    Console.WriteLine("Id: " + animal.Owner.Id);
                }
                Console.WriteLine("--------------------------------------");
            }

            Console.ReadKey();
        }

        public void ShowDroppedOfAnimals()
        {
            Console.WriteLine("Animals in kennel:  ");

            foreach (var animal in Animals.animals)
            {
                if (animal.IsHere == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Id: " + animal.Id);
                    Console.WriteLine("Breed:  " + animal.Breed);
                    Console.WriteLine("Name: " + animal.Name);
                    Console.WriteLine("Checked in:  " + animal.IsHere);
                    if (animal.Grooming != null)
                    {
                        Console.WriteLine(animal.Grooming.ReceiptText);
                    }
                    if (animal.Clipping != null)
                    {
                        Console.WriteLine(animal.Clipping.ReceiptText);
                    }
                    Console.WriteLine("----- Owner -----");
                    if (animal.Owner != null)
                    {
                        Console.WriteLine("Name: " + animal.Owner.FirstName + " " + animal.Owner.LastName);
                        Console.WriteLine("Id: " + animal.Owner.Id);
                    }
                    Console.WriteLine("--------------------------------------");
                }
            }

            Console.ReadKey();
        }
    }
}
