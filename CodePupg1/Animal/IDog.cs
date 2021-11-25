using CodePupg1.Customer;
using CodePupg1.Service;

namespace CodePupg1.Animal
{
    public interface IDog
    {
        string Breed { get; set; }
        IClipping Clipping { get; set; }
        IGrooming Grooming { get; set; }
        int Id { get; set; }
        bool IsHere { get; set; }
        string Name { get; set; }
        ICustomerInfo Owner { get; set; }
    }
}