using DogDoorApp.Models;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoorSimulator.TestDogDoor(20000);
            DogDoorSimulator.TestDogDoor(1000);
        }
    }
}
