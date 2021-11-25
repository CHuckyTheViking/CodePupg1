using CodePupg1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Animal
{
    class DropOrPickup : IDropOrPickup
    {
        private Animals Animals;
        private IGrooming Grooming;
        private IClipping Clipping;

        public DropOrPickup(Animals animals, IGrooming grooming, IClipping clipping)
        {
            Animals = animals;
            Grooming = grooming;
            Clipping = clipping;
        }

        public void DropOffAnimal()
        {
            Console.WriteLine("Please enter the ID of the animal: ");

            bool repeat = true;
            while (repeat)
            {
                try
                {
                    var id = Convert.ToInt32(Console.ReadLine());

                    if (id >= 1)
                    {
                        var animal = Animals.animals.FirstOrDefault(x => x.Id == id);

                        if (animal != null)
                        {
                            animal.IsHere = true;
                            Console.WriteLine(animal.Name + " Has been dropped of");
                            repeat = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong ID");
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

        public void PickupAnimal()
        {
            Console.WriteLine("Please enter the ID of the animal: ");
            bool repeat = true;
            while (repeat)
            {
                try
                {
                    var id = Convert.ToInt32(Console.ReadLine());

                    if (id >= 1)
                    {
                        var animal = Animals.animals.FirstOrDefault(x => x.Id == id);

                        if (animal != null)
                        {
                            if (animal.IsHere == true)
                            {
                                animal.IsHere = false;
                                
                                Console.WriteLine(animal.Name + " Has been picked up");
                                Console.WriteLine("------ Receipt ------");
                                Console.WriteLine("-- Day cost: 20$ --");
                                if (animal.Grooming != null)
                                {
                                    Console.WriteLine($"-- {animal.Grooming.ReceiptText}$  --");
                                }
                                if (animal.Clipping != null)
                                {
                                    Console.WriteLine($"-- {animal.Clipping.ReceiptText}$  --");
                                }
                                Console.WriteLine("---------------------");

                                animal.Grooming = null;
                                animal.Clipping = null;
                                repeat = false;
                            }
                        }
                        
                        else
                        {
                            Console.WriteLine("Wrong ID");
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

    }
}
