using CodePupg1.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePupg1.Animal
{


    public class Animals
    {
        private List<IDog> listAnimals = new List<IDog>();
        public List<IDog> animals
        {
            get
            {
                return listAnimals;
            }
        }


    }
}
