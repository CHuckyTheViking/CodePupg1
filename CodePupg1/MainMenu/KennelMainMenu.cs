using CodePupg1.Animal;
using CodePupg1.Customer;
using CodePupg1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.MainMenu
{
    class KennelMainMenu : IKennelMainMenu
    {

        private IMainMenuManager MainMenuManager;
        private ICustomerManager CustomerManager;
        private IAnimalManager AnimalManager;
        private IDropOrPickup DropOrPickup;
        private IServiceManager ServiceManager;

        public KennelMainMenu(IMainMenuManager mainMenuManager, ICustomerManager customerManager, IAnimalManager animalManager, IDropOrPickup dropOrPickup, IServiceManager serviceManager)
        {
            MainMenuManager = mainMenuManager;
            CustomerManager = customerManager;
            AnimalManager = animalManager;
            DropOrPickup = dropOrPickup;
            ServiceManager = serviceManager;
        }

        public void Init()
        {
            MainMenuManager.CreateMainMenu("Best Kennel in town");
            MainMenuManager.CreateMainMenuItem(1, "Create Customer", CustomerManager.CreateCustomer);
            MainMenuManager.CreateMainMenuItem(2, "Show Customers", CustomerManager.ShowCustomers);
            MainMenuManager.CreateMainMenuItem(3, "Add Animal", AnimalManager.CreateDog);
            MainMenuManager.CreateMainMenuItem(4, "Show Animals", AnimalManager.ShowAnimals);
            MainMenuManager.CreateMainMenuItem(5, "Drop of animal", DropOrPickup.DropOffAnimal);
            MainMenuManager.CreateMainMenuItem(6, "Pick up animal", DropOrPickup.PickupAnimal);
            MainMenuManager.CreateMainMenuItem(7, "Animals in Kennel", AnimalManager.ShowDroppedOfAnimals);
            MainMenuManager.CreateMainMenuItem(8, "Add service to animal", ServiceManager.AddService);
            MainMenuManager.ShowMainMenu();
            
        }

        public void Choice()
        {
       
                var userInput = Console.ReadKey(true);

                foreach (var mainMenuItem in MainMenuManager.GetMainMenu().mainMenuItems)
                {
                    if (mainMenuItem.Selector.ToString() == userInput.KeyChar.ToString())
                    {
                        Console.Clear();
                        mainMenuItem.RunThis();
                        
                    }
                    else if (userInput.KeyChar == 'x')
                    {
                        Console.WriteLine("See you soon!");
                        Environment.Exit(0);
                    }
                }
            Console.Clear();
            
        }


    }
}
