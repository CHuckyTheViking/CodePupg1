using CodePupg1.Animal;
using CodePupg1.Customer;
using CodePupg1.MainMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1
{
    public class Application : IApplication
    {
        private IKennelMainMenu KennelMainMenu;
        private IAnimalManager AnimalManager;
        private ICustomerManager CustomerManager;

        public Application(IKennelMainMenu kennelMainMenu, IAnimalManager animalManager, ICustomerManager customerManager)
        {
            KennelMainMenu = kennelMainMenu;
            AnimalManager = animalManager;
            CustomerManager = customerManager;
        }

        public void Run()
        {
            CustomerManager.Init();
            AnimalManager.Init();

            while (true)
            {
                KennelMainMenu.Init();
                KennelMainMenu.Choice();
            }



        }

    }
}
