using CodePupg1.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Service
{
    class ServiceManager : IServiceManager
    {
        private IGrooming Grooming;
        private IClipping Clipping;
        private Animals Animals;

        public ServiceManager(IGrooming grooming, IClipping clipping, Animals animals)
        {
            Grooming = grooming;
            Clipping = clipping;
            Animals = animals;
        }

        public void AddService()
        {
            Console.WriteLine("Grooming 1 | Clipping 2");
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    var choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        repeat = false;
                        Console.Clear();
                        AddGrooming();
                    }
                    if (choice == 2)
                    {
                        repeat = false;
                        Console.Clear();
                        AddClipping();
                    }
                    else
                    {
                        Console.WriteLine("Please enter right information");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter right information");
                }
            }

        }

        public void AddGrooming()
        {
            Console.WriteLine("-- Grooming --");
            Console.WriteLine("Please enter ID of animal: ");
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    var id = Convert.ToInt32(Console.ReadLine());
                    var animal = Animals.animals.FirstOrDefault(x => x.Id == id);
                    if (animal != null)
                    {
                        if (animal.IsHere == true)
                        {
                            if (animal.Grooming == null)
                            {
                                animal.Grooming = Grooming;
                                Console.WriteLine("Grooming added");
                                repeat = false;
                            }
                            else
                            {
                                Console.WriteLine("Animal has already been groomed today.");
                                repeat = false;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Can't add service, animal not in kennel today");
                            repeat = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No animal with that ID");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter right information");
                }
            }

            Console.ReadKey();

        }

        public void AddClipping()
        {
            Console.WriteLine("-- Clipping --");
            Console.WriteLine("Please enter ID of animal: ");

            bool repeat = true;
            while (repeat)
            {
                try
                {
                    var id = Convert.ToInt32(Console.ReadLine());
                    var animal = Animals.animals.FirstOrDefault(x => x.Id == id);
                    if (animal != null)
                    {
                        if (animal.IsHere == true)
                        {
                            if (animal.Clipping == null)
                            {
                                animal.Clipping = Clipping;
                                Console.WriteLine("Clipping added");
                                repeat = false;
                            }
                            else
                            {
                                Console.WriteLine("Animal has already been clipped today.");
                                repeat = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Can't add service, animal not in kennel today");
                            repeat = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No animal with that ID");
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter right information");
                }
            }


            
            Console.ReadKey();
        }
    }
}
