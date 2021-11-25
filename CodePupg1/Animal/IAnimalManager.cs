using CodePupg1.Customer;

namespace CodePupg1.Animal
{
    public interface IAnimalManager
    {
       
        void ShowAnimals();
        void ShowDroppedOfAnimals();
        void CreateDog();
        void CreateDogMockData(string name, int id);
        void Init();
    }
}