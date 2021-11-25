using CodePupg1.Customer;
using CodePupg1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Animal
{
    public class Dog : IDog
    {

        public delegate Dog Factory(string breed, string name, bool isHere, int id, ICustomerInfo owner);
        public string Breed { get; set; }
        public string Name { get; set; }
        public bool IsHere { get; set; }
        public ICustomerInfo Owner { get; set; }
        public IClipping Clipping { get; set; }
        public IGrooming Grooming { get; set; }
        public int Id { get; set; }

        public Dog(string breed, string name, bool isHere, ICustomerInfo owner, int id)
        {
            Breed = breed;
            Name = name;
            IsHere = isHere;
            Owner = owner;
            Id = id;
        }

        public Dog()
        {

        }


    }
}
